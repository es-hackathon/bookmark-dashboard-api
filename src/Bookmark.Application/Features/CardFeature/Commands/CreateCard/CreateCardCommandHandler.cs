using AutoMapper;
using Bookmark.Application.Common.Interface;
using Bookmark.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Bookmark.Application.Features.CardFeature.Commands.CreateCard
{
    public class CreateCardCommandHandler : IRequestHandler<CreateCardCommand, CreateCardViewModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public CreateCardCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<CreateCardViewModel> Handle(CreateCardCommand request, CancellationToken cancellationToken)
        {
            var entity = new Cards
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                DisplayIcon = request.DisplayIcon,
                Url = request.Url,
                ExpireDate = request.ExpireDate,
                Created = DateTime.Now
            };

            _context.Cards.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<CreateCardViewModel>(entity);
        }


    }
}
