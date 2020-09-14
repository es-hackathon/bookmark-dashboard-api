using AutoMapper;
using Bookmark.Application.Common.Interface;
using Bookmark.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Bookmark.Application.Features.GroupFeature.Commands.CreateGroup
{
    public class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommand, CreateGroupViewModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public CreateGroupCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<CreateGroupViewModel> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
        {
            var entity = new Groups
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                IsActive = request.IsActive
            };

            _context.Groups.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<CreateGroupViewModel>(entity);
        }


    }
}
