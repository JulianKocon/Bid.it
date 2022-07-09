using System;
using Bid.it.Models;
using Bid.it.Models.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bid.it.Controllers
{
	public class AuctionController : Controller
	{
		private readonly IMediator _mediator;
		public AuctionController(IMediator mediator)
		{
			_mediator = mediator;
		}
        [HttpGet(Name = "GetAllAuctions")]
		public async Task<ActionResult<List<Auction>>> GetAllAuctions()
        {
			var request = new GetAllAuctionsQuery();
			var result = await _mediator.Send(request);

			return result;
        }
	}
}

