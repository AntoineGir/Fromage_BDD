using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Fromage_BDD;
using Model.business;
using Model.data;
using System.Linq;
using System.Data;

namespace Model.data
{
    class dbal
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public dbal()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "Fromage";
            uid = "root";
            password = "5MichelAnnecy";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE="
                + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

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
                        Console.WriteLine("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
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
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void Insert(string Query)
        {
            string query = Query;

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void Update(string Query)
        {
            string query = Query;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }

        }

        public void Delete(string Query)
        {
            string query = Query;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                
                //pouvoir mettre un cas d'erreur 
                cmd.ExecuteNonQuery();
                this.CloseConnection();


            }
        }

        public void ExecQuery(string Query)
        {
            string query = Query;
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);


            cmd.ExecuteNonQuery();
            CloseConnection();
        }




        public DataSet RQuery(string query)
        {
            DataSet mydataset = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(query, connection);
            
            adapter.Fill(mydataset);

            return mydataset;
        }

        public DataTable SelectAll(string table)
        {
            return this.RQuery("select * from " + table).Tables[0];
        }
        
        public DataTable SelectByField(string table, string fieldTestCondition)
        {
            return this.RQuery("select * from " + table + " where" + fieldTestCondition).Tables[0];
        }


        
        public DataRow SelectByld(string table,int id)
        {
            return this.RQuery("select * from " + table + " where id=" + id).Tables[0].Rows[0];
        }
        


       /* 
        public void test(string query)
        {
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(query, connection);
            adapter.Fill(dataset);

            ExecQuery(query);
        
        }
       */


    }
}
