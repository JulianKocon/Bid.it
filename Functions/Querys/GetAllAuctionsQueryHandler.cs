using System;
using Bid.it.Models.Requests;
using Bid.it.Services;
using Bid.it.Services.Interfaces;
using MediatR;

namespace Bid.it.Models.Handlers
{
	public class GetAllAuctionsQueryHandler : IRequestHandler<GetAllAuctionsQuery,List<Auction>>
	{
        private readonly IAuctionDbService _service;
		public GetAllAuctionsQueryHandler(IAuctionDbService service)
		{
            _service = service;
		}

        public Task<List<Auction>> Handle(GetAllAuctionsQuery request, CancellationToken cancellationToken)
        {
            return _service.GetAuctions();
        }
    }
}

