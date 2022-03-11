using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FANTASY4YOU
{
    public static class User
    {
        private static string username;
        private static string password;
        private static bool isUserNew;
        private static int charSelected;

        public static string Username { get => username; set => username = value; }
        public static string Password { get => password; set => password = value; }
        public static bool IsUserNew { get => isUserNew; set => isUserNew = value; }
        public static int CharSelected { get => charSelected; set => charSelected = value; }
    }
}
