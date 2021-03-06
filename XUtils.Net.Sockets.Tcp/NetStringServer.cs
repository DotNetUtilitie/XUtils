using System;
using System.Net;
using System.Net.Sockets;
namespace XUtils.Net.Sockets.Tcp
{
	public class NetStringServer : NetBaseServer<string>
	{
		public string Security
		{
			get;
			set;
		}
		protected override NetBaseStream<string> CreateStream(NetworkStream ns, EndPoint ep)
		{
			return new NetStringStream(ns, ep)
			{
				Security = this.Security
			};
		}
	}
}
