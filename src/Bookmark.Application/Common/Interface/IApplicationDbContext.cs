using Bookmark.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Bookmark.Application.Common.Interface
{
    public interface IApplicationDbContext
    {
        DbSet<Cards> Cards { get; set; }
        DbSet<Groups> Groups { get; set; }
        DbSet<GroupShared> GroupShared { get; set; }
        DbSet<CardFavorite> CardFavorite { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
