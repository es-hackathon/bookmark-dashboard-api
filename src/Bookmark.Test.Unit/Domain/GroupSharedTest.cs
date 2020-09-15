using Bookmark.Domain.Entities;
using NUnit.Framework;
using System;

namespace Bookmark.Test.Unit.Domain
{
    public class GroupSharedTest
    {
        private readonly GroupShared _groupShared;
        private readonly Guid GroupId = Guid.NewGuid();

        public GroupSharedTest()
        {
            _groupShared = new GroupShared();
        }

        [Test]
        public void TestSetAndGetGroupsId()
        {
            _groupShared.GroupsId = GroupId;
            Assert.That(_groupShared.GroupsId, Is.EqualTo(GroupId));
        }

    }
}
