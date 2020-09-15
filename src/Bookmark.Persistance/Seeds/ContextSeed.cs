using Bookmark.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmark.Persistance.Seeds
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            CreateCards(modelBuilder);

            CreateGroups(modelBuilder);

            MapGroupCard(modelBuilder);
        }

        private static void CreateCards(ModelBuilder modelBuilder)
        {
            List<Cards> cards= DefaultCards.CardList();
            modelBuilder.Entity<Cards>().HasData(cards);
        }

        private static void CreateGroups(ModelBuilder modelBuilder)
        {
            List<Groups> groups = DefaultGroups.GroupList();
            modelBuilder.Entity<Groups>().HasData(groups);
        }

        private static void MapGroupCard(ModelBuilder modelBuilder)
        {
            var  GroupCardUser = MappingGroupCard.GroupCarduserMappingList();
            modelBuilder.Entity<GroupShared>().HasData(GroupCardUser);
        }
    }
}
