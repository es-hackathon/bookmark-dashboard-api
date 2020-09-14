using MediatR;
using System;

namespace Bookmark.Application.Features.GroupFeature.Commands.UpdateGroup
{
    public class UpdateGroupCommand : IRequest<UpdateGroupViewModel>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
