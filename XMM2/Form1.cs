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
using System.Text.RegularExpressions;
namespace XMM2
{
    public partial class Form1 : Form
    {
        //Constants to use when creating DB connections
        private const string DbServerHost = "localhost";
        private const string DbUsername = "username";
        private const string DbUuserPassword = "password";
        private const string DbName = "movie_db";


        NpgsqlConnection dbConnection;

        List<Movie> Movies = new List<Movie>();
        List<Genre> Genres = new List<Genre>();
        List<Member> Members = new List<Member>();

        public Form1()
        {
            InitializeComponent();


            // CHANGE THIS VALUE TO YOUR DATAGRIP CONFIG
            //             == FORMAT ==
            // ( host_name, username, password, db_name )
            SetDBConnection("localhost", "username", "password", "movie_db");
            // =============================================================


            getMoviesFromDB();

            getGenresFromDB();

            getMembersFromDB();
        }
        /// <summary>
        /// This method setsup a db connection to a postgreSQL db. The connection is stored in the global variable 'dbConnection'
        /// </summary>
        /// <param name="serverAddress">The server name or IP address</param>
        /// <param name="username">The username having the right to manipulate the db</param>
        /// <param name="passwd">The corresponding password of the user</param>
        /// <param name="dbName">The db to connect to</param>
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

            Movies.Clear();

            Movie currentMovie;

            //Connect to the database before sending commands
            dbConnection.Open();

            //This is a string representing the SQL query to execute in the db            
            string sqlQuery = "SELECT * FROM movie_db.movieschema.movie;";
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

                    currentMovie.Genres = LoadMovieGenres(currentMovie.id); 

                    if (dataReader.GetString(5)=="")
                    {
                        currentMovie.imagePath = @"images\noimage.jpg";
                        movieImageList.Images.Add(Image.FromFile(currentMovie.imagePath.ToString()));
                        Movies.Add(currentMovie);
                    }

                    else
                    {
                        currentMovie.imagePath = dataReader.GetString(5);
                        movieImageList.Images.Add(Image.FromFile(currentMovie.imagePath.ToString()));
                        Movies.Add(currentMovie);
                    }

                    Console.WriteLine("image = " + currentMovie.imagePath);


                    Console.WriteLine("Title = " + currentMovie.title);

