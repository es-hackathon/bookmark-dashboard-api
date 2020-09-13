using Bookmark.Domain.Entities;
using NUnit.Framework;

namespace Bookmark.Test.Unit.Domain
{
    public class GroupSharedTest
    {
        private readonly GroupShared _groupShared;
        private readonly int Id = 1;

        public GroupSharedTest()
        {
            _groupShared = new GroupShared();
        }

        [Test]
        public void TestSetAndGetId()
        {
            _groupShared.Id = Id;
            Assert.That(_groupShared.Id, Is.EqualTo(Id));
        }

    }
}
