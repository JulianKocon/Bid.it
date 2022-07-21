using System;
using Bid.it.Models;
using Bid.it.Models.Requests;
using Bid.it.Services.Interfaces;
using MediatR;

namespace Bid.it.Functions.Querys
{
	public class GetAuctionQueryHandler : IRequestHandler<GetAuctionQuery, Auction>
    {
        private readonly IAuctionDbService _service;
        public GetAuctionQueryHandler(IAuctionDbService service)
		{
            _service = service;
		}

        public Task<Auction> Handle(GetAuctionQuery request, CancellationToken cancellationToken)
        {
            return _service.GetAuction(request.IdAuction);
            //return Task.FromResult(new List<Auction>()
            //{
            //    new Auction { IdAuction = 1, IdApplicationUser = "notAGuid1", AuctionName = "Nike Air Force 1 white", AuctionStart = DateTime.Parse("20/05/2022"),Duration = 2, Description = "Size US 6", IsAvailable = false},
            //    new Auction { IdAuction = 2, IdApplicationUser = "notAGuid2", AuctionName = "Razer Basilisk v3 mouse", AuctionStart = DateTime.Parse("20/05/2022"),Duration = 3, Description = "Condition 9/10", IsAvailable = true},
            //    new Auction { IdAuction = 3, IdApplicationUser = "notAGuid3", AuctionName = "Test auction 1", AuctionStart = DateTime.Parse("20/05/2022"),Duration = 6, Description = "Test description 1", IsAvailable = true},
            //    new Auction { IdAuction = 4, IdApplicationUser = "notAGuid4", AuctionName = "Test auction 2", AuctionStart = DateTime.Parse("20/05/2022"),Duration = 1, Description = "Test description 2 ", IsAvailable = true},
            //    new Auction { IdAuction = 5, IdApplicationUser = "notAGuid5", AuctionName = "Test auction 3", AuctionStart = DateTime.Parse("20/05/2022"),Duration = 1, Description = "Test description 3", IsAvailable = true}
            //}.SingleOrDefault(a => a.IdAuction == request.IdAuction));
        }
    }
}

