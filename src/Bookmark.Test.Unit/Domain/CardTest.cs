using Bookmark.Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmark.Test.Unit.Domain
{
    public class CardTest
    {
        private readonly Cards _cards;
        private readonly Guid Id;
        private const string Name = "Test";
        private const string Description = "Test Description";
        private const string Url = "https://amitpnk.github.io/";
        private const string DisplayIcon = "bookmark";

        public CardTest()
        {
            _cards = new Cards();
        }

        [Test]
        public void TestSetAndGetId()
        {
            _cards.Id = Id;
            Assert.That(_cards.Id, Is.EqualTo(Id));
        }

        [Test]
        public void TestSetAndGetName()
        {
            _cards.Name = Name;
            Assert.That(_cards.Name, Is.EqualTo(Name));
        }

        [Test]
        public void TestSetAndGetDescription()
        {
            _cards.Description = Description;
            Assert.That(_cards.Description, Is.EqualTo(Description));
        }

        [Test]
        public void TestSetAndGetUrl()
        {
            _cards.Url = Url;
            Assert.That(_cards.Url, Is.EqualTo(Url));
        }

        [Test]
        public void TestSetAndGetDisplayIcon()
        {
            _cards.DisplayIcon = DisplayIcon;
            Assert.That(_cards.DisplayIcon, Is.EqualTo(DisplayIcon));
        }
    }
}
