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
    public partial class AddGenre : Form
    {
        //Constants to use when creating DB connections
        private const string DbServerHost = "localhost";
        private const string DbUsername = "username";
        private const string DbUuserPassword = "password";
        private const string DbName = "movie_db";

        NpgsqlConnection dbConnection;

        public AddGenre()
        {
            InitializeComponent();
        }

        private NpgsqlConnection CreateDBConnection(string serverAddress, string username, string passwd, string dbName)
        {
            string conectionString = "Host=" + serverAddress + "; Username=" + username + "; Password=" + passwd + "; Database=" + dbName + ";";

            dbConnection = new NpgsqlConnection(conectionString);

            return dbConnection;
        }

        private void AddGenre_Load(object sender, EventArgs e)
        {

        }

        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            //The following Connection, Command and DataReader objects will be used to access the jt_genre_movie table
            NpgsqlConnection dbConnection1 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand1;

            //The following Connection, Command and DataReader objects will be used to access the jt_genre_movie table
            NpgsqlConnection dbConnection2 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand2;

            dbConnection1.Open();
            //This is a string representing the SQL query to execute in the db            
            string sqlQuery = "Insert into  movie_db.movieschema.genre VALUES (" + "'" + codeTextBox.Text + "', '" + nameTextBox.Text + "', '" + descriptionRichTextBox.Text+ "');";

            Console.WriteLine("SQL Query: " + sqlQuery);

            //This is the actual SQL containing the query to be executed
            dbCommand1 = new NpgsqlCommand(sqlQuery, dbConnection1);

            dbCommand1.ExecuteNonQuery();

            /*
            //This is a string representing the SQL query to execute in the db            
            string sqlQuery2 = "DELETE FROM   moviesdb.movieschema.jt_genre_movie WHERE movie_id = '" + "'" + genre + "', '" + biggestNumber + "');";

            Console.WriteLine("SQL Query: " + sqlQuery);

            //This is the actual SQL containing the query to be executed
            dbCommand2 = new NpgsqlCommand(sqlQuery2, dbConnection2);
            */
        }
    }
}
