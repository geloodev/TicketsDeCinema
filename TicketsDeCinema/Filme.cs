using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsDeCinema
{
    public class Filme
    {
        private int idFilme;
        private string nome;
        private string genero;
        private string lancamento;
        private string duracao;
        private string classificacao;

        public Filme(int idFilme, string nome, string genero, string lancamento, string duracao, string classificacao)
        {
            this.idFilme = idFilme;
            this.nome = nome;
            this.genero = genero;
            this.lancamento = lancamento;
            this.duracao = duracao;
            this.classificacao = classificacao;
        }

        ///////////////////////////////
        // GETTERS
        ///////////////////////////////

        public int getIdFilme() { return idFilme; }

        public string getNome() { return nome; }

        public string getGenero() { return genero; }

        public string getLancamento() { return lancamento; }

        public string getDuracao() { return duracao; }
        
        public string getClassificacao() { return classificacao; }

        ///////////////////////////////
        // SETTERS  
        ///////////////////////////////
        
        public void setCpf(int idFilme) { this.idFilme = idFilme; }

        public void setNome(string nome) { this.nome = nome; }

        public void setGenero(string genero) { this.genero = genero; }

        public void setLancamento(string lancamento) { this.lancamento = lancamento; }

        public void setDuracao(string duracao) { this.duracao = duracao; }

        public void setClassificacao(string classificacao) { this.classificacao = classificacao; }
    }
}