                    //Movies.Add(currentMovie);

                }
            }
            catch
            {
                //MessageBox.Show("ERROR HERE");
            }            

            //After executing the query(ies) in the db, the connection must be closed
            dbConnection.Close();

            DisplayMovies();
        }

        private List<Genre> LoadMovieGenres(int movieID)
        {
            //The following Connection, Command and DataReader objects will be used to access the jt_genre_movie table
            NpgsqlConnection dbConnection2 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand2;
            NpgsqlDataReader dataReader2;

            //The following Connection, Command and DataReader objects will be used to access the genre table
            NpgsqlConnection dbConnection3 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand3;
            NpgsqlDataReader dataReader3;


            string currentGenreCode;

            Genre currentGenre;

            List<Genre> GenreList = new List<Genre>();

            dbConnection2.Open();

            string sqlQuery = "SELECT genre_code FROM movie_db.movieschema.jt_genre_movie WHERE movie_id = " + movieID + ";";

            Console.WriteLine("sqlQuery = " + sqlQuery);

            dbCommand2 = new NpgsqlCommand(sqlQuery, dbConnection2);

            dataReader2 = dbCommand2.ExecuteReader();

            //While there are genre_codes in the dataReader2
            while (dataReader2.Read())
            {
                currentGenre = new Genre();

                currentGenreCode = dataReader2.GetString(0);

                //Open a connection to access the 'genre' table
                dbConnection3.Open();

                sqlQuery = "SELECT * FROM movie_db.movieschema.genre WHERE code = '" + currentGenreCode + "';";

                Console.WriteLine("sqlQuery = " + sqlQuery);

                dbCommand3 = new NpgsqlCommand(sqlQuery, dbConnection3);

                dataReader3 = dbCommand3.ExecuteReader();

                //Read a line from the 'genre' table
                dataReader3.Read();

                currentGenre.code = dataReader3.GetString(0);
                currentGenre.name = dataReader3.GetString(1);
                currentGenre.description = dataReader3.GetString(2);

                Console.WriteLine("currentGenre = " + currentGenre.code + " - " + currentGenre.name + " - " + currentGenre.description);

                //dbCommand3.Dispose();
                //dataReader3.Close();

                GenreList.Add(currentGenre);

                dbConnection3.Close();
            }

            dbConnection2.Close();

            return GenreList;
        }

        private List<Genre> LoadMovieMembers(int movieID)
        {
            //The following Connection, Command and DataReader objects will be used to access the jt_genre_movie table
            NpgsqlConnection dbConnection2 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand2;
            NpgsqlDataReader dataReader2;

            //The following Connection, Command and DataReader objects will be used to access the genre table
            NpgsqlConnection dbConnection3 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand3;
            NpgsqlDataReader dataReader3;


            string currentGenreCode;

            Genre currentGenre;

            List<Genre> GenreList = new List<Genre>();

            dbConnection2.Open();

            string sqlQuery = "SELECT member_id FROM movie_db.movieschema.jt_movie_meber WHERE movie_id = " + movieID + ";";

            Console.WriteLine("sqlQuery = " + sqlQuery);

            dbCommand2 = new NpgsqlCommand(sqlQuery, dbConnection2);

            dataReader2 = dbCommand2.ExecuteReader();

            //While there are genre_codes in the dataReader2
            while (dataReader2.Read())
            {
                currentGenre = new Genre();

                currentGenreCode = dataReader2.GetString(0);

                //Open a connection to access the 'genre' table
                dbConnection3.Open();

                sqlQuery = "SELECT * FROM movie_db.movieschema.genre WHERE code = '" + currentGenreCode + "';";

                Console.WriteLine("sqlQuery = " + sqlQuery);

                dbCommand3 = new NpgsqlCommand(sqlQuery, dbConnection3);

                dataReader3 = dbCommand3.ExecuteReader();

                //Read a line from the 'genre' table
                dataReader3.Read();

                currentGenre.code = dataReader3.GetString(0);
                currentGenre.name = dataReader3.GetString(1);
                currentGenre.description = dataReader3.GetString(2);

                Console.WriteLine("currentGenre = " + currentGenre.code + " - " + currentGenre.name + " - " + currentGenre.description);

                //dbCommand3.Dispose();
                //dataReader3.Close();

                GenreList.Add(currentGenre);

                dbConnection3.Close();
            }

            dbConnection2.Close();

            return GenreList;
        }
        private void DisplayMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                moviesListView.Items.Add(Movies[i].title);
                moviesListView.Items[i].SubItems.Add(Movies[i].year.ToString());
                moviesListView.Items[i].SubItems.Add(Movies[i].length.ToString());
            }
        }

        private void listviewFormat()
        {
            //listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Title";
            columnHeader1.TextAlign = HorizontalAlignment.Left;
            columnHeader1.Width = 160;
            moviesListView.Columns.Add(columnHeader1);
            moviesListView.View = View.Details;


            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "Year";
            columnHeader2.TextAlign = HorizontalAlignment.Left;
            columnHeader2.Width = 80;
            moviesListView.Columns.Add(columnHeader2);
            //listView1.View = View.Details;

            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader3.Text = "Length";
            columnHeader3.TextAlign = HorizontalAlignment.Left;
            columnHeader3.Width = 80;
            moviesListView.Columns.Add(columnHeader3);

            titleTextBox.Enabled = false;
            yearTextBox.Enabled = false;
            lengthTextBox.Enabled = false;
            genreTextBox.Enabled = false;
            pictureTextBox.Enabled = false;
            ratingTextBox.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listviewFormat();
        }
        private void getGenresFromDB()
        {
            Genre currentGenre;

            //Connect to the database before sending commands
            dbConnection.Open();

            //This is a string representing the SQL query to execute in the db            
            string sqlQuery = "SELECT * FROM movieschema.genre;";
            Console.WriteLine("SQL Query: " + sqlQuery);

            //This is the actual SQL containing the query to be executed
            NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

            //This variable stores the result of the SQL query sent to the db
            NpgsqlDataReader dataReader = dbCommand.ExecuteReader();

            Console.WriteLine("\n=================");

            //Read each line present in the dataReader
            while (dataReader.Read())
            {

                //Create a new Movie and setup its info
                currentGenre = new Genre();

                currentGenre.code = dataReader.GetString(0);
                currentGenre.name = dataReader.GetString(1);

                Console.WriteLine("Code = " + currentGenre.code+"\n"+ "Name = "+ currentGenre.name);

                Genres.Add(currentGenre);

            }

            //After executing the query(ies) in the db, the connection must be closed
            dbConnection.Close();

            DisplayGenres();

        }

        private void DisplayGenres()
        {
            for (int i = 0; i < Genres.Count; i++)
            {
                genreListBox.Items.Add(Genres[i].name);
            }
        }

        private void getMembersFromDB()
        {
            Member currentMember;

            //Connect to the database before sending commands
            dbConnection.Open();

            //This is a string representing the SQL query to execute in the db            
            string sqlQuery = "SELECT * FROM movieschema.member;";
            Console.WriteLine("SQL Query: " + sqlQuery);

            //This is the actual SQL containing the query to be executed
            NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

            //This variable stores the result of the SQL query sent to the db
            NpgsqlDataReader dataReader = dbCommand.ExecuteReader();

            Console.WriteLine("\n=================");

            //Read each line present in the dataReader
            while (dataReader.Read())
            {

                //Create a new Movie and setup its info
                currentMember = new Member();

                currentMember.id = dataReader.GetInt32(0);
                currentMember.name = dataReader.GetString(1);
                currentMember.dob = dataReader.GetDateTime(2);
                currentMember.memberType = dataReader.GetInt32(3);
                currentMember.imagepath = dataReader.GetString(4);

                membersImageList.Images.Add(Image.FromFile(currentMember.imagepath.ToString()));

                Console.WriteLine("Code = " + currentMember.id + "\n" + "Name = " + currentMember.name);

                Members.Add(currentMember);

            }
            //After executing the query(ies) in the db, the connection must be closed
            dbConnection.Close();

            DisplayMembers();
        }


        private void DisplayMembers()
        {
            for (int i = 0; i < Members.Count; i++)
            {
                actorsListBox.Items.Add(Members[i].name);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //  Closes the form
            this.Close();
        }

        private void MoviesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int index = moviesListView.FocusedItem.Index;

                if (moviesListView.SelectedIndices.Count <= 0)
                {
                    return;
                }

                int intselectedindex = moviesListView.SelectedIndices[0];


                if (intselectedindex >= 0)
                {
                    String text = moviesListView.Items[intselectedindex].Text;

                    string replacement = Regex.Replace(text, @"\t|\n|\r", "");

                    int test = Movies.FindIndex(a => a.title == replacement);

                    moviePictureBox.Image = movieImageList.Images[test];
                }

                for (int i = 0; i < moviesListView.Items.Count; i++)
                {
                    //  Display Movie Info in TextBoxes
                    if (moviesListView.Items[i].Selected)
                    {
                        //  TextBoxes to display information requested
                        titleTextBox.Text = moviesListView.Items[i].SubItems[0].Text;
                        yearTextBox.Text = moviesListView.Items[i].SubItems[1].Text;
                        lengthTextBox.Text = moviesListView.Items[i].SubItems[2].Text;
                    }
                }

                // Declare selected item in ListView to be the focused element
                int selected = moviesListView.FocusedItem.Index;

                //  Declare variables for lists below
                Movie getMovie;
                Genre getGenre;

                for (int i = 0; i < moviesListView.Items.Count; i++)
                    if (moviesListView.Items[i].Selected)
                    {
                        //  Selected items for the lists
                        getMovie = (Movie)Movies[selected];
                        getGenre = (Genre)Genres[selected];

                        //  TextBoxes to display information requested
                        ratingTextBox.Text = getMovie.rating.ToString();
                        genreTextBox.Text = getGenre.name;
                        pictureTextBox.Text = getMovie.imagePath;
                    }
                
            }

            catch { } 
        }

        private void actorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Declare selected item in ListBox to be the focused element
                int selected = actorsListBox.SelectedIndex;

                //  Declare variable for list below
                Member getMember;

                if (actorsListBox.SelectedIndex != -1)
                {
                    //  Selected items for the lists
                    getMember = (Member)Members[selected];

                    //  TextBoxes to display information requested
                    label17.Text = getMember.name;
                    label18.Text = getMember.dob.ToString();

                    //  Check assigned integer for each member type and display correct string
                    if (getMember.memberType == 1)
                    {
                        label10.Text = "Actor/Actresse";
                    }
                    else if (getMember.memberType == 2)
                    {
                        label10.Text = "Director";
                    }
                    else if (getMember.memberType == 3)
                    {
                        label10.Text = "Producer";
                    }
                    else if (getMember.memberType == 4)
                    {
                        label10.Text = "Director of photography";
                    }
                }

                //-------------------------------

                if (actorsListBox.SelectedIndices.Count <= 0)
                {
                    return;
                }

                int selectedindex = actorsListBox.SelectedIndices[0];


                if (selectedindex >= 0)
                {
                    String text = actorsListBox.Items[selectedindex].ToString();

                    string replacement = Regex.Replace(text, @"\t|\n|\r", "");

                    int index = Members.FindIndex(a => a.name == replacement);

                    try
                    {
                        memberPictureBox.Image = membersImageList.Images[index];
                    }
                    catch
                    {
                        MessageBox.Show("puss");
                    }
                    


                }
            }
            catch { }
            
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovie = new AddMovieForm();

            addMovie.ShowDialog();

            Movies.Clear();

            movieImageList.Images.Clear();

            moviesListView.Items.Clear();

            getMoviesFromDB();

        }

        private void movieSearchButton_Click(object sender, EventArgs e)
        {
            /*
            if (comboBox1.Text == "Member")
            {
                foreach (Member getMember in actorsListBox.Items)
                {
                    if (getMember.name.StartsWith(textBox8.Text))
                    {
                        actorsListBox.Items.Add(getMember.name);
                    }
                }
            }
            else if (comboBox1.Text == "Movie")
            {

            }
            */
        }

        private void GenreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            moviesListView.Items.Clear();

            string selected = genreListBox.SelectedItem.ToString();

            
            foreach (Movie entry in Movies)
            {
                foreach(Genre genre in entry.Genres)
                {
                    if (selected == "ALL")
                    {
                        int i = 0;

                        moviesListView.Items.Add(entry.title);
                        moviesListView.Items[i].SubItems.Add(entry.year.ToString());
                        moviesListView.Items[i].SubItems.Add(entry.length.ToString());

                        i++;
                    }
                }
            }
            
        }

        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            //The following Connection, Command and DataReader objects will be used to access the jt_genre_movie table
            NpgsqlConnection dbConnection1 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand1;

            //The following Connection, Command and DataReader objects will be used to access the jt_genre_movie table
            NpgsqlConnection dbConnection2 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand2;

            dbConnection1.Open();
            dbConnection2.Open();

            int index = moviesListView.FocusedItem.Index;

            if (moviesListView.SelectedIndices.Count <= 0)
            {
                return;
            }

            int intselectedindex = moviesListView.SelectedIndices[0];


            if (intselectedindex >= 0)
            {
                String text = moviesListView.Items[intselectedindex].Text;

                string replacement = Regex.Replace(text, @"\t|\n|\r", "");

                int test = Movies.FindIndex(a => a.title == replacement);

                //This is a string representing the SQL query to execute in the db            
                string sqlQuery = "DELETE FROM  movie_db.movieschema.movie WHERE id = '" + Movies[test].id + "';";

                Console.WriteLine("SQL Query: " + sqlQuery);

                //This is the actual SQL containing the query to be executed
                dbCommand1 = new NpgsqlCommand(sqlQuery, dbConnection1);

                

                //This is a string representing the SQL query to execute in the db            
                string sqlQuery2 = "DELETE FROM   movie_db.movieschema.jt_genre_movie WHERE movie_id = '" + Movies[test].id + "';";

                Console.WriteLine("SQL Query: " + sqlQuery);

                //This is the actual SQL containing the query to be executed
                dbCommand2 = new NpgsqlCommand(sqlQuery2, dbConnection2);

                dbCommand2.ExecuteNonQuery();

                dbCommand1.ExecuteNonQuery();
            }

            //After executing the query(ies) in the db, the connection must be closed
            dbConnection1.Close();
            dbConnection2.Close();


            moviesListView.Items.Clear();

            getMoviesFromDB();
        }

        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            AddGenre addMovie = new AddGenre();

            addMovie.ShowDialog();

            Genres.Clear();

            genreListBox.Items.Clear();

            getGenresFromDB();

        }

        private void addMemberButton_Click_1(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();

            addMember.ShowDialog();

            Members.Clear();

            actorsListBox.Items.Clear();

            

            getMembersFromDB();
        }
    }
}
