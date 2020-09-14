using AutoMapper;
using Bookmark.Application.Common.Exceptions;
using Bookmark.Application.Common.Interface;
using Bookmark.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Bookmark.Application.Features.GroupFeature.Commands.UpdateGroup
{
    public class UpdateGroupCommandHandler : IRequestHandler<UpdateGroupCommand, UpdateGroupViewModel>
    {

        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public UpdateGroupCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<UpdateGroupViewModel> Handle(UpdateGroupCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Groups
                  .SingleOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Groups), request.Id);
            }

            entity.Id = request.Id;
            entity.Name = request.Name;
            entity.Description = request.Description;
            entity.Url = request.Url;
            entity.DisplayIcon = request.DisplayIcon;
            entity.ExpireDate = request.ExpireDate;

            _context.Groups.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<UpdateGroupViewModel>(entity);
        }
    }
}
