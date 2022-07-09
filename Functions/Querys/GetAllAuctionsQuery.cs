using System;
using MediatR;

namespace Bid.it.Models.Requests
{
	public class GetAllAuctionsQuery : IRequest<List<Auction>>
	{
		public GetAllAuctionsQuery()
		{
		}
	}
}

