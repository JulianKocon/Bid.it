using System;
using Bid.it.Models.Requests;
using Bid.it.Services;
using MediatR;

namespace Bid.it.Models.Handlers
{
	public class GetAllAuctionsQueryHandler : IRequestHandler<GetAllAuctionsQuery,List<Auction>>
	{
        private readonly IDbService _service;
		public GetAllAuctionsQueryHandler(IDbService service)
		{
            _service = service;
		}

        public Task<List<Auction>> Handle(GetAllAuctionsQuery request, CancellationToken cancellationToken)
        {
            return _service.GetAuctions();
        }
    }
}

