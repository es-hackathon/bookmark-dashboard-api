namespace Bookmark.Domain.Common
{
    public interface ITrackable
    {
        byte[] RowVersion { get; set; }
    }
}
