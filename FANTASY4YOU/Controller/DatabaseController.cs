using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections.Specialized;
using FANTASY4YOU;
using System.Data;

namespace FANTASY4YOU
{
    public class DatabaseController
    {
        public MySqlConnection connection;
        

        public DatabaseController()
        {
            Initialize();
        }

        /// <summary>
        /// Initialize connection to databse.
        /// </summary>
        public void Initialize()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new MySqlConnection(connectionString);
            
        }

        /// <summary>
        /// Checking if connection to database is open.
        /// </summary>
        /// <returns></returns>
        private bool OpenConnection()
        {
            bool chk = new bool();
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    chk = true;
                }
                return chk;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        //MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        //MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// Opening connection to database.
        /// </summary>
        public void OpenCon()
        {
            connection.Open();
            
        }

        /// <summary>
        /// Checking if connection to database is closed (Never Used).
        /// </summary>
        /// <returns></returns>
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Taking User Id from database.
        /// </summary>
        /// <returns></returns>
        public int  SelectUserIdFromDB()
        {
            string query = "select * from userinfo where userinfo.username=@username;";
            string username = User.Username;
            int id = 0;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            
            if (OpenConnection() == true)
            {
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    id = (int)dataReader["id"];
                }
                
                dataReader.Close();
                 
                return id;
            }
            else if (this.OpenConnection() == false)
            {
                OpenCon();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    id = (int)dataReader["id"];
                }
            
                dataReader.Close();
            
