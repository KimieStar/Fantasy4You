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
