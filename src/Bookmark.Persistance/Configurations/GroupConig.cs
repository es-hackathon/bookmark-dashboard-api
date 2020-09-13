using Bookmark.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookmark.Persistance.Configurations
{
    public class GroupConig
    {
        public void Configure(EntityTypeBuilder<Groups> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(100);
        }
    }
}
