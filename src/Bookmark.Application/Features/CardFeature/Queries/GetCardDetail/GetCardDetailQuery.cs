using MediatR;

namespace Bookmark.Application.Features.CardFeature.Queries.GetCardDetail
{
    public class GetCardDetailQuery : IRequest<CardDetailViewModel>
    {
        public int Id { get; set; }
    }
}
