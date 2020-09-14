using AutoMapper;
using Bookmark.Application.Common.Mapping;
using Bookmark.Domain.Entities;

namespace Bookmark.Application.Features.GroupFeature.Commands.UpdateGroup
{
    public class UpdateGroupViewModel : IMapFrom<Groups>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Groups, UpdateGroupViewModel>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id));
        }

    }
}
