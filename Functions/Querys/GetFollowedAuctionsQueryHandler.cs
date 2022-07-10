using Bid.it.Models;
using Bid.it.Services.Interfaces;
using MediatR;

namespace Bid.it.Functions.Querys
{
    public class GetFollowedAuctionsQueryHandler : IRequestHandler<GetFollowedAuctionsQuery, List<Auction>>
    {
        private readonly IAuctionDbService _service;

        public GetFollowedAuctionsQueryHandler(IAuctionDbService service)
        {
            _service = service;
        }

        public Task<List<Auction>> Handle(GetFollowedAuctionsQuery request, CancellationToken cancellationToken)
        {
            return _service.GetFollowedAuctions(request.Username);
        }
    }
}
