using MediatR;
using System;

namespace Bookmark.Application.Features.GroupFeature.Commands.CreateGroup
{
    public class CreateGroupCommand : IRequest<CreateGroupViewModel>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
