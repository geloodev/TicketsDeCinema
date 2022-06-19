using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsDeCinema
{
    public class Sessao
    {
        private int movieId;
        private int movieRoomId;
        private DateTime movieTime;

        public Sessao(int movieId, int movieRoomId, DateTime movieTime)
        {
            this.movieId = movieId;
            this.movieRoomId = movieRoomId;
            this.movieTime = movieTime;
        }

        public int getMovieId()
        {
            return movieId;
        }

        public DateTime getMovieTime()
        {
            return movieTime;
        }
    }
}
