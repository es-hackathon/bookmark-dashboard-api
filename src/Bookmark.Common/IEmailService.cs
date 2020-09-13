using Bookmark.Domain.Settings;
using System.Threading.Tasks;

namespace Bookmark.Common
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest request);
    }
}
