using Bookmark.Application.Features.GroupFeature.Commands.CreateGroup;
using Bookmark.Application.Features.GroupFeature.Commands.UpdateGroup;
using Bookmark.Application.Features.GroupFeature.Queries.GetGroupDetail;
using Bookmark.Application.Features.GroupFeature.Queries.GetGroupsList;
using Bookmark.WebApi.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Bookmark.WebApi.Groups.v1
{
    [Route("api/v{version:apiVersion}/groups")]
    [ApiVersion("1.0")]
    public class GroupsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<GroupsListViewModel>> GetAll()
        {
            var vm = await Mediator.Send(new GetGroupsListQuery());

            return Ok(vm);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GroupDetailViewModel>> Get(Guid id)
        {
            var vm = await Mediator.Send(new GetGroupDetailQuery { Id = id });

            return Ok(vm);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<CreateGroupViewModel>> Create([FromBody] CreateGroupCommand command)
        {
            var vm = await Mediator.Send(command);

            return Ok(vm);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update([FromBody] UpdateGroupCommand command)
        {
            var vm = await Mediator.Send(command);

            return Ok(vm);
        }


    }
}