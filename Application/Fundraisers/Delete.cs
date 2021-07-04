using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Fundraisers
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;

            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var fundraiser = await _context.FundRaisers.FindAsync(request.Id);

                _context.FundRaisers.Remove(fundraiser);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}