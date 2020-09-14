using AutoMapper;
using Bookmark.Application.Common.Mapping;
using Bookmark.Domain.Entities;
using System;

namespace Bookmark.Application.Features.GroupFeature.Queries.GetGroupsList
{
    public class GroupsListViewModel : IMapFrom<Groups>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string DisplayIcon { get; set; }
        public DateTime? ExpireDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Groups, GroupsListViewModel>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id));
        }
    }
}

