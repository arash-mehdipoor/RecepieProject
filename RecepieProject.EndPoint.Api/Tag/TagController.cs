using MediatR;
using Microsoft.AspNetCore.Mvc;
using RecepieProject.Core.ApplicationServices.Tags.Commands.Add;
using RecepieProject.Core.ApplicationServices.Tags.Commands.Delete;
using RecepieProject.Core.ApplicationServices.Tags.Commands.Edit;
using RecepieProject.Core.ApplicationServices.Tags.Queries.Find;
using RecepieProject.Core.ApplicationServices.Tags.Queries.GetTagList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecepieProject.EndPoint.Api.Tag
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly IMediator mediator;

        public TagController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTagCommand command)
        {
            var resault = await mediator.Send(command);
            return StatusCode(201, resault);
        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTagcommand command)
        {
            var resault = await mediator.Send(command);
            return Ok(resault);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteTagCommand command)
        {
            var resault = await mediator.Send(command);
            return Ok(resault);
        }

        [HttpGet("findTag")]
        public async Task<IActionResult> Find(FindTagQuery command)
        {
            var resault = await mediator.Send(command);
            return Ok(resault);
        }


        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            var resault = await mediator.Send(new GetTagListQuery());
            return Ok(resault);
        }
    }
}
