using System;
using Bid.it.Data;
using Bid.it.Models;

namespace Bid.it.Services
{
	public class DbService : IDbService
	{
		private readonly ApplicationDbContext _context;
		public DbService(ApplicationDbContext context)
		{
			_context = context;
		}
		public async Task<List<Auction>> GetAuctions()
        {
			return _context.Auctions.ToList<Auction>();
        }
	}
}

