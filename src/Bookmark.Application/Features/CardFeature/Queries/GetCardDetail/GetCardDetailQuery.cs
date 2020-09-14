using MediatR;
using System;

namespace Bookmark.Application.Features.CardFeature.Queries.GetCardDetail
{
    public class GetCardDetailQuery : IRequest<CardDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}
