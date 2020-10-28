using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace XMM2
{
    public partial class Form1 : Form
    {
        NpgsqlConnection dbConnection;

        public Form1()
        {
            SetDBConnection("localhost", "username", "password", "moviedb");

            checkPostgresVersion();

            InitializeComponent();
        }
        /// <summary>
        /// This method setsup a db connection to a postgreSQL db. The connection is stored in the global variable 'dbConnection'
        /// </summary>
        /// <param name="serverAddress">The server name or IP address</param>
        /// <param name="username">The username having the right to manipulate the db</param>
        /// <param name="passwd">The corresponding password of the user</param>
        /// <param name="dbName">The db to connect to</param>
        private void SetDBConnection(String serverAddress,string username,string passwd,string dbName)
        {
            // string conectionString = "Host=localhost;Username=postgres;Password=gmq715;Database=test_db";
            string conectionString = "Host=" + serverAddress + "; Username=" + username + "; Password=" + passwd + "; Database=" + dbName + ";";

            dbConnection = new NpgsqlConnection(conectionString);
        }

        private void checkPostgresVersion()
        {
            //Before sending commands to the database, the connection must be opened
            dbConnection.Open();

            //This is a string representing the SQL query to execute in the db
            string sqlQuery = "SELECT version()";


            //This is the actual SQL containing the query to be executed
            NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

            //This variable stores the result of the SQL query sent to the db
            string postgresVersion = dbCommand.ExecuteScalar().ToString();

            //After executing the query(ies) in the db, the connection must be closed
            dbConnection.Close();

            Console.WriteLine("\n----------------------");

            Console.WriteLine("PostgreSQL version: " + postgresVersion);
        }
    }
}
