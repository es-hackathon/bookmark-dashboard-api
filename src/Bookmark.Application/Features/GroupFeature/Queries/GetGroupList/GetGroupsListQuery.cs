using MediatR;
using System.Collections.Generic;

namespace Bookmark.Application.Features.GroupFeature.Queries.GetGroupsList
{
    public class GetGroupsListQuery : IRequest<IEnumerable<GroupsListViewModel>>
    {

    }
}
