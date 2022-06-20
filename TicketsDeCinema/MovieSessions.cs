using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsDeCinema
{
    public partial class MovieSessions : UserControl
    {
        string userId;
        int movieToBuyId;
        string movieToBuyName;
        string movieDate = DateTime.Today.ToString("yyyy-MM-dd");
        string movieTime;
        int movieToBuyRoom;
        bool isSubtitled;
        bool is3d;

        List<Filme> movies = new List<Filme>();

        string connectionString;
        MySqlConnection connection;

        public MovieSessions()
        {
            InitializeComponent();
            connectionString = @"server=localhost;uid=root;pwd=admin;database=cinema;ConnectionTimeout=2";
            connection = new MySqlConnection(connectionString);

            buyTicketScreen.Hide();
        }

        public void setUserId(string userId)
        {
            this.userId = userId;
        }

        public void getMovies()
        {
            MySqlCommand selectMovies;

            try
            {
                connection.Open();

                selectMovies = new MySqlCommand();
                selectMovies.Connection = connection;
                selectMovies.CommandText = "select * from filme";

                MySqlDataReader queryMovies = selectMovies.ExecuteReader();

                if (queryMovies.HasRows)
                {
                    while (queryMovies.Read())
                    {
                        int movieId = queryMovies.GetInt32(0);
                        string movieName = queryMovies.GetString(1);
                        string movieGender = queryMovies.GetString(2);
                        string movieRelease = queryMovies.GetString(3);
                        string movieDuration = queryMovies.GetString(4);
                        string movieRating = queryMovies.GetString(5);

                        Filme movieSession = new Filme(movieId, movieName, movieGender, movieRelease, movieDuration, movieRating);

                        movies.Add(movieSession);
                    }
                }
            }
            finally
            {
                //fecha a conexão com o banco!
                if (connection != null) connection.Close();
            }
        }

        public PictureBox getPbMoviePoster1()
        {
            return pbMoviePoster1;
        }

        private void lbMovie1Session1_Click(object sender, EventArgs e)
        {

            movieToBuyId = 9;
            movieToBuyName = "The Batman";
            movieTime = "12:30";
            movieToBuyRoom = 1;
            isSubtitled = false;
            is3d = false;

            buyTicketScreen.setUserId(userId);
            buyTicketScreen.setMovieNameLabel(movieToBuyName);
            buyTicketScreen.setMovieInfoLabel(movieDate, movieTime, movieToBuyRoom);

            buyTicketScreen.setMovieToBuyId(movieToBuyId);
            buyTicketScreen.setMovieToBuyName(movieToBuyName);
            buyTicketScreen.setMovieDate(movieDate);
            buyTicketScreen.setMovieTime(movieTime);
            buyTicketScreen.setMovieToBuyRoom(movieToBuyRoom);
            buyTicketScreen.setMovieIsSubtitled(isSubtitled);
            buyTicketScreen.setMovieIs3d(is3d);

            buyTicketScreen.Show();
            buyTicketScreen.BringToFront();
        }

        private void lbMovie1Session2_Click(object sender, EventArgs e)
        {
            movieToBuyId = 9;
            movieToBuyName = "The Batman";
            movieTime = "14:30";
            movieToBuyRoom = 1;
            isSubtitled = false;
            is3d = false;

            buyTicketScreen.setUserId(userId);
            buyTicketScreen.setMovieNameLabel(movieToBuyName);
            buyTicketScreen.setMovieInfoLabel(movieDate, movieTime, movieToBuyRoom);

            buyTicketScreen.setMovieToBuyId(movieToBuyId);
            buyTicketScreen.setMovieToBuyName(movieToBuyName);
            buyTicketScreen.setMovieDate(movieDate);
            buyTicketScreen.setMovieTime(movieTime);
            buyTicketScreen.setMovieToBuyRoom(movieToBuyRoom);
            buyTicketScreen.setMovieIsSubtitled(isSubtitled);
            buyTicketScreen.setMovieIs3d(is3d);

            buyTicketScreen.Show();
            buyTicketScreen.BringToFront();
        }

        private void lbMovie1Session4_Click(object sender, EventArgs e)
        {
            movieToBuyId = 9;
            movieToBuyName = "The Batman";
            movieTime = "12:30";
            movieToBuyRoom = 3;
            isSubtitled = false;
            is3d = true;

            buyTicketScreen.setUserId(userId);
            buyTicketScreen.setMovieNameLabel(movieToBuyName);
            buyTicketScreen.setMovieInfoLabel(movieDate, movieTime, movieToBuyRoom);

            buyTicketScreen.setMovieToBuyId(movieToBuyId);
            buyTicketScreen.setMovieToBuyName(movieToBuyName);
            buyTicketScreen.setMovieDate(movieDate);
            buyTicketScreen.setMovieTime(movieTime);
            buyTicketScreen.setMovieToBuyRoom(movieToBuyRoom);
            buyTicketScreen.setMovieIsSubtitled(isSubtitled);
            buyTicketScreen.setMovieIs3d(is3d);

            buyTicketScreen.Show();
            buyTicketScreen.BringToFront();
        }

        private void lbMovie2Session1_Click(object sender, EventArgs e)
        {
            movieToBuyId = 1;
            movieToBuyName = "Sonic 2";
            movieTime = "12:30";
            movieToBuyRoom = 2;
            isSubtitled = false;
            is3d = false;

            buyTicketScreen.setUserId(userId);
            buyTicketScreen.setMovieNameLabel(movieToBuyName);
            buyTicketScreen.setMovieInfoLabel(movieDate, movieTime, movieToBuyRoom);

            buyTicketScreen.setMovieToBuyId(movieToBuyId);
            buyTicketScreen.setMovieToBuyName(movieToBuyName);
            buyTicketScreen.setMovieDate(movieDate);
            buyTicketScreen.setMovieTime(movieTime);
            buyTicketScreen.setMovieToBuyRoom(movieToBuyRoom);
            buyTicketScreen.setMovieIsSubtitled(isSubtitled);
            buyTicketScreen.setMovieIs3d(is3d);

            buyTicketScreen.Show();
            buyTicketScreen.BringToFront();
        }

        private void lbMovie2Session4_Click(object sender, EventArgs e)
        {
            movieToBuyId = 1;
            movieToBuyName = "Sonic 2";
            movieTime = "12:30";
            movieToBuyRoom = 2;
            isSubtitled = true;
            is3d = false;

            buyTicketScreen.setUserId(userId);
            buyTicketScreen.setMovieNameLabel(movieToBuyName);
            buyTicketScreen.setMovieInfoLabel(movieDate, movieTime, movieToBuyRoom);

            buyTicketScreen.setMovieToBuyId(movieToBuyId);
            buyTicketScreen.setMovieToBuyName(movieToBuyName);
            buyTicketScreen.setMovieDate(movieDate);
            buyTicketScreen.setMovieTime(movieTime);
            buyTicketScreen.setMovieToBuyRoom(movieToBuyRoom);
            buyTicketScreen.setMovieIsSubtitled(isSubtitled);
            buyTicketScreen.setMovieIs3d(is3d);

            buyTicketScreen.Show();
            buyTicketScreen.BringToFront();
        }

        private void lbMovie2Session5_Click(object sender, EventArgs e)
        {
            movieToBuyId = 1;
            movieToBuyName = "Sonic 2";
            movieTime = "16:30";
            movieToBuyRoom = 2;
            isSubtitled = true;
            is3d = false;

            buyTicketScreen.setUserId(userId);
            buyTicketScreen.setMovieNameLabel(movieToBuyName);
            buyTicketScreen.setMovieInfoLabel(movieDate, movieTime, movieToBuyRoom);

            buyTicketScreen.setMovieToBuyId(movieToBuyId);
            buyTicketScreen.setMovieToBuyName(movieToBuyName);
            buyTicketScreen.setMovieDate(movieDate);
            buyTicketScreen.setMovieTime(movieTime);
            buyTicketScreen.setMovieToBuyRoom(movieToBuyRoom);
            buyTicketScreen.setMovieIsSubtitled(isSubtitled);
            buyTicketScreen.setMovieIs3d(is3d);

            buyTicketScreen.Show();
            buyTicketScreen.BringToFront();
        }
    }
}
