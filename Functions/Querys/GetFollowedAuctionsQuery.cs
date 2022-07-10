using Bid.it.Models;
using MediatR;

namespace Bid.it.Functions.Querys
{
    public class GetFollowedAuctionsQuery : IRequest<List<Auction>>
    {
        public string? Username;
       
    }
}
