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
        private static int deleteUser = 0;
        private static string recoveryEmail;

        public static string Username { get => username; set => username = value; }
        public static string Password { get => password; set => password = value; }
        public static bool IsUserNew { get => isUserNew; set => isUserNew = value; }
        public static int CharSelected { get => charSelected; set => charSelected = value; }
        public static int DeleteUser { get => deleteUser; set => deleteUser = value; }
        public static string RecoveryEmail { get => recoveryEmail; set => recoveryEmail = value; }
    }
}
