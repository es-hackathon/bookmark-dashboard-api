using AutoMapper;
using Bookmark.Application.Common.Mapping;
using Bookmark.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
