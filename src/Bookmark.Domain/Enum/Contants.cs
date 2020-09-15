using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmark.Domain.Enum
{
    public static class Constants
    {
        public static readonly string SuperAdmin = Guid.NewGuid().ToString();
        public static readonly string Admin = Guid.NewGuid().ToString();
        public static readonly string Moderator = Guid.NewGuid().ToString();
        public static readonly string Basic = Guid.NewGuid().ToString();

        public static readonly string SuperAdminUser = Guid.NewGuid().ToString();
        public static readonly string BasicUser = Guid.NewGuid().ToString();


        public static readonly Guid Card1 = Guid.NewGuid();
        public static readonly Guid Card2 = Guid.NewGuid();
        public static readonly Guid Card3 = Guid.NewGuid();
        public static readonly Guid Card4 = Guid.NewGuid();
        public static readonly Guid Card5 = Guid.NewGuid();
        public static readonly Guid Card6 = Guid.NewGuid();
        public static readonly Guid Card7 = Guid.NewGuid();


        public static readonly Guid Group1 = Guid.NewGuid();
        public static readonly Guid Group2 = Guid.NewGuid();
        public static readonly Guid Group3 = Guid.NewGuid();
        public static readonly Guid Group4 = Guid.NewGuid();


    }
}
