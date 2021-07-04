using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Fundraisers
{
    public class List
    {
        public class Query : IRequest<List<Fundraiser>> { }

        public class Handler : IRequestHandler<Query, List<Fundraiser>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Fundraiser>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.FundRaisers.ToListAsync();
            }
        }
    }
}