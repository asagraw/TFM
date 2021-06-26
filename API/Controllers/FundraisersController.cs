using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class FundraisersController : BaseApicontroller
    {
        private readonly DataContext _context;
        public FundraisersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Fundraiser>>> GetFundraisers()
        {
            return await _context.FundRaisers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Fundraiser>> GetFundraiser(Guid id)
        {
            return await _context.FundRaisers.FindAsync(id);
        }
    }
}