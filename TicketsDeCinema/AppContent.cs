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
    public partial class AppContent : Form
    {
        string connectionString;
        MySqlConnection connection;

        List<Ticket> boughtTickets = null;
        List<Sessao> availableMovieSessions = new List<Sessao>();
        List<AvailableMovieSessions> availableMovies = new List<AvailableMovieSessions>();

        Cliente loggedUser;

        public AppContent(Cliente loggedUser)
        {
            InitializeComponent();

            connectionString = @"server=localhost;uid=root;pwd=admin;database=cinema;ConnectionTimeout=2";
            connection = new MySqlConnection(connectionString);
            this.loggedUser = loggedUser;

            btnMovieSession.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 199, 116);
            btnMyTickets.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 199, 116);
            btnMyProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 199, 116);
            btnSignOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 199, 116);

            myTicketsScreen.Hide();
            myProfileScreen.Hide();
            movieSessionsScreen.Show();
            movieSessionsScreen.BringToFront();
            movieSessionsScreen.setUserId(loggedUser.getUserId());

            lbActiveUser.Text = "Entrou como " + loggedUser.getUserName().Split(' ')[0];
        }

        public string getUserId()
        {
            return loggedUser.getUserId();
        }

        public void getMovieSessions()
        {
            MySqlCommand selectMovieSessions;

            try
            {
                connection.Open();

                selectMovieSessions = new MySqlCommand();
                selectMovieSessions.Connection = connection;
                selectMovieSessions.CommandText = "select * from sessao";

                MySqlDataReader movieSessions = selectMovieSessions.ExecuteReader();

                if (movieSessions.HasRows) 
                {
                    while (movieSessions.Read()) 
                    {
                        int movieId = movieSessions.GetInt32(1);
                        int movieRoomId = movieSessions.GetInt32(2);
                        DateTime movieTime = movieSessions.GetDateTime(0);

                        Sessao movieSession = new Sessao(movieId, movieRoomId, movieTime);

                        availableMovieSessions.Add(movieSession);
                     }
                }
            }
            finally
            {
                //fecha a conexão com o banco!
                if (connection != null) connection.Close();
            }

            foreach(Sessao session in availableMovieSessions)
            {
                try
                {
                    connection.Open();

                    MySqlCommand getMovieName = new MySqlCommand();
                    getMovieName.Connection = connection;
                    getMovieName.CommandText = "select distinct f.nome from filme f inner join sessao s on s.idFilme = f.idFilme where f.idFilme = @idFilme;";
                    getMovieName.Parameters.AddWithValue("@idFilme", session.getMovieId());

                    MySqlDataReader movieName = getMovieName.ExecuteReader();

                    if (movieName.HasRows)
                    {
                        movieName.Read();

                        AvailableMovieSessions newMovie = new AvailableMovieSessions(session.getMovieId(), movieName.GetString(0));

                        availableMovies.Add(newMovie);
                    }
                }
                finally
                {
                    if (connection != null) connection.Close();
                }
            }

            foreach(AvailableMovieSessions movieSession in availableMovies)
            {
                foreach(Sessao session in availableMovieSessions)
                {
                    if (session.getMovieId() == movieSession.getMovieId())
                    {
                        movieSession.insertMovieSession(session.getMovieTime());
                    }
                }
            }
        }

        public void getBoughtTickets()
        {
            boughtTickets = new List<Ticket>();
            MySqlCommand selectTickets;

            try
            {
                connection.Open();

                selectTickets = new MySqlCommand();
                selectTickets.Connection = connection;
                selectTickets.CommandText = "select * from ticket where cpfCliente = @cpf";
                selectTickets.Parameters.AddWithValue("@cpf", loggedUser.getUserId());

                MySqlDataReader userTickets = selectTickets.ExecuteReader();

                //caso o comando select tenha retornado alguma linha
                if (userTickets.HasRows)
                {
                    while (userTickets.Read())
                    {
                        int ticketId = userTickets.GetInt32("idTicket");
                        string ticketUserId = userTickets.GetString("cpfCliente");
                        int ticketMovieId = userTickets.GetInt32("idFilme");
                        int ticketMovieRoom = userTickets.GetInt32("numeroSala");
                        DateTime ticketMovieTime = userTickets.GetDateTime("dataHora");
                        float ticketPrice = userTickets.GetFloat("preco");
                        string ticketChair = userTickets.GetString("assento");
                        bool ticketIs3d = userTickets.GetBoolean("versao3d");
                        bool ticketIsSubtitled = userTickets.GetBoolean("legendado");
                        bool ticketIsHalfPriced = userTickets.GetBoolean("meiaEntrada");

                        Ticket boughtTicket = new Ticket(
                            ticketId,
                            ticketUserId,
                            ticketMovieId,
                            ticketMovieRoom,
                            ticketPrice,
                            ticketMovieTime,
                            ticketChair,
                            ticketIs3d,
                            ticketIsSubtitled,
                            ticketIsHalfPriced
                        );

                        boughtTickets.Add(boughtTicket);
                    }
                }
                else
                {
                    boughtTickets = null;
                }
            }
            finally
            {
                //fecha a conexão com o banco!
                if (connection != null) connection.Close();
            }

            if (boughtTickets != null)
            {
                foreach (Ticket boughtTicket in boughtTickets)
                {
                    try
                    {
                        connection.Open();

                        MySqlCommand getMovieName = new MySqlCommand();
                        getMovieName.Connection = connection;
                        getMovieName.CommandText = "select distinct f.nome from filme f inner join ticket t on t.idFilme = f.idFilme where f.idFilme = @idFilme;";
                        getMovieName.Parameters.AddWithValue("@idFilme", boughtTicket.getTicketMovieId());

                        MySqlDataReader movieName = getMovieName.ExecuteReader();

                        if (movieName.HasRows)
                        {
                            movieName.Read();

                            myTicketsScreen.getDgTickets().Rows.Add(
                                movieName.GetString(0),
                                boughtTicket.getTicketMovieRoom(),
                                boughtTicket.getTicketChair(),
                                boughtTicket.getTicketMovieTime(),
                                boughtTicket.getTicketPrice()
                            );
                        }
                    }
                    finally
                    {
                        if (connection != null) connection.Close();
                    }
                }
            }
        }

        private void btnMovieSession_MouseEnter(object sender, EventArgs e)
        {
            btnMovieSession.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnMovieSession_MouseLeave(object sender, EventArgs e)
        {
            btnMovieSession.ForeColor = Color.FromArgb(51, 51, 51);
        }

        private void btnMyTickets_MouseEnter(object sender, EventArgs e)
        {
            btnMyTickets.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnMyTickets_MouseLeave(object sender, EventArgs e)
        {
            btnMyTickets.ForeColor = Color.FromArgb(51, 51, 51);
        }

        private void btnMyProfile_MouseEnter(object sender, EventArgs e)
        {
            btnMyProfile.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnMyProfile_MouseLeave(object sender, EventArgs e)
        {
            btnMyProfile.ForeColor = Color.FromArgb(51, 51, 51);
        }

        private void btnSignOut_MouseEnter(object sender, EventArgs e)
        {
            btnSignOut.Image = ((System.Drawing.Image)(Properties.Resources.logoutWhite));
            btnSignOut.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnSignOut_MouseLeave(object sender, EventArgs e)
        {
            btnSignOut.Image = ((System.Drawing.Image)(Properties.Resources.logoutBlack));
            btnSignOut.ForeColor = Color.FromArgb(51, 51, 51);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            SignIn signInForm = new SignIn();
            signInForm.Show();
            signInForm.Activate();
            this.Close();
        }

        private void btnMovieSession_Click(object sender, EventArgs e)
        {
            myTicketsScreen.Hide();
            myProfileScreen.Hide();
            movieSessionsScreen.Show();
            movieSessionsScreen.BringToFront();

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            movieSessionsScreen.Hide();
            myTicketsScreen.Hide();
            myProfileScreen.Show();
            myProfileScreen.BringToFront();
        }

        private void btnMyTickets_Click(object sender, EventArgs e)
        {
            getBoughtTickets();
            movieSessionsScreen.Hide();
            myProfileScreen.Hide();
            myTicketsScreen.Show();
            myTicketsScreen.BringToFront();
        }
    }
}
