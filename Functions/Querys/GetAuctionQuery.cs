using System;
using Bid.it.Models;
using MediatR;

namespace Bid.it.Functions.Querys
{
	public class GetAuctionQuery : IRequest<Auction>
    {
		public int IdAuction;
	}
}