                return id;
            }
            else
            {
                throw new Exception("No connection to DB");
            }
            
            
        }

        /// <summary>
        /// Checking if the username already exists.
        /// </summary>
        public bool CheckIfUsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM userinfo WHERE username =@username;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            if (this.OpenConnection() == true)
            {
                var result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }
            else
            {
                OpenCon();
                var result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }
            
                
        }

        /// <summary>
        /// Getting the numbers of characters that the user has.
        /// </summary>
        /// <returns></returns>
        public int NumberOfCharactersCreated()
        {
            string query = "SELECT COUNT(*) FROM characters WHERE id=@id;";
            int id = SelectUserIdFromDB();
            int numbersOfCharacters;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id",id);
            if (this.OpenConnection() == true)
            {
                
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if(result > 0)
                {
                    numbersOfCharacters = result;
                }
                else
                {
                    numbersOfCharacters = 0;
                }
                 
                return numbersOfCharacters;
            }
            else
            {
                OpenCon();
                int result = (int)cmd.ExecuteScalar();
                if (result > 0)
                {
                    numbersOfCharacters = result;
                }
                else
                {
                    numbersOfCharacters = 0;
                }
                 
                return numbersOfCharacters;
            }
        }

        /// <summary>
        /// Validating the credentials of the user.
        /// </summary>
        public bool CheckUserCredentials(string username,string password)
        {
            int result;
            bool chk;
            string query = "SELECT * FROM userinfo where username=@username AND password=@password;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username",username);
            cmd.Parameters.AddWithValue("@password", password);
            if (OpenConnection() == true)
            {
                result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (OpenConnection() == false)
            {
                OpenCon();


                result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                throw new Exception("No connection to DB");
            }

        }

        /// <summary>
        /// Inserting Username and Password into the database when the user registers a new account.
        /// </summary>
        public void InsertUsernameAndPasswordIntoDB(string username, string password,string email)
        {
            string query = "INSERT INTO userinfo (username, password, email) VALUES(@username,@password,@email);";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);

            if (this.OpenConnection() == true)
            {
                 cmd.ExecuteNonQuery();
            }
            else if (this.OpenConnection() == false)
            {
                OpenCon();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Inserting parameters for the new character that the user creates.
        /// </summary>
        public void InsertCharacterDetails(string characterName, string classs,int level, string race, string backgroundStory, int xpPoints, string alignment)
        {
            int numberOfCharacter = NumberOfCharactersCreated();
            int characterNumber = 0;
            switch (numberOfCharacter)
            {
                case 0:
                    characterNumber = 1;
                    break;
                case 1:
                    characterNumber = 2;
                    break;
                case 2:
                    characterNumber = 3;
                    break;
                case 3:
                    characterNumber = 4;
                    break;
                case 4:
                    characterNumber = 5;
                    break;
            }

            int id = SelectUserIdFromDB();
            string query = "INSERT INTO characters (id, characterName, class, level, race, backgroundStory, experiencePoints, alignment, characterNumber) VALUES(@id,@characterName,@classs,@level,@race,@backgroundStory,@xpPoints,@alignment,@characterNumber);";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@characterName", characterName);
            cmd.Parameters.AddWithValue("@classs", classs);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.Parameters.AddWithValue("@race", race);
            cmd.Parameters.AddWithValue("@backgroundStory", backgroundStory);
            cmd.Parameters.AddWithValue("@xpPoints", xpPoints);
            cmd.Parameters.AddWithValue("@alignment", alignment);
            cmd.Parameters.AddWithValue("@characterNumber", characterNumber);
            if (this.OpenConnection() == true)
            {
                
                cmd.ExecuteNonQuery();
                 
            }
            else if (this.OpenConnection() == false)
            {
                OpenCon();
                cmd.ExecuteNonQuery();
            }
        
        }

        /// <summary>
        /// Updating Character parameters to the database.
        /// </summary>
        public void UpdateCharacterDetails(int chNum, int strenght, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            string query = "UPDATE characters SET strenght = @strenght, dexterity = @dexterity, constitution = @constitution, intelligence =@intelligence, wisdom = @wisdom, charisma= @charisma WHERE characterNumber=@chNum AND id=@id;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int id = SelectUserIdFromDB();
            cmd.Parameters.AddWithValue("@chNum", chNum);
            cmd.Parameters.AddWithValue("@strenght", strenght);
            cmd.Parameters.AddWithValue("@dexterity", dexterity);
            cmd.Parameters.AddWithValue("@constitution", constitution);
            cmd.Parameters.AddWithValue("@intelligence", intelligence);
            cmd.Parameters.AddWithValue("@wisdom", wisdom);
            cmd.Parameters.AddWithValue("@charisma", charisma);
            cmd.Parameters.AddWithValue("@id", id);
            if (this.OpenConnection() == true)
            {
                cmd.ExecuteNonQuery();
            }
            else if (this.OpenConnection() == false)
            {
                OpenCon();
                cmd.ExecuteNonQuery();
            }

        }

        /// <summary>
        /// Updating Character parameters to the database.
        /// </summary>
        public void UpdateCharacterDetails2(int chNum, string chName, string classs, int level, string race, int xp, string alignment)
        {
            string query = "UPDATE characters SET characterName = @chName, class = @classs, level = @level, race = @race, experiencePoints = @xp,alignment=@alignment WHERE characterNumber=@chNum AND id=@id;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int id = SelectUserIdFromDB();
            cmd.Parameters.AddWithValue("@chName", chName);
            cmd.Parameters.AddWithValue("@classs", classs);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.Parameters.AddWithValue("@race", race);
            cmd.Parameters.AddWithValue("@xp", xp);
            cmd.Parameters.AddWithValue("@alignment", alignment);
            cmd.Parameters.AddWithValue("@chNum", chNum);
            cmd.Parameters.AddWithValue("@id", id);
            if (this.OpenConnection() == true)
            {
                cmd.ExecuteNonQuery();
            }
            else if (this.OpenConnection() == false)
            {
                OpenCon();
                cmd.ExecuteNonQuery();
            }

        }

        /// <summary>
        /// Updating Character parameters to the database.
        /// </summary>
        public void UpdateCharacterDetails3(int chNum,string background)
        {
            string query = "UPDATE characters SET backgroundStory =@background WHERE characterNumber=@chNum AND id=@id;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int id = SelectUserIdFromDB();
            cmd.Parameters.AddWithValue("@background", background);
            cmd.Parameters.AddWithValue("@chNum", chNum);
            cmd.Parameters.AddWithValue("@id", id);
            if (this.OpenConnection() == true)
            {
                cmd.ExecuteNonQuery();
            }
            else if (this.OpenConnection() == false)
            {
                OpenCon();
                cmd.ExecuteNonQuery();
            }

        }

        /// <summary>
        /// Creating a new Character to insert the character parameters from the database into the already created Character Model.
        /// </summary>
        public Character SelectCharInfo(int characterNumber)
        {
            int id = SelectUserIdFromDB();
            string query = "SELECT * FROM characters WHERE id=@id AND characterNumber=@characterNumber;";
            Character character = null;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@characterNumber", characterNumber);
            if (this.OpenConnection() == true)
            {
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                     character = new Character(dataReader["characterName"].ToString(),dataReader["class"].ToString(),
                     Int32.Parse(dataReader["level"].ToString()), dataReader["race"].ToString(),
                     dataReader["backgroundStory"].ToString(), Int32.Parse(dataReader["experiencePoints"].ToString()),
                     dataReader["alignment"].ToString(), Int32.Parse(dataReader["strenght"].ToString()), Int32.Parse(dataReader["dexterity"].ToString()),
                     Int32.Parse(dataReader["constitution"].ToString()), Int32.Parse(dataReader["intelligence"].ToString()),
                     Int32.Parse(dataReader["wisdom"].ToString()), Int32.Parse(dataReader["charisma"].ToString()));
                }
                dataReader.Close();
                 
                return character;
            }
            else
            {
                OpenCon();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    character = new Character(dataReader["characterName"].ToString(), dataReader["class"].ToString(),
                    Int32.Parse(dataReader["level"].ToString()), dataReader["race"].ToString(),
                    dataReader["backgroundStory"].ToString(), Int32.Parse(dataReader["experiencePoints"].ToString()),
                    dataReader["alignment"].ToString(), Int32.Parse(dataReader["strenght"].ToString()), Int32.Parse(dataReader["dexterity"].ToString()),
                    Int32.Parse(dataReader["constitution"].ToString()), Int32.Parse(dataReader["intelligence"].ToString()),
                    Int32.Parse(dataReader["wisdom"].ToString()), Int32.Parse(dataReader["charisma"].ToString()));
                }
                dataReader.Close();

                return character;
            }
        }

        /// <summary>
        /// Cheking if the user already has a character with the inputed username.
        /// </summary>
        public bool CheckCharacterNameExistForUser(string characterName)
        {
            string query = "SELECT COUNT(*) FROM characters WHERE characterName=@characterName AND id=@id;";
            int id = SelectUserIdFromDB();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@characterName", characterName);
            cmd.Parameters.AddWithValue("@id", id);
            bool chk = true;
            if (this.OpenConnection() == true)
            {
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    chk = true;

                }
                else if (result == 0)
                {
                    chk = false;

                }
                 
                return chk;

            }
            else
            {
                OpenCon();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    chk = true;

                }
                else if (result == 0)
                {
                    chk = false;

                }

                return chk;
            }
        }

        /// <summary>
        /// Checking whether if the User has logged in for the first time.
        /// </summary>
        public bool SelectIsUserNew()
        {
            string query = "SELECT * from userinfo where username=@username";
            MySqlCommand cmd = new MySqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@username", User.Username);
            int isUserNew = 0;
            bool chk = false;
            if (OpenConnection() == true)
            {
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    isUserNew= (int)dataReader["isUserNew"];
                }

                dataReader.Close();
                if (isUserNew == 0)
                {
                    chk= true;
                }
                else if (isUserNew == 1)
                {
                    chk = false;
                }
                return chk;
            }
            else if (this.OpenConnection() == false)
            {
                OpenCon();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    isUserNew = (int)dataReader["isUserNew"];
                }

                dataReader.Close();
                if (isUserNew == 0)
                {
                    chk = true;
                }
                else if (isUserNew == 1)
                {
                    chk = false;
                }
                return chk;
            }
            else
            {
                throw new Exception("No connection to DB");
            }
        }

        /// <summary>
        /// Updating the value to the database that the user has already logged in once.
        /// </summary>
        public void UpdateIsUserNew()
        {
            string query = "UPDATE userinfo SET isUserNew =@isUserNew WHERE username=@username;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int isUserNew;
            
            if (SelectIsUserNew() == true && this.OpenConnection() == true)
            {
                isUserNew = 1;
                cmd.Parameters.AddWithValue("@isUserNew", isUserNew);
                cmd.Parameters.AddWithValue("@username", User.Username);
                cmd.ExecuteNonQuery();
            }
            else if (SelectIsUserNew() == true && this.OpenConnection() == false)
            {
                OpenCon();
                isUserNew = 1;
                cmd.Parameters.AddWithValue("@isUserNew", isUserNew);
                cmd.Parameters.AddWithValue("@username", User.Username);
                cmd.ExecuteNonQuery();
            }

            
        }

        /// <summary>
        /// Changing the username of the User.
        /// </summary>
        public void ChangeUsername(string newusername)
        {
            string username = User.Username;
            string id = SelectUserIdFromDB().ToString();
            //string? query = ConfigurationManager.AppSettings.Get("ChangeUsernameQuery");
            string query = "UPDATE userinfo SET username = @username WHERE username = @oldusername and id=@id;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", newusername);
            cmd.Parameters.AddWithValue("@oldusername", username);
            cmd.Parameters.AddWithValue("@id", id);
            if (this.OpenConnection() == true)
            {
                cmd.ExecuteNonQuery();
            }
            else if (this.OpenConnection() == false)
            {
                OpenCon();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Changing the password of the User.
        /// </summary>
        public void ChangePassword(string pass)
        {
            string username = User.Username;
            string id = SelectUserIdFromDB().ToString();
            //string? query = ConfigurationManager.AppSettings.Get("ChangePasswordQuery");
            string query = "UPDATE userinfo SET password = @password WHERE username = @username and id=@id;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@id", id);
            if (this.OpenConnection() == true)
            {
                cmd.ExecuteNonQuery();
            }
            else if (this.OpenConnection() == false)
            {
                OpenCon();
                cmd.ExecuteNonQuery();
            }

        }

        /// <summary>
        /// Deleting a character 
        /// </summary>
        public void DeleteCharacter(int chNum)
        {
            string query = "DELETE from characters where id=@id and characterNumber=@chNum;";
            int id = SelectUserIdFromDB();
            MySqlCommand cmd = new MySqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@chNum", chNum);
            if (this.OpenConnection() == true)
            {
                cmd.ExecuteNonQuery();
            }
            else if (this.OpenConnection() == false)
            {
                OpenCon();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Updating character number after deleting other character.
        /// </summary>
        public void UpdateCharNum(int currentChNum, int chNumToUpdateTo)
        {
            string query = "Update characters set characterNumber=@chNumToUpdateTo where id=@id and characterNumber=@currentChNum";
            int id = SelectUserIdFromDB();
            MySqlCommand cmd = new MySqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@chNumToUpdateTo", chNumToUpdateTo);
            cmd.Parameters.AddWithValue("@currentChNum", currentChNum);
            if (this.OpenConnection() == true)
            {
                cmd.ExecuteNonQuery();
            }
            else if (this.OpenConnection() == false)
            {
                OpenCon();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Deleting User account.
        /// </summary>
        public void DeleteUserAccount()
        {
            string query = "DELETE FROM userinfo where id=@id;Alter table userinfo drop id;alter table userinfo add id int not null auto_increment first, add primary key (id);";
            int id = SelectUserIdFromDB();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            if (this.OpenConnection() == true)
            {
                cmd.ExecuteNonQuery();
            }
            else if (this.OpenConnection() == false)
            {
                OpenCon();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable SelectUserEmail()
        {
            string query = "Select email from userinfo;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            DataTable dt = new DataTable();
            if (this.OpenConnection() == true)
            {
                cmd.ExecuteNonQuery();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            else if (this.OpenConnection() == false)
            {
                OpenCon();
                cmd.ExecuteNonQuery();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            return dt;
        }

        public void RecoverPassword(string pass, string userEmail)
        {
            //string? query = ConfigurationManager.AppSettings.Get("ChangePasswordQuery");
            string query = "UPDATE userinfo SET password = @password WHERE email = @email;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.Parameters.AddWithValue("@email", userEmail);
            if (this.OpenConnection() == true)
            {
                cmd.ExecuteNonQuery();
            }
            else if (this.OpenConnection() == false)
            {
                OpenCon();
                cmd.ExecuteNonQuery();
            }
        }
    }

}
