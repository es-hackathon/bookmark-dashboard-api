using MediatR;
using System;

namespace Bookmark.Application.Features.GroupFeature.Queries.GetGroupDetail
{
    public class GetGroupDetailQuery : IRequest<GroupDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}
