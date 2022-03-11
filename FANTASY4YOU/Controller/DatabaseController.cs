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

namespace FANTASY4YOU
{
    public class DatabaseController
    {
        public MySqlConnection connection;
        private MySqlConnection con;
        private MySqlDataReader dreader;
        

        public DatabaseController()
        {
            Initialize();
        }


        /// <summary>
        /// Connecting Credentials for the DB
        /// </summary>
       //Cannot be tested



        public void Initialize()
        {
            //string? connectionString = ConfigurationManager.AppSettings.Get("connectionString");
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new MySqlConnection(connectionString);
            
        }


        //Cannot be tested
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

        public void OpenCon()
        {
            connection.Open();
            
        }
        //Cannot be tested
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


        

        //Has NunitTest
        public int  SelectUserIdFromDB(string username)
        {
            string? query = ConfigurationManager.AppSettings.Get("SelectUserIdFromDBQuery");
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

        //Has NunitTest
        public bool CheckIfUsernameExists(string username)
        {
            string? query = ConfigurationManager.AppSettings.Get("CheckIfUsernameExistsQuery");
            bool chk = true;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            if (this.OpenConnection() == true)
            {
                
                
                //MySqlDataReader dataReader = cmd.ExecuteReader();
                //string dbusername = dataReader["username"] + "";

                cmd.Parameters.AddWithValue(username, username);
                var result = Convert.ToInt32(cmd.ExecuteScalar());
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

                //MySqlDataReader dataReader = cmd.ExecuteReader();
                //string dbusername = dataReader["username"] + "";

                cmd.Parameters.AddWithValue(username, username);
                var result = Convert.ToInt32(cmd.ExecuteScalar());
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

        //Has NunitTest
        public int NumberOfCharactersCreated(int id)
        {
            string? query = ConfigurationManager.AppSettings.Get("NumberOfCharactersCreatedQuery");
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

        //Has NunitTest
        public bool CheckUserCredentials(string username,string password)
        {
            int result;
            bool chk;
            string? query = ConfigurationManager.AppSettings.Get("CheckUserCredentialsQuery");
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

        //Cannot be tested
        public void InsertUsernameAndPasswordIntoDB(string username, string password,string email)
        {
            string? query = ConfigurationManager.AppSettings.Get("InsertUsernameAndPasswordIntoDBQuery");
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);

            if (this.OpenConnection() == true)
            {
                 cmd.ExecuteNonQuery();
            }
        }

        //Cannot be tested
        public void InsertCharacterDetails(string username, string characterName, string classs,int level, string race, string backgroundStory, int xpPoints, string alignment, int characterNumber)
        {

            
            int id = SelectUserIdFromDB(username);
            string? query = ConfigurationManager.AppSettings.Get("InsertCharacterDetailsQuery");
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
        
        }

        public void UpdateCharacterDetails(int chNum,int id, int strenght, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            string? query = ConfigurationManager.AppSettings.Get("UpdateCharacterDetailsQuery");
            MySqlCommand cmd = new MySqlCommand(query, connection);
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

        }

        public void UpdateCharacterDetails2(int chNum, int id, string chName, string classs, int level, string race, int xp, string alignment)
        {
            string? query = ConfigurationManager.AppSettings.Get("UpdateCharacterDetails2Query");
            MySqlCommand cmd = new MySqlCommand(query, connection);
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

        }

        public void UpdateCharacterDetails3(int chNum, int id,string background)
        {
            string? query = ConfigurationManager.AppSettings.Get("UpdateCharacterDetails3Query");
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@background", background);
            cmd.Parameters.AddWithValue("@chNum", chNum);
            cmd.Parameters.AddWithValue("@id", id);
            if (this.OpenConnection() == true)
            {
                cmd.ExecuteNonQuery();
            }

        }

        public Character SelectCharInfo(string username, int characterNumber)
        {
            int id = SelectUserIdFromDB(username);
            string? query = ConfigurationManager.AppSettings.Get("SelectCharInfoQuery");
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

        //Has NunitTest
        public bool CheckCharacterNameExistForUser(string characterName,int id)
        {
            string? query = ConfigurationManager.AppSettings.Get("CheckCharacterNameExistForUserQuery");
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

        public void Delete()
        {
        }


    }

}
