using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsDeCinema
{
    public class AvailableMovieSessions
    {
        private int movieId;
        private string movieName;
        private List<int> movieRooms = new List<int>();
        private List<DateTime> sessions = new List<DateTime>();

        public AvailableMovieSessions(int movieId, string movieName)
        {
            this.movieId = movieId;
            this.movieName = movieName;
        }

        public int getMovieId()
        {
            return movieId;
        }

        public void setMovieId(int movieId)
        {
            this.movieId = movieId;
        }

        public string getMovieName()
        {
            return movieName;
        }

        public void setMovieName(string movieName)
        {
            this.movieName = movieName;
        }

        public List<int> getMovieRooms()
        {
            return movieRooms;
        }

        public void insertMovieRoom(int movieRoomId)
        {
            movieRooms.Add(movieRoomId);
        }

        public List<DateTime> getSessions()
        {
            return sessions;
        }

        public void insertMovieSession(DateTime newSession)
        {
            sessions.Add(newSession);
        }
    }
}
