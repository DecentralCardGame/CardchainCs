// <auto-generated>
//    Code generated by protoc-gen-cosmosCsharp plugin.  DO NOT EDIT!
//    The plugin is part of the DecentralCardgame project and written by lxgr@protonmail.com
// </auto-generated>
#nullable enable

using Cosmcs.Client;
using Cosmcs.Tx;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;

namespace DecentralCardGame.Cardchain.Featureflag {
	
	public class MsgClient {
		public IClient Client { get; }

		public MsgClient (IClient client) {
			Client = client;
		}

	}
}
