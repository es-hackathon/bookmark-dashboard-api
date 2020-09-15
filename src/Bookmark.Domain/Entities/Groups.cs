using Bookmark.Domain.Common;
using System;
using System.Collections.Generic;

namespace Bookmark.Domain.Entities
{
    public class Groups : AggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public List<GroupShared> GroupShareds { get; set; }
    }
}
