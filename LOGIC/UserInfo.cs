using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace LOGIC
{
    public class UserInfo
    {
        ConnectionToDatabase connection = new ConnectionToDatabase();

        private string username = null;
        private string password = null;
        public string roamingpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string CredentialsPath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\F4Y\DONT TOUCH\crd.txt");
        private string UsernamePath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\F4Y\DONT TOUCH\uid.txt");
        private string CredentialsDir = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\F4Y\DONT TOUCH\");

       
        public string crdPath
        {
            get
            {
                return CredentialsPath;
            }
            set
            {
                this.CredentialsPath = value;
            }
        }

        public string uidPath
        {
            get
            {
                return UsernamePath;
            }
            set
            {
                this.UsernamePath = value;
            }
        }

        public string crdDir
        {
            get
            {
                return CredentialsDir;
            }
            set
            {
                CredentialsDir = value;
            }
        }

        public string Username
        {
            get 
            {
                return this.username;
            }
            set 
            {
                this.username = value; 
            }
        }

        public string Password
        {
            get 
            {
                return this.password;
            }
            set 
            {
                this.password = value; 
            }
        }


    }
}
