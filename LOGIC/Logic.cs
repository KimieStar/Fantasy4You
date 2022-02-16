using System;
using System.IO;
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
        UserInfo uinfo = new UserInfo(); 

        /// <summary>
        /// Test functions - To be removed
        /// </summary>
        public void ConTry()
        {
            connection.Insert();
            
        }

        public int SelectUserId(int id,string username)
        {
            string username1 = ReadUID(username);
            int iid= connection.SelectUserId(id,username1);
            return iid;

        }

        public string SelectUsername(string username)
        {
            
            string uname = connection.SelectUsername(username);
            return uname;

        }

        public void SaveCredentials(string username,string password)
        {
            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var newDirPath = (roamingDirectory+ @"\F4Y\DONT TOUCH\");
            Directory.CreateDirectory(newDirPath);
            var newFilePath = Path.Combine(newDirPath, "crd.txt");
            var filestream = File.Create(newFilePath);

            var sw = new StreamWriter(filestream);
            sw.WriteLine(username);
            sw.WriteLine(password);
            sw.Close();
        }

        public void SaveUsername(string username)
        {
            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var newDirPath = (roamingDirectory + @"\F4Y\DONT TOUCH\");
            Directory.CreateDirectory(newDirPath);
            var newFilePath = Path.Combine(newDirPath, "uid.txt");
            var filestream = File.Create(newFilePath);

            var sw = new StreamWriter(filestream);
            sw.WriteLine(username);
            sw.Close();
        }

        public string ReadUID(string username)
        {
            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var newDirPath = (roamingDirectory + @"\F4Y\DONT TOUCH\");
            Directory.CreateDirectory(newDirPath);
            var newFilePath = Path.Combine(newDirPath, "uid.txt");
            var sr = new StreamReader(newFilePath);

            try
            {
                string line = sr.ReadLine();
                username = line;
                sr.Close();
            }
            catch (Exception ex)
            {

            }
            return username;
        }

        public string ReadUsername(string username)
        {
            
            Directory.CreateDirectory(uinfo.crdDir);
            var newFilePath = Path.Combine(uinfo.crdDir, "crd.txt");
            var sr = new StreamReader(newFilePath);

            try
            {
                string line = sr.ReadLine();
                username = line;
                sr.Close();
            }
            catch (Exception ex)
            {

            }
            return username;
        }

        public string ReadPassword(string password)
        {
            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var newDirPath = (roamingDirectory + @"\F4Y\DONT TOUCH\");
            Directory.CreateDirectory(newDirPath);
            var newFilePath = Path.Combine(newDirPath, "crd.txt");
            var sr = new StreamReader(newFilePath);

            try
            {
                sr.ReadLine();
                string line = sr.ReadLine();
                password = line;
                sr.Close();
            }
            catch (Exception ex)
            {

            }
            return password;

        }

        public void DeleteSavedCredentials()
        {
           
            var CredentialPath = (uinfo.crdPath);
            var UsernamePath = (uinfo.uidPath);

            File.Delete(CredentialPath);
            File.Delete(UsernamePath);
        }

        public bool CredentialsExist()
        {
            if (File.Exists(uinfo.crdPath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void InsertUsernameAndPassword(string username,string password, string email)
        {
            connection.InsertUsernameAndPassword(username,password, email);
        }
        public bool CheckIfUsernameExists(string username, bool chk)
        {
            bool check = connection.CheckIfUsernameExists(username,chk);
            return check;
        }

        public void CloseConnection()
        {
            connection.CloseConn();
        }

        public void OpenConnection()
        {
            connection.OpenCon();
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
            bool checkName = connection.CheckUserInfo(username, password, check);
            return checkName;
            
        }
    }
}