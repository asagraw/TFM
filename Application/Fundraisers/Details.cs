using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Fundraisers
{
    public class Details
    {
        public class Query : IRequest<Fundraiser> 
        { 
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Fundraiser>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Fundraiser> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.FundRaisers.FindAsync(request.Id);
            }
        }
    }
}