
using System;
using Bid.it.Models;

namespace Bid.it.Services.Interfaces
{
    public interface IAuctionDbService
    {
        Task<List<Auction>> GetAuctions();
        Task<List<Auction>> GetFollowedAuctions(string? username);
        Task<Auction> GetAuction(int idAuction);
    }
}

