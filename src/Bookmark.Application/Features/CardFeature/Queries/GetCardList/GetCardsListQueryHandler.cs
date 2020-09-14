using AutoMapper;
using Bookmark.Application.Common.Interface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Bookmark.Application.Features.CardFeature.Queries.GetCardsList
{
    public class GetCardsListQueryHandler : IRequestHandler<GetCardsListQuery, IEnumerable<CardsListViewModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;

        public GetCardsListQueryHandler(IApplicationDbContext context, IMapper mapper, IMemoryCache memoryCache)
        {
            _context = context;
            _mapper = mapper;
            _memoryCache = memoryCache;
        }

        public async Task<IEnumerable<CardsListViewModel>> Handle(GetCardsListQuery request, CancellationToken cancellationToken)
        {
            var cardsList = await _context.Cards.ToListAsync(cancellationToken);
            var cardsListVm = _mapper.Map<IEnumerable<CardsListViewModel>>(cardsList);
            return cardsListVm;
        }
    }
}
