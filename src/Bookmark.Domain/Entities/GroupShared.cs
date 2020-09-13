using Bookmark.Domain.Common;

namespace Bookmark.Domain.Entities
{
    public class GroupShared : AggregateRoot<int>
    {
        public Cards Cards { get; set; }
        public Groups Groups { get; set; }

    }
}
