using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsDeCinema
{
    internal class Cliente
    {
        private string cpf;
        private string nome;
        private string dataNascimento;
        private string email;
        private string senha;

        public Cliente (string cpf, string nome, string dataNascimento, string email, string senha)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.email = email;
            this.senha = senha;
        }

        ///////////////////////////////
        // GETTERS
        ///////////////////////////////
        
        public string getCpf() { return cpf; }
        public string getNome() { return nome; }
        public string getDataNascimento() { return dataNascimento; }
        public string getEmail() { return email; }
        public string getSenha() { return senha;  }

        ///////////////////////////////
        // SETTERS  
        ///////////////////////////////

        public void setCpf(string cpf) { this.cpf = cpf; }
        public void setNome(string nome) { this.nome = nome; }
        public void setDataNascimento(string dataNascimento) { this.dataNascimento = dataNascimento }
        public void setEmail(string email) { this.email = email; }
        public void setSenha(string senha) { this.senha = senha;  }


    }
}
