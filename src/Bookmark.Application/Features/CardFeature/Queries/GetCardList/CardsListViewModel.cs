using AutoMapper;
using Bookmark.Application.Common.Mapping;
using Bookmark.Domain.Entities;
using System;

namespace Bookmark.Application.Features.CardFeature.Queries.GetCardsList
{
    public class CardsListViewModel : IMapFrom<Cards>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string DisplayIcon { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string CreatedBy { get; set; }
        public string Created { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }

        public Guid GroupsId { get; set; }
        public string GroupDescription { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Cards, CardsListViewModel>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Created, opt => opt.MapFrom(s => s.Created.ToString("dd-MMM-yyyy")));
        }
    }
}

