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
        ImportantInfo importantInfo = new ImportantInfo(); 

        public int SelectUserId(int id,string username)
        {
            string username1 = ReadUsernameFromUsernameFile(username);
            int iid= connection.SelectUserIdFromDB(id,username1);
            return iid;

        }
        

        public void SavePassword(string password)
        {
            string path = importantInfo.Path;
            string fileName = importantInfo.fileName;
            var roaming = importantInfo.roamingpath;
            var newdir = (roaming + path);
            Directory.CreateDirectory(newdir);
            var newfilepath = Path.Combine(newdir, fileName);
            var filename1 = File.Create(newfilepath);
            var sw = new StreamWriter(filename1);
            sw.WriteLine(password);
            sw.Close();
        }

        public void SaveCredentialsToFile(string username,string password)
        {
            string path = importantInfo.Path;
            string fileName = importantInfo.fileName;
            var roamingDirectory = importantInfo.roamingpath;
            var newDirPath = (roamingDirectory+ path);
            
            if (Directory.Exists(newDirPath))
            {
                var newFilePath = Path.Combine(newDirPath, fileName);
                var filestream = File.Create(newFilePath);

                var sw = new StreamWriter(filestream);
                sw.WriteLine(username);
                sw.WriteLine(password);
                sw.Close();
            }
            else 
            {
                Directory.CreateDirectory(newDirPath);
                var newFilePath = Path.Combine(newDirPath, fileName);
                var filestream = File.Create(newFilePath);

                var sw = new StreamWriter(filestream);
                sw.WriteLine(username);
                sw.WriteLine(password);
                sw.Close();
            }
            
        }

        public void SaveUsernameToFile(string username)
        {
            string path = importantInfo.Path;
            string fileName = importantInfo.UsernameFilename;
            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var newDirPath = (roamingDirectory + path);
            Directory.CreateDirectory(newDirPath);
            var newFilePath = Path.Combine(newDirPath, fileName);
            var fileStream = File.Create(newFilePath);

            var sw = new StreamWriter(fileStream);
            sw.WriteLine(username);
            sw.Close();
        }

        public string ReadUsernameFromUsernameFile(string username)
        {
            string path = importantInfo.Path;
            string fileName = importantInfo.fileName;
            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var newDirPath = (roamingDirectory + path);
            Directory.CreateDirectory(newDirPath);
            var newFilePath = Path.Combine(newDirPath, fileName);
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

        public string ReadUsernameFromCredentialsFile(string username)
        {
            string fileName = importantInfo.fileName;
            Directory.CreateDirectory(importantInfo.crdDir);
            var newFilePath = Path.Combine(importantInfo.crdDir, fileName);
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

        public string ReadPasswordFromCredentialsFile(string password)
        {
            string path = importantInfo.Path;
            string fileName = importantInfo.fileName;
            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var newDirPath = (roamingDirectory + path);
            Directory.CreateDirectory(newDirPath);
            var newFilePath = Path.Combine(newDirPath, fileName);
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

        public void DeleteSavedCredentialsFiles()
        {
           
            var credentialPath = (importantInfo.crdPath);
            var usernamePath = (importantInfo.uidPath);

            File.Delete(credentialPath);
            File.Delete(usernamePath);
        }

        public bool CheckIfCredentialsFileExist()
        {
            if (File.Exists(importantInfo.crdPath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void InsertUsernameAndPasswordIntoDB(string username,string password, string email)
        {
            connection.InsertUsernameAndPasswordIntoDB(username,password, email);
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

        public bool CheckUserCredentials(string username, string password, bool check)
        {
            bool checkName = connection.CheckUserCredentials(username, password, check);
            return checkName;
            
        }


    }
}