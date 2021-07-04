using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using MediatR;
using Application.Fundraisers;
using System.Threading;

namespace API.Controllers
{
    public class FundraisersController : BaseApicontroller
    {
        
        [HttpGet]
        public async Task<ActionResult<List<Fundraiser>>> GetFundraisers(CancellationToken ct)
        {
            return await Mediator.Send(new List.Query(), ct);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Fundraiser>> GetFundraiser(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id= id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateFundraiser(Fundraiser Fundraiser)
        {
            return Ok(await Mediator.Send(new Create.Command{Fundraiser = Fundraiser}));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditFundraiser(Guid id, Fundraiser Fundraiser)
        {
            Fundraiser.Id = id;
            return Ok(await Mediator.Send(new Edit.Command{Fundraiser=Fundraiser}));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFundraiser(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command{Id=id}));
        }
    }
}