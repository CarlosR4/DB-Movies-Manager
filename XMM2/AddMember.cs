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
    public partial class AddMember : Form
    {
        // Constants to use when creating DB connections
        private const string DbServerHost = "localhost";
        private const string DbUsername = "username";
        private const string DbUuserPassword = "password";
        private const string DbName = "movie_db";

        NpgsqlConnection dbConnection;

        List<Member> Members = new List<Member>();

        public AddMember()
        {
            InitializeComponent();

            CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
        }

        private NpgsqlConnection CreateDBConnection(string serverAddress, string username, string passwd, string dbName)
        {
            string conectionString = "Host=" + serverAddress + "; Username=" + username + "; Password=" + passwd + "; Database=" + dbName + ";";

            dbConnection = new NpgsqlConnection(conectionString);

            return dbConnection;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            // The following Connection, Command and DataReader objects will be used to access the jt_genre_movie table
            NpgsqlConnection dbConnection1 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand1;
            NpgsqlDataReader dataReader1;

            // The following Connection, Command and DataReader objects will be used to access the jt_genre_movie table
            NpgsqlConnection dbConnection2 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand2;
            NpgsqlDataReader dataReader2;

            dbConnection1.Open();

            string sqlQuery = "SELECT * FROM movieschema.member;";
            Console.WriteLine("SQL Query: " + sqlQuery);

            //This is the actual SQL containing the query to be executed
            dbCommand1 = new NpgsqlCommand(sqlQuery, dbConnection1);

            Member currentMember;
            dataReader1 = dbCommand1.ExecuteReader();


            try
            {
                //Read each line present in the dataReader
                while (dataReader1.Read())
                {

                    //Create a new Movie and setup its info
                    currentMember = new Member();

                    currentMember.id = dataReader1.GetInt32(0);
                    currentMember.name = dataReader1.GetString(1);
                    currentMember.dob = dataReader1.GetDateTime(2);
                    currentMember.memberType = dataReader1.GetInt32(3);
                    currentMember.imagepath = dataReader1.GetString(4);

                    Members.Add(currentMember);

                }
            }
            catch { dbConnection1.Close(); }

            dbConnection1.Close();

            int[] thenumbers = { };

            foreach (Member entry in Members)
            {
                int[] numbers = { entry.id };

                thenumbers = numbers;

                Console.WriteLine(thenumbers);

            }

            int biggestNumber = thenumbers.Max();

            biggestNumber++;

            Console.WriteLine(biggestNumber);

            dbConnection2.Open();

            //This is a string representing the SQL query to execute in the db            
            string sqlQuery1 = "Insert into  movie_db.movieschema.member VALUES (" + "'" + biggestNumber + "', '" + nameTextBox.Text + "', '" + dobTextBox.Text + "', '" + typeTextBox.Text + "', '" + imagePathTextBox.Text + "');";

            Console.WriteLine("SQL Query: " + sqlQuery1);

            //This is the actual SQL containing the query to be executed
            dbCommand2 = new NpgsqlCommand(sqlQuery1, dbConnection2);

            dbCommand2.ExecuteNonQuery();

            //After executing the query(ies) in the db, the connection must be closed
            dbConnection2.Close();

        }
    }
}
