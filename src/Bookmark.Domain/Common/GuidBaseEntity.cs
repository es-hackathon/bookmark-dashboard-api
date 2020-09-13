using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmark.Domain.Common
{
    public class GuidBaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
