using Bookmark.Domain.Common;

namespace Bookmark.Domain.Entities
{
    public class CardFavorite : AggregateRoot<int>
    {
        public Cards Cards { get; set; }
        public string User { get; set; }
    }
}
