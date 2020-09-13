using System;
using System.ComponentModel.DataAnnotations;

namespace Bookmark.Domain.Common
{
    public class GuidBaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
