using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FANTASY4YOU;
using System.Net;
using System.Net.Mail;
using System.Data;

namespace FANTASY4YOU
    
{
    public class LogicController
    {
        DatabaseController connection = new DatabaseController();
        FileNames_And_Paths importantInfo = new FileNames_And_Paths();
        
        /// <summary>
        /// Saving the user credentials to a local file.
        /// </summary>
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

        /// <summary>
        /// Reading username from local file.
        /// </summary>
        public string ReadUsernameFromCredentialsFile()
        {
            string username = null;
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

        /// <summary>
        /// Reading password from local file.
        /// </summary>
        public string ReadPasswordFromCredentialsFile()
        {
            string password = null;
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

        /// <summary>
        /// Deleting local file with credentials.
        /// </summary>
        public void DeleteSavedCredentialsFile()
        {
           
            var credentialPath = (importantInfo.crdPath);
            var usernamePath = (importantInfo.uidPath);

            File.Delete(credentialPath);
        }

        /// <summary>
        /// Checking if a local file with credentials exist.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Checking wether the user has saved the information for their character before moving on
        /// </summary>
        public bool CheckIfInfoHasBeenSaved1(int charNum,string characterName,string classs, int level,string race,int xp,string alignment)
        {
            Character character = connection.SelectCharInfo(charNum);
            if (characterName == character.CharacterName && classs == character.CharacterClass && level == character.CharacterLevel && race == character.CharacterRace && xp == character.CharacterXp && alignment == character.CharacterAlignment)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checking wether the user has saved the information for their character before moving on
        /// </summary>
        public bool CheckIfInfoHasBeenSaved2(int charNum, int strenght, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Character character = connection.SelectCharInfo(charNum);
            if (strenght == character.CharacterStrenght && dexterity == character.CharacterDexterity && constitution == character.CharacterConstitution && intelligence == character.CharacterIntelligence && wisdom == character.CharacterWisdom && charisma == character.CharacterCharisma)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checking wether the user has saved the information for their character before moving on
        /// </summary>
        public bool CheckIfInfoHasBeenSaved3(int charNum, string background)
        {
            Character character = connection.SelectCharInfo(charNum);
            if (background == character.CharacterBackgroundStory)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SendEmail(string userEmail, int code)
        {
            const string p = "s!3P3Hm6xACbTo#DcRP3c?5Ls5cXc8$Acm@QdN?J";

            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("fantasy4you.recovery@gmail.com");


            message.To.Add(new MailAddress(userEmail));
            message.Subject = "Password Recovery";
            message.Body = "This is your recovery code :" +code;

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("fantasy4you.recovery@gmail.com", p);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
            

        }

       // public bool CheckIfEmailExists(string enterdEmail)
       // {
       //     DataTable dt = connection.SelectUserEmail();
       //     bool chk = false;
       //     foreach (DataRow dr in dt.Rows)
       //     {
       //         foreach (DataColumn dc in dt.Columns)
       //         {
       //             if (enterdEmail == dr[dc].ToString())
       //             {
       //                 chk = true;
       //             }
       //             else
       //             {
       //                 chk = false;
       //             }
       //         }
       //     }
       // }

    }
}