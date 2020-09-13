using System;

namespace Bookmark.Common
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
