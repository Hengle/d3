import os
import sys
import google.protobuf.descriptor_pb2 as pb2

class ProtobinDecompiler:
	label_map = {
		pb2.FieldDescriptorProto.LABEL_OPTIONAL: "optional",
		pb2.FieldDescriptorProto.LABEL_REQUIRED: "required",
		pb2.FieldDescriptorProto.LABEL_REPEATED: "repeated"
	}

	type_map = {
		pb2.FieldDescriptorProto.TYPE_DOUBLE: "double",
		pb2.FieldDescriptorProto.TYPE_FLOAT: "float",
		pb2.FieldDescriptorProto.TYPE_INT64: "int64",
		pb2.FieldDescriptorProto.TYPE_UINT64: "uint64",
		pb2.FieldDescriptorProto.TYPE_INT32: "int32",
		pb2.FieldDescriptorProto.TYPE_FIXED64: "fixed64",
		pb2.FieldDescriptorProto.TYPE_FIXED32: "fixed32",
		pb2.FieldDescriptorProto.TYPE_BOOL: "bool",
		pb2.FieldDescriptorProto.TYPE_STRING: "string",
		pb2.FieldDescriptorProto.TYPE_BYTES: "bytes",
		pb2.FieldDescriptorProto.TYPE_UINT32: "uint32",
		pb2.FieldDescriptorProto.TYPE_SFIXED32: "sfixed32",
		pb2.FieldDescriptorProto.TYPE_SFIXED64: "sfixed64",
		pb2.FieldDescriptorProto.TYPE_SINT32: "sint32",
		pb2.FieldDescriptorProto.TYPE_SINT64: "sint64"
	}

	def __init__(self):
		pass
	
	def decompile(self, file_name, out_dir = ".", stdout=False):
		file = open(file_name, "rb")
		data = file.read()
		file.close()
		descriptor = pb2.FileDescriptorProto.FromString(data)

		out = None
		if stdout:
			out = sys.stdout
		else:
			out_file_name = os.path.join(out_dir, descriptor.name)
			out_full_dir = os.path.dirname(out_file_name)
			if not os.path.exists(out_full_dir):
				os.makedirs(out_full_dir)
			out = open(out_file_name, "wb")
		
		self.indent_level = 0
		try:
			self.decompile_file_descriptor(out, descriptor)
		except:
			print "Failed decompiling %s" % file_name
			print "Descriptor dump:"
			print descriptor
			raise
	
	def decompile_file_descriptor(self, out, descriptor):
		# deserialize package name and dependencies
		if descriptor.HasField("package"):
			self.write(out, "package %s;\n" % descriptor.package)

		for dep in descriptor.dependency:
			self.write(out, "import \"%s\";\n" % dep)

		self.write(out, "\n")

		# enumerations
		for enum in descriptor.enum_type:
			self.decompile_enum_type(out, enum)

		# messages
		for msg in descriptor.message_type:
			self.decompile_message_type(out, msg)
		
		# services
		for service in descriptor.service:
			self.decompile_service(out, service)
	
	def decompile_message_type(self, out, msg):
		self.write(out, "message %s {\n" % msg.name)
		self.indent_level += 1

		# deserialize nested messages
		for nested_msg in msg.nested_type:
			self.decompile_message_type(out, nested_msg)

		# deserialize nested enumerations
		for nested_enum in msg.enum_type:
			self.decompile_enum_type(out, nested_enum)

		# deserialize fields
		for field in msg.field:
			self.decompile_field(out, field)
		
		# extension ranges
		for range in msg.extension_range:
			end_name = range.end
			if end_name == 0x20000000:
				end_name = "max"
			self.write(out, "extensions %s to %s;\n" % (range.start, end_name))
		
		# extensions
		for extension in msg.extension:
			self.decompile_extension(out, extension)

		self.indent_level -= 1
		self.write(out, "}\n")
	
	def decompile_extension(self, out, extension):
		self.write(out, "extend %s {\n" % extension.extendee)
		self.indent_level += 1

		self.decompile_field(out, extension)

		self.indent_level -= 1
		self.write(out, "}\n")

	def decompile_field(self, out, field):
		# type name is either another message or a standard type
		type_name = ""
		if field.type == pb2.FieldDescriptorProto.TYPE_MESSAGE or field.type == pb2.FieldDescriptorProto.TYPE_ENUM:
			type_name = field.type_name
		else:
			type_name = self.type_map[field.type]
		
		# build basic field string with label name
		field_str = "%s %s %s = %d" % (self.label_map[field.label], type_name, field.name, field.number)

		# add default value if set
		if field.HasField("default_value"):
			def_val = field.default_value
			# string default values have to be put in quotes
			if field.type == pb2.FieldDescriptorProto.TYPE_STRING:
				def_val = "\"%s\"" % def_val
			field_str += " [default = %s]" % def_val
		field_str += ";\n"
		self.write(out, field_str)

	def decompile_enum_type(self, out, enum):
		self.write(out, "enum %s {\n" % enum.name)
		self.indent_level += 1

		# deserialize enum values
		for value in enum.value:
			self.write(out, "%s = %d;\n" % (value.name, value.number))

		self.indent_level -= 1
		self.write(out, "}\n")

	def decompile_service(self, out, service):
		self.write(out, "service %s {\n" % service.name)
		self.indent_level += 1

		for method in service.method:
			self.decompile_method(out, method)

		self.indent_level -= 1
		self.write(out, "}\n")
	
	def decompile_method(self, out, method):
		self.write(out, "rpc %s (%s) returns (%s);\n" % (method.name, method.input_type, method.output_type))


	def write(self, out, str):
		out.write("\t" * self.indent_level)
		out.write(str)

if __name__ == '__main__':
	decomp = ProtobinDecompiler()

	if len(sys.argv) < 3:
		print "Usage: %s in_folder out_folder" % sys.argv[0]
		sys.exit()

	in_dir = sys.argv[1]
	out_dir = sys.argv[2]

	in_files = []
	for root, dirs, files in os.walk(in_dir):
		for file in files:
			if file.endswith(".protobin"):
				in_files.append(os.path.join(root, file))

	for file in in_files:
		print "Decompiling %s" % file
		decomp.decompile(file, out_dir)