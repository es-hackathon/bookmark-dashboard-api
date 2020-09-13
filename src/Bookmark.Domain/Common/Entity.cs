using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmark.Domain.Common
{
    public abstract class Entity<TKey> : IHasKey<TKey>, ITrackable
    {
        public TKey Id { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
