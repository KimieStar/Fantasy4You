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

        private string serverAdress = "sql11.freesqldatabase.com";
        private string databaseName = "sql11468912";
        private string username = "sql11468912";
        private string password = "Z4Rt4tjQW5";
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
