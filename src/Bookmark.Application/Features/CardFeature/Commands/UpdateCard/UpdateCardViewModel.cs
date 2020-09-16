using AutoMapper;
using Bookmark.Application.Common.Mapping;
using Bookmark.Domain.Entities;

namespace Bookmark.Application.Features.CardFeature.Commands.UpdateCard
{
    public class UpdateCardViewModel : IMapFrom<Cards>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Cards, UpdateCardViewModel>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id));
        }

    }
}
