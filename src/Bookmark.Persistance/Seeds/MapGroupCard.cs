using Bookmark.Domain.Entities;
using Bookmark.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmark.Persistance.Seeds
{
    public static class MappingGroupCard
    {
        public static List<GroupShared> GroupCarduserMappingList()
        {
            return new List<GroupShared>()
            {
                new GroupShared
                {
                     CardsId = Constants.Card1,
                     GroupsId = Constants.Group1,
                     User = Constants.BasicUser

                },
                new GroupShared
                {
                     CardsId = Constants.Card2,
                     GroupsId = Constants.Group2,
                     User = Constants.BasicUser

                }
            };
        }
    }
}
