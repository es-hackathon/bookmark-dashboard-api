using Bookmark.Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmark.Test.Unit.Domain
{
    public class GroupSharedTest
    {
        private readonly GroupShared _groupShared;
        private readonly int Id=1;

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
