using Bookmark.Domain.Common;

namespace Bookmark.Domain.Entities
{
    public class Groups : AggregateRoot<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
