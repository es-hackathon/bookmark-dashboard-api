using Bookmark.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmark.Domain.Entities
{
    public class GroupShared : AggregateRoot<int>
    {
        public Cards Cards { get; set; }
        public Groups Groups { get; set; }

    }
}
