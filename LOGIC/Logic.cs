using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace LOGIC
    
{
    public class Logic
    {
        ConnectionToDatabase connection = new ConnectionToDatabase();

        /// <summary>
        /// Test functions - To be removed
        /// </summary>
        public void ConTry()
        {
            connection.Insert();
            
        }

        /// <summary>
        /// Test functions - To be removed
        /// </summary>
        public List<string>[] RetrieveList()
        {
            List<string>[] list = connection.Select();
            return list;
        }

        /// <summary>
        /// Test functions - To be removed
        /// </summary>
        public string firstName()
        {
            string firstName = connection.SelectFirstName();
            return firstName;
        }

        public bool CheckName(string username, string password, bool check)
        {
            bool checkName = connection.CheckUserInfo( username, password, check);
            return checkName;
        }
    }
}