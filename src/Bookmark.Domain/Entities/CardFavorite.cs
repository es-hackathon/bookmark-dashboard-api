using Bookmark.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmark.Domain.Entities
{
    public class CardFavorite : AggregateRoot<int>
    {
        public Cards Cards { get; set; }
        public string User { get; set; }
    }
}
