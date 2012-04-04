using System;

namespace ServiceStack.Service
{
	public interface IServiceClient : IServiceClientAsync, IOneWayClient
		, IReplyClient
	{
	}

}