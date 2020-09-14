using MediatR;
using System;

namespace Bookmark.Application.Features.CardFeature.Commands.DeleteCard
{
    public class DeleteCardCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
