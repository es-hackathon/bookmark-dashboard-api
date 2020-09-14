using AutoMapper;
using Bookmark.Application.Common.Exceptions;
using Bookmark.Application.Common.Interface;
using Bookmark.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Bookmark.Application.Features.CardFeature.Queries.GetCardDetail
{
    public class GetCardDetailHandler : IRequestHandler<GetCardDetailQuery, CardDetailViewModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetCardDetailHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CardDetailViewModel> Handle(GetCardDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Cards
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Cards), request.Id);
            }

            return _mapper.Map<CardDetailViewModel>(entity);
        }
    }
}
