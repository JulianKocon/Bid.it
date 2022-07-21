using System;
using Bid.it.Functions.Querys;
using Bid.it.Models;
using Bid.it.Models.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
		[HttpGet]
		public async Task<ActionResult<List<Auction>>> GetAllAuctions()
		{
			var request = new GetAllAuctionsQuery();
			var result = await _mediator.Send(request);

			return View(result);
		}

		[HttpGet]
		public async Task<ActionResult<List<Auction>>> GetFollowedAuctions()
		{
			var request = new GetFollowedAuctionsQuery
			{
				Username = User.Identity.Name
			};
			var result = await _mediator.Send(request);

			return View(result);
		}
        [HttpGet]
        [Route("{IdAuction}")]
		public async Task<ActionResult<Auction>> GetAuction([FromRoute]int idAuction)
        {
			var request = new GetAuctionQuery
			{
				IdAuction = idAuction
            };
			var result = await _mediator.Send(request);

			return View(result);
        }
	}
}

