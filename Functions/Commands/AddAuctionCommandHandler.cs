using System;
using MediatR;

namespace Bid.it.Functions.Commands
{
	public class AddAuctionCommandHandler : IRequestHandler<AddAuctionCommand,Unit>
	{
		public AddAuctionCommandHandler()
		{
		}

        public Task<Unit> Handle(AddAuctionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

