using Bookmark.Domain.Entities;
using Bookmark.Domain.Enum;
using System.Collections.Generic;

namespace Bookmark.Persistance.Seeds
{
    public static class DefaultGroups
    {
        public static List<Groups> GroupList()
        {
            return new List<Groups>()
            {
                new Groups
                {
                    Id = Constants.Group1,
                    Name = "Github account",
                    Description = "Github account",
                    IsActive = true
                },
                new Groups
                {
                    Id = Constants.Group2,
                    Name = "c-sharp corner",
                    Description = "c-sharp corner",
                    IsActive = true
                },
                new Groups
                {
                    Id = Constants.Group3,
                    Name = "Code project",
                    Description = "Code project",
                    IsActive = true
                },
                new Groups
                {
                    Id = Constants.Group4,
                    Name = "Microsoft extension",
                    Description = "Microsoft extension",
                    IsActive = true
                }

            };
        }
    }
}
