using AutoMapper;
using Bookmark.Application.Common.Exceptions;
using Bookmark.Application.Common.Interface;
using Bookmark.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Bookmark.Application.Features.CardFeature.Commands.UpdateCard
{
    public class UpdateCardCommandHandler : IRequestHandler<UpdateCardCommand, UpdateCardViewModel>
    {

        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public UpdateCardCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<UpdateCardViewModel> Handle(UpdateCardCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Cards
                  .SingleOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Cards), request.Id);
            }

            entity.Id = request.Id;
            entity.Name = request.Name;
            entity.Description = request.Description;
            entity.Url = request.Url;
            entity.DisplayIcon = request.DisplayIcon;
            entity.ExpireDate = request.ExpireDate;
            entity.LastModified = DateTime.Now;

            _context.Cards.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<UpdateCardViewModel>(entity);
        }
    }
}
