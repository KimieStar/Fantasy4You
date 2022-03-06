using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FANTASY4YOU;

namespace FANTASY4YOU
{
    internal class DBCredentials
    {

        private string serverAdress = "34.79.57.9";
        private string databaseName = "fantasy4you";
        private string username = "petko";
        private string password = "?#qsHyQN8Da!$xssJj&R@N4hXTxJD7xDM#4x$Kz&";
        private string table = "userinfo";

        public string ServerAdress
        {
            get { return serverAdress; }
            set { serverAdress = value; }
        }

        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Table
        {
            get { return table; }
            set { table = value; }
        }
    }
}
