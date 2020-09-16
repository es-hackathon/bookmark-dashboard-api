using System;

namespace Bookmark.Domain.Entities
{
    public class GroupShared
    {
        public Guid CardsId { get; set; }
        public Guid GroupsId { get; set; }
        public Cards Cards { get; set; }
        public Groups Groups { get; set; }
        public string User { get; set; }

    }
}
