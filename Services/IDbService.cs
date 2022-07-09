
using System;
using Bid.it.Models;

namespace Bid.it.Services
{
	public interface IDbService
	{
		Task<List<Auction>> GetAuctions();
	}
}

