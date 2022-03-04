using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FANTASY4YOU;

namespace FANTASY4YOU
{
    public class ImportantInfo
    {
        ConnectionToDatabase connection = new ConnectionToDatabase();

        
        public string roamingpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string CredentialsPath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\F4Y\DONT TOUCH\crd.txt");
        private string UsernamePath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\F4Y\DONT TOUCH\uid.txt");
        private string charNumPath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\F4Y\DONT TOUCH\charSelectedTemp.txt");
        private string CredentialsDir = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\F4Y\DONT TOUCH\");
        private string path = @"\F4Y\DONT TOUCH\";
        private string filename = "crd.txt";
        private string usernameFilename = "usr.txt";
        private string charSelectedTempFilename = "charSelectedTemp.txt";


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

        public string Path
        {
            get 
            { 
                return path; 
            }
            set
            { 
                path = value; 
            }
        }
      
        public string fileName
        {
            get
            {
                return filename;
            }

            set
            {
                filename = value;
            }
        }

        public string UsernameFilename
        {
            get
            {
                return usernameFilename;
            }
            set
            {
                usernameFilename = value;
            }
        }

        public string CharSelectedTempFilename
        {
            get
            {
                return charSelectedTempFilename;
            }
            set 
            {
                charSelectedTempFilename = value; 
            }
        }

        public string CharNumPath
        {
            get
            {
                return charNumPath;
            }

            set
            {
                charNumPath = value; 
            }
        }
    }
}
