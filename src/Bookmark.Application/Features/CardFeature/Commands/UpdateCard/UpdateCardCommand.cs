using MediatR;
using System;

namespace Bookmark.Application.Features.CardFeature.Commands.UpdateCard
{
    public class UpdateCardCommand : IRequest<UpdateCardViewModel>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string DisplayIcon { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
