using Bookmark.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookmark.Persistance.Configurations
{
    public class CardConfig
    {
        public void Configure(EntityTypeBuilder<Cards> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(100);
            builder.Property(p => p.DisplayIcon).IsRequired().HasMaxLength(30);
        }
    }

}
