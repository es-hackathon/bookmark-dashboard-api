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

            var cacheKey = "customerList";
            if (!_memoryCache.TryGetValue(cacheKey, out IEnumerable<CardsListViewModel> customerListVm))
            {
                var customerList = await _context.Cards.ToListAsync(cancellationToken);
                customerListVm = _mapper.Map<IEnumerable<CardsListViewModel>>(customerList);
                var cacheExpiryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(5),
                    Priority = CacheItemPriority.High,
                    SlidingExpiration = TimeSpan.FromMinutes(2)
                };
                _memoryCache.Set(cacheKey, customerListVm, cacheExpiryOptions);
            }

            return customerListVm;
        }
    }
}
