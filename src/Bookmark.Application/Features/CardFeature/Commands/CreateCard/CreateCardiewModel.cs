using AutoMapper;
using Bookmark.Application.Common.Mapping;
using Bookmark.Domain.Entities;
using System;

namespace Bookmark.Application.Features.CardFeature.Commands.CreateCard
{
    public class CreateCardViewModel : IMapFrom<Cards>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string DisplayIcon { get; set; }
        public DateTime? ExpireDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Cards, CreateCardViewModel>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id));
        }

    }
}
