﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bnet.protocol.party;
using bnet.protocol.channel;
using d3server.Network;

namespace d3server.Services {
	public class PartyServiceImpl: PartyService {
		Client client;
		public PartyServiceImpl(Client client) {
			this.client = client;
		}

		public override void CreateChannel(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.channel.CreateChannelRequest request, Action<bnet.protocol.channel.CreateChannelResponse> done) {
			var response = CreateChannelResponse.CreateBuilder();
			response.SetObjectId(request.ObjectId);
			response.SetChannelId(bnet.protocol.EntityId.CreateBuilder().SetLow(11233645142038554527).SetHigh(433661094618860925));
			done(response.Build());
		}

		public override void JoinChannel(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.channel.JoinChannelRequest request, Action<bnet.protocol.channel.JoinChannelResponse> done) {
			throw new NotImplementedException();
		}

		public override void GetChannelInfo(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.channel.GetChannelInfoRequest request, Action<bnet.protocol.channel.GetChannelInfoResponse> done) {
			throw new NotImplementedException();
		}
	}
}