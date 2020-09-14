using Bookmark.Application.Features.CardFeature.Commands.CreateCard;
using Bookmark.Application.Features.CardFeature.Commands.DeleteCard;
using Bookmark.Application.Features.CardFeature.Commands.UpdateCard;
using Bookmark.Application.Features.CardFeature.Queries.GetCardDetail;
using Bookmark.Application.Features.CardFeature.Queries.GetCardsList;
using Bookmark.WebApi.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Bookmark.WebApi.Cards.v1
{
    [Route("api/v{version:apiVersion}/cards")]
    [ApiVersion("1.0")]
    public class CardsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<CardsListViewModel>> GetAll()
        {
            var vm = await Mediator.Send(new GetCardsListQuery());

            return Ok(vm);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CardDetailViewModel>> Get(Guid id)
        {
            var vm = await Mediator.Send(new GetCardDetailQuery { Id = id });

            return Ok(vm);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<CreateCardViewModel>> Create([FromBody] CreateCardViewModel command)
        {
            var vm = await Mediator.Send(command);

            return Ok(vm);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update([FromBody] UpdateCardCommand command)
        {
            var vm = await Mediator.Send(command);

            return Ok(vm);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid id)
        {
            await Mediator.Send(new DeleteCardCommand { Id = id });

            return NoContent();
        }
    }
}