using Bookmark.Domain.Entities;
using Bookmark.Persistance;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Bookmark.Test.Unit.Persistence
{
    public class ApplicationDbContextTest
    {
        [Test]
        public void CanInsertCardIntoDatabasee()
        {
            using var context = new ApplicationDbContext();
            var cards = new Cards();
            context.Cards.Add(cards);
            Assert.AreEqual(EntityState.Added, context.Entry(cards).State);
        }

        [Test]
        public void CanInsertGroupIntoDatabasee()
        {
            using var context = new ApplicationDbContext();
            var groups = new Groups();
            context.Groups.Add(groups);
            Assert.AreEqual(EntityState.Added, context.Entry(groups).State);
        }
    }
}
