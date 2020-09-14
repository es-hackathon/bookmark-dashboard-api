using AutoMapper;
using Bookmark.Application.Common.Interface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Bookmark.Application.Features.GroupFeature.Queries.GetGroupsList
{
    public class GetGroupsListQueryHandler : IRequestHandler<GetGroupsListQuery, IEnumerable<GroupsListViewModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;

        public GetGroupsListQueryHandler(IApplicationDbContext context, IMapper mapper, IMemoryCache memoryCache)
        {
            _context = context;
            _mapper = mapper;
            _memoryCache = memoryCache;
        }

        public async Task<IEnumerable<GroupsListViewModel>> Handle(GetGroupsListQuery request, CancellationToken cancellationToken)
        {
            var groupsList = await _context.Groups.ToListAsync(cancellationToken);
            var groupsListVm = _mapper.Map<IEnumerable<GroupsListViewModel>>(groupsList);
            return groupsListVm;
        }
    }
}
