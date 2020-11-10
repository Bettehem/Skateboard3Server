﻿using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Skate3Server.Blaze.Handlers.Clubs.Messages;

namespace Skate3Server.Blaze.Handlers.Clubs
{
    public class Unknown640Handler : IRequestHandler<Unknown640Request, Unknown640Response>
    {
        public async Task<Unknown640Response> Handle(Unknown640Request request, CancellationToken cancellationToken)
        {
            var response = new Unknown640Response();
            return response;
        }
    }
}