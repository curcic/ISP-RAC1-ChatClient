using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_ChatClient
{
    internal class UserClass
    {
        private static string UserName;

        public static string userName { get => UserName; set => UserName = value; }
    }
}
