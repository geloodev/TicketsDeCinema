using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsDeCinema
{
    public class Ticket
    {
        private int idTicket;
        private string cpfCliente;
        private int idFilme;
        private int numeroSala;
        private float preco;
        private DateTime dataHora;
        private string assento;
        private bool versao3d;
        private bool legendado;
        private bool meiaEntrada;

        public Ticket(
            int idTicket,
            string cpfCliente,
            int idFilme,
            int numeroSala,
            float preco,
            DateTime dataHora,
            string assento,
            bool versao3d,
            bool legendado,
            bool meiaEntrada
        )
        {
            this.idTicket = idTicket;
            this.cpfCliente = cpfCliente;
            this.idFilme = idFilme;
            this.numeroSala = numeroSala;
            this.preco = preco;
            this.dataHora = dataHora;
            this.assento = assento;
            this.versao3d = versao3d;
            this.legendado = legendado;
            this.meiaEntrada = meiaEntrada;
        }

        public int getTicketId() { return idTicket; }

        public string getTicketUserId() { return cpfCliente; }

        public int getTicketMovieId() { return idFilme; }

        public int getTicketMovieRoom() { return numeroSala; }

        public float getTicketPrice() { return preco; }

        public DateTime getTicketMovieTime() { return dataHora; }

        public string getTicketChair() { return assento; }

        public bool getTicketIs3d() { return versao3d; }

        public bool getTicketIsSubtitled() { return legendado; }

        public bool getTicketIsHalfPriced() { return meiaEntrada; }
    }
}
