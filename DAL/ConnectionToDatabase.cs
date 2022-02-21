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
        DBCredentials credAndQuereis = new DBCredentials();
        private MySqlConnection connection = null;
        private MySqlCommand command = null;
        private MySqlDataReader dreader = null;

        public ConnectionToDatabase()
        {
            Initialize();
        }


        /// <summary>
        /// Connecting Credentials for the DB
        /// </summary>
        private void Initialize()
        {
            string serverAdress = credAndQuereis.ServerAdress;
            string databaseName = credAndQuereis.DatabaseName;
            string username = credAndQuereis.Username;
            string password = credAndQuereis.Password;
            
            string connectionString;
            connectionString = "SERVER=" + serverAdress + ";" + "DATABASE=" +
            databaseName + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


      
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

        
        public int  SelectUserIdFromDB(int id,string username)
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

        

        public bool CheckIfUsernameExists(string username,bool chk)
        {
            string query = "SELECT COUNT(*) FROM userinfo WHERE username ='"+ username + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                
                //MySqlDataReader dataReader = cmd.ExecuteReader();
                //string dbusername = dataReader["username"] + "";

                cmd.Parameters.AddWithValue(username, username);
                var result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    chk = true;

                }
                else
                {
                    chk = false;

                }
                this.CloseConnection();
                return chk;
                
            }
            else
            {
                return chk;
            }
            
                
        }

        public bool CheckUserCredentials(string username,string password, bool read)
        {
            if (this.OpenConnection() == true)
            {
                string table = credAndQuereis.Table;
                string query = "SELECT * FROM userinfo where username='" + username + "' AND password='" + password + "'"; ;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                
                dreader = cmd.ExecuteReader();
                if (dreader.Read())
                {
                    this.CloseConnection();
                    return true;
                }
                else
                {
                    this.CloseConnection();
                    return false;
                }
                
            }
            else if (this.OpenConnection() == false)
            {
                this.OpenConnection();
                string table = credAndQuereis.Table;
                string query = "SELECT * FROM userinfo where username='" + username + "' AND password='" + password + "'"; ;
                MySqlCommand cmd = new MySqlCommand(query, connection);

                dreader = cmd.ExecuteReader();
                if (dreader.Read())
                {
                    this.CloseConnection();
                    return true;
                }
                else
                {
                    this.CloseConnection();
                    return false;
                }

            }
            else
            {
                return false;
            }

        }

        public void InsertUsernameAndPasswordIntoDB(string username, string password,string email)
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


    }

}
