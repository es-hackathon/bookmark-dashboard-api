﻿using Bookmark.Domain.Common;
using System;

namespace Bookmark.Domain.Entities
{
    public class Cards : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string DisplayIcon { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
