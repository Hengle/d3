// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace D3.GameBalance {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public static partial class GBHandle {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_D3_GameBalance_Handle__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::D3.GameBalance.Handle, global::D3.GameBalance.Handle.Builder> internal__static_D3_GameBalance_Handle__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static GBHandle() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "Cg5HQkhhbmRsZS5wcm90bxIORDMuR2FtZUJhbGFuY2UiOQoGSGFuZGxlEh0K" + 
          "EWdhbWVfYmFsYW5jZV90eXBlGAEgAigROgItMRIQCgRnYmlkGAIgAigPOgIt" + 
          "MQ==");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_D3_GameBalance_Handle__Descriptor = Descriptor.MessageTypes[0];
        internal__static_D3_GameBalance_Handle__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::D3.GameBalance.Handle, global::D3.GameBalance.Handle.Builder>(internal__static_D3_GameBalance_Handle__Descriptor,
                new string[] { "GameBalanceType", "Gbid", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public sealed partial class Handle : pb::GeneratedMessage<Handle, Handle.Builder> {
    private static readonly Handle defaultInstance = new Builder().BuildPartial();
    private static readonly string[] _handleFieldNames = new string[] { "game_balance_type", "gbid" };
    private static readonly uint[] _handleFieldTags = new uint[] { 8, 21 };
    public static Handle DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Handle DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override Handle ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::D3.GameBalance.GBHandle.internal__static_D3_GameBalance_Handle__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Handle, Handle.Builder> InternalFieldAccessors {
      get { return global::D3.GameBalance.GBHandle.internal__static_D3_GameBalance_Handle__FieldAccessorTable; }
    }
    
    public const int GameBalanceTypeFieldNumber = 1;
    private bool hasGameBalanceType;
    private int gameBalanceType_ = -1;
    public bool HasGameBalanceType {
      get { return hasGameBalanceType; }
    }
    public int GameBalanceType {
      get { return gameBalanceType_; }
    }
    
    public const int GbidFieldNumber = 2;
    private bool hasGbid;
    private int gbid_ = -1;
    public bool HasGbid {
      get { return hasGbid; }
    }
    public int Gbid {
      get { return gbid_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasGameBalanceType) return false;
        if (!hasGbid) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _handleFieldNames;
      if (hasGameBalanceType) {
        output.WriteSInt32(1, field_names[0], GameBalanceType);
      }
      if (hasGbid) {
        output.WriteSFixed32(2, field_names[1], Gbid);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasGameBalanceType) {
          size += pb::CodedOutputStream.ComputeSInt32Size(1, GameBalanceType);
        }
        if (hasGbid) {
          size += pb::CodedOutputStream.ComputeSFixed32Size(2, Gbid);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static Handle ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Handle ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Handle ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Handle ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Handle ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Handle ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Handle ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static Handle ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static Handle ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Handle ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(Handle prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
    public sealed partial class Builder : pb::GeneratedBuilder<Handle, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      Handle result = new Handle();
      
      protected override Handle MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new Handle();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::D3.GameBalance.Handle.Descriptor; }
      }
      
      public override Handle DefaultInstanceForType {
        get { return global::D3.GameBalance.Handle.DefaultInstance; }
      }
      
      public override Handle BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        Handle returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is Handle) {
          return MergeFrom((Handle) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(Handle other) {
        if (other == global::D3.GameBalance.Handle.DefaultInstance) return this;
        if (other.HasGameBalanceType) {
          GameBalanceType = other.GameBalanceType;
        }
        if (other.HasGbid) {
          Gbid = other.Gbid;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_handleFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _handleFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              result.hasGameBalanceType = input.ReadSInt32(ref result.gameBalanceType_);
              break;
            }
            case 21: {
              result.hasGbid = input.ReadSFixed32(ref result.gbid_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasGameBalanceType {
        get { return result.hasGameBalanceType; }
      }
      public int GameBalanceType {
        get { return result.GameBalanceType; }
        set { SetGameBalanceType(value); }
      }
      public Builder SetGameBalanceType(int value) {
        result.hasGameBalanceType = true;
        result.gameBalanceType_ = value;
        return this;
      }
      public Builder ClearGameBalanceType() {
        result.hasGameBalanceType = false;
        result.gameBalanceType_ = -1;
        return this;
      }
      
      public bool HasGbid {
        get { return result.hasGbid; }
      }
      public int Gbid {
        get { return result.Gbid; }
        set { SetGbid(value); }
      }
      public Builder SetGbid(int value) {
        result.hasGbid = true;
        result.gbid_ = value;
        return this;
      }
      public Builder ClearGbid() {
        result.hasGbid = false;
        result.gbid_ = -1;
        return this;
      }
    }
    static Handle() {
      object.ReferenceEquals(global::D3.GameBalance.GBHandle.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
