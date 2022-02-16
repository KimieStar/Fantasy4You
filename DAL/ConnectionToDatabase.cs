using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ConnectionToDatabase
    {
        private MySqlConnection connection = null;
        private MySqlCommand command = null;
        private MySqlDataReader dreader = null;
        private string server_adress = null;
        private string database_name = null;
        private string username = null;
        private string password = null;
        private string port = null;
        



        public ConnectionToDatabase()
        {
            Initialize();
        }


        /// <summary>
        /// Connecting Credentials for the DB
        /// </summary>
        private void Initialize()
        {
            server_adress = "sql11.freesqldatabase.com";
            database_name = "sql11468912";
            username = "sql11468912";
            password = "Z4Rt4tjQW5";
            string connectionString;
            connectionString = "SERVER=" + server_adress + ";" + "DATABASE=" +
            database_name + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        /// <summary>
        /// Opening a connection to the DB
        /// </summary>
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
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
        /// Closing the connection to the DB
        /// </summary>
        private bool CloseConnection()
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

        public void CloseConn()
        {
            connection.Close();
        }

        public void OpenCon()
        {
            connection.Open();
        }
        /// <summary>
        /// Checking user information to login
        /// </summary>
        
        public int  SelectUserId(int id,string username)
        {
            string query = "select * from userinfo where userinfo.username='" + username +"'";

            

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    id = (int)dataReader["id"];
                }

                dataReader.Close();
                this.CloseConnection();
                return id;
            }
            else
            {
                return id;
            }
        }

        public string SelectUsername(string username)
        {
            string query = "select * from userinfo where userinfo.username='" + username + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    username = dataReader["username"] + "";
                }

                dataReader.Close();
                this.CloseConnection();
                return username;
            }
            else
            {
                return username;
            }
        }

        public bool CheckIfUsernameExists(string username,bool chk)
        {
            string query = "SELECT COUNT(*) FROM userinfo WHERE username ='"+ username + "'";
            
            
                MySqlCommand cmd = new MySqlCommand(query, connection);
                this.OpenConnection();
                //MySqlDataReader dataReader = cmd.ExecuteReader();
                //string dbusername = dataReader["username"] + "";

                cmd.Parameters.AddWithValue(username,username);
                var result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    chk = true;
                    
                }
                else
                {
                    chk=false;
                    
                }
                return chk;
               connection.Close();
        }

        public bool CheckUserInfo(string username,string password, bool read)
        {
            
            command = new MySqlCommand();
            this.connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM userinfo where username='" + username + "' AND password='" + password + "'";
            dreader = command.ExecuteReader();
            if (dreader.Read())
            {
                return  true;
            }
            else
            {
                return false;
            }
            connection.Close();

        }

        public void InsertUsernameAndPassword(string username, string password,string email)
        {
            string query = "INSERT INTO userinfo (username, password, email) VALUES('" +username +"','"+ password+"','" + email +"');";


            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);


                cmd.ExecuteNonQuery();


                this.CloseConnection();
            }
        }


        /// <summary>
        /// Example for Inserting Values into the DB
        /// </summary>
        public void Insert()
        {
            string query = "INSERT INTO people (firstName, lastName) VALUES('Egg', 'Benedict')";

            
            if (this.OpenConnection() == true)
            {
                
                MySqlCommand cmd = new MySqlCommand(query, connection);

                
                cmd.ExecuteNonQuery();

                
                this.CloseConnection();
            }
        }


        public void Update()
        {
        }


        public void Delete()
        {
        }


        /// <summary>
        /// Example for Selecting a single Value(string) from DB
        /// </summary>
        public string SelectFirstName()
        {
            string query = "select * from people where people.id = 1";

            string firstName = null;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    firstName = dataReader["firstName"] + "";
                }

                dataReader.Close();
                this.CloseConnection();
                return firstName;
            }
            else
            {
                return firstName;
            }
        }



       /// <summary>
       /// Example for Selecting a list of Values from DB
       /// </summary>
       public List<string>[] Select()
       {
            string query = "SELECT * FROM people";
           

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["firstName"] + "");
                    list[1].Add(dataReader["lastName"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                
                return list;
            }
            else
            {
                return list;
            }

            
        }



     
    }

}
