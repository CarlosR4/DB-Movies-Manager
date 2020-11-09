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
    public partial class AddMovieForm : Form
    {

        //Constants to use when creating DB connections
        private const string DbServerHost = "localhost";
        private const string DbUsername = "username";
        private const string DbUuserPassword = "password";
        private const string DbName = "movie_db";

        NpgsqlConnection dbConnection;

        List<Movie> Movies = new List<Movie>();

        public AddMovieForm()
        {
            InitializeComponent();

            SetDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);

            getMoviesFromDB();

        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            Movies.Clear();

            //This variable will store the number of affecter rows by the INSERT query
            int queryResult;

            Movie currentMovie;

            //The following Connection, Command and DataReader objects will be used to access the jt_genre_movie table
            NpgsqlConnection dbConnection1 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand1;
            NpgsqlDataReader dataReader1;

            //The following Connection, Command and DataReader objects will be used to access the jt_genre_movie table
            NpgsqlConnection dbConnection2 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand2;

            //The following Connection, Command and DataReader objects will be used to access the genre table
            NpgsqlConnection dbConnection3 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand3;

            dbConnection1.Open();

            //This is a string representing the SQL query to execute in the db            
            string sqlQuery = "SELECT * FROM movieschema.movie;";
            Console.WriteLine("SQL Query: " + sqlQuery);

            //This is the actual SQL containing the query to be executed
            dbCommand1 = new NpgsqlCommand(sqlQuery, dbConnection1);

            //This variable stores the result of the SQL query sent to the db
            dataReader1 = dbCommand1.ExecuteReader();

            Console.WriteLine("\n=================");

            try
            {
                //Read each line present in the dataReader
                while (dataReader1.Read())
                {

                    //Create a new Movie and setup its info
                    currentMovie = new Movie();

                    currentMovie.id = dataReader1.GetInt32(0);
                    currentMovie.title = dataReader1.GetString(1);
                    currentMovie.year = dataReader1.GetInt32(2);
                    currentMovie.length = dataReader1.GetTimeSpan(3);
                    //currentMovie.director = dataReader.GetString(4);
                    currentMovie.rating = dataReader1.GetDouble(4);
                    currentMovie.imagePath = dataReader1.GetString(5);

                    Movies.Add(currentMovie);

                }
            }
            catch { dbConnection1.Close(); }

            dbConnection1.Close();

            
            int[] thenumbers = { };

            

            foreach (Movie entry in Movies)
            {
                int[] numbers = { entry.id };

                thenumbers = numbers;
            }

            int biggestNumber = thenumbers.Max();

            Console.WriteLine(biggestNumber);

            biggestNumber++;

            try
            {
                string title = titleTextBox.Text;
                int year;
                bool ifyear = int.TryParse(yearTextBox.Text, out year);
                if (!ifyear)
                {
                    MessageBox.Show("Invalid Year");
                }
                string genre = genreTextBox.Text;
                string length = lengthTextBox.Text;
                string picture = pictureTextBox.Text;
                int rating;
                bool ifRating = int.TryParse(ratingTextBox.Text, out rating);
                if (!ifRating)
                {
                    MessageBox.Show("Invalid Rating");
                }

                dbConnection2.Open();

                dbConnection3.Open();

                //This is a string representing the SQL query to execute in the db
                string addSqlQuery = "INSERT INTO movie_db.movieschema.movie VALUES(" + "'" + biggestNumber + "', '" + title + "', '" + year + "', '" + length + "','" + rating + "','" + picture + "');";

                string GenreSqlQuery = "INSERT INTO movie_db.movieschema.jt_genre_movie VALUES(" + "'" + genre + "', '" + biggestNumber + "');";



                //Console.WriteLine("Affected rows: " + queryResult);

                //This is the actual SQL containing the query to be executed
                dbCommand3 = new NpgsqlCommand(addSqlQuery, dbConnection3);

                //This variable stores the result of the SQL query sent to the db
                dbCommand3.ExecuteNonQuery();

                //This is the actual SQL containing the query to be executed
                dbCommand2 = new NpgsqlCommand(GenreSqlQuery, dbConnection2);

                //This variable stores the result of the SQL query sent to the db
                dbCommand2.ExecuteNonQuery();

                //After executing the query(ies) in the db, the connection must be closed
                dbConnection2.Close();
                dbConnection3.Close();
            }

            catch
            {
                MessageBox.Show("ERROR PLEASE TRY AGAIN");
            }
        }

        private void SetDBConnection(String serverAddress, string username, string passwd, string dbName)
        {
            // string conectionString = "Host=localhost;Username=postgres;Password=gmq715;Database=test_db";
            string conectionString = "Host=" + serverAddress + "; Username=" + username + "; Password=" + passwd + "; Database=" + dbName + ";";

            dbConnection = new NpgsqlConnection(conectionString);
        }

        private NpgsqlConnection CreateDBConnection(string serverAddress, string username, string passwd, string dbName)
        {
            string conectionString = "Host=" + serverAddress + "; Username=" + username + "; Password=" + passwd + "; Database=" + dbName + ";";

            dbConnection = new NpgsqlConnection(conectionString);

            return dbConnection;
        }

        private void getMoviesFromDB()
        {
            Movie currentMovie;

            //Connect to the database before sending commands
            dbConnection.Open();

            //This is a string representing the SQL query to execute in the db            
            string sqlQuery = "SELECT * FROM movieschema.movie;";
            Console.WriteLine("SQL Query: " + sqlQuery);

            //This is the actual SQL containing the query to be executed
            NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

            //This variable stores the result of the SQL query sent to the db
            NpgsqlDataReader dataReader = dbCommand.ExecuteReader();

            Console.WriteLine("\n=================");

            try
            {
                //Read each line present in the dataReader
                while (dataReader.Read())
                {

                    //Create a new Movie and setup its info
                    currentMovie = new Movie();

                    currentMovie.id = dataReader.GetInt32(0);
                    currentMovie.title = dataReader.GetString(1);
                    currentMovie.year = dataReader.GetInt32(2);
                    currentMovie.length = dataReader.GetTimeSpan(3);
                    //currentMovie.director = dataReader.GetString(4);
                    currentMovie.rating = dataReader.GetDouble(4);
                    currentMovie.imagePath = dataReader.GetString(5);

                    Movies.Add(currentMovie);

                }
            }
            catch { }

            int[] thenumbers = {};

            foreach (Movie entry in Movies)
            {
                int[] numbers = {entry.id};

                thenumbers = numbers;
            }

            int biggestNumber = thenumbers.Max();

            Console.WriteLine(biggestNumber);

            //After executing the query(ies) in the db, the connection must be closed
            dbConnection.Close();
        }
    }
}
