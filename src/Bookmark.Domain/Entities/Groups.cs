using Bookmark.Domain.Common;
using System;

namespace Bookmark.Domain.Entities
{
    public class Groups : AggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
