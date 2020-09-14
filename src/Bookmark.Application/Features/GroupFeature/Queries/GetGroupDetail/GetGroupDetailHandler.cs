using AutoMapper;
using Bookmark.Application.Common.Exceptions;
using Bookmark.Application.Common.Interface;
using Bookmark.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Bookmark.Application.Features.GroupFeature.Queries.GetGroupDetail
{
    public class GetGroupDetailHandler : IRequestHandler<GetGroupDetailQuery, GroupDetailViewModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetGroupDetailHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GroupDetailViewModel> Handle(GetGroupDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Groups
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Groups), request.Id);
            }

            return _mapper.Map<GroupDetailViewModel>(entity);
        }
    }
}
