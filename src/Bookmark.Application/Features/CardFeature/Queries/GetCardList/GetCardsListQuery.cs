using MediatR;
using System.Collections.Generic;

namespace Bookmark.Application.Features.CardFeature.Queries.GetCardsList
{
    public class GetCardsListQuery : IRequest<IEnumerable<CardsListViewModel>>
    {

    }
}
