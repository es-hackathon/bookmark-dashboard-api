using Bookmark.Domain.Entities;
using NUnit.Framework;

namespace Bookmark.Test.Unit.Domain
{
    public class CardFavoriteTest
    {
        private readonly CardFavorite _cardFavorite;
        private readonly int Id = 1;

        public CardFavoriteTest()
        {
            _cardFavorite = new CardFavorite();
        }

        [Test]
        public void TestSetAndGetId()
        {
            _cardFavorite.Id = Id;
            Assert.That(_cardFavorite.Id, Is.EqualTo(Id));
        }
    }
}
