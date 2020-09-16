using Bookmark.Domain.Entities;
using Bookmark.Domain.Enum;
using System.Collections.Generic;

namespace Bookmark.Persistance.Seeds
{
    public static class DefaultCards
    {
        public static List<Cards> CardList()
        {
            return new List<Cards>()
            {
                new Cards
                {
                    Id = Constants.Card1,
                    Name = "Github Project Onion Architecture",
                    Description = "Github account",
                    DisplayIcon ="Bookmark",
                    Url= "https://github.com/Amitpnk"
                },
                new Cards
                {
                    Id = Constants.Card2,
                    Name = "Github Project Clean Architecture",
                    Description = "Github account",
                    DisplayIcon ="Bookmark",
                    Url= "https://github.com/Amitpnk"
                },
                new Cards
                {
                    Id = Constants.Card3,
                    Name = "Github account",
                    Description = "Github account",
                    DisplayIcon ="Bookmark",
                    Url= "https://github.com/Amitpnk"
                },
                new Cards
                {
                    Id = Constants.Card4,
                    Name = "Github account",
                    Description = "Github account",
                    DisplayIcon ="Bookmark",
                    Url= "https://github.com/Amitpnk"
                },
                new Cards
                {
                    Id = Constants.Card5,
                    Name = "Github account",
                    Description = "Github account",
                    DisplayIcon ="Bookmark",
                    Url= "https://github.com/Amitpnk"
                }
            };
        }
    }
}
