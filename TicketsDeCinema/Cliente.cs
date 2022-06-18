using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsDeCinema
{
    internal class Cliente
    {
        Utils utils = new Utils();

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

        public void setDataNascimento(string dataNascimento) { this.dataNascimento = dataNascimento; }

        public void setEmail(string email) { this.email = email; }

        public void setSenha(string senha) { this.senha = senha;  }

        public Cliente logIn(string loginCpf, string loginPassword)
        {
            Cliente loggedCliente;

            //String de conexão com o banco de dados local
            string connectionString = @"server=localhost;uid=root;pwd=admin;database=cinema;ConnectionTimeout=2";
            //cria uma conexão
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string base64Password = utils.Base64Encode(loginPassword);

            string queryText = $"select * from cliente where cpf = {loginCpf} and senha = {base64Password}";

            MySqlCommand query = new MySqlCommand(queryText, connection);
            MySqlDataReader queryData = query.ExecuteReader();

            //caso o comando select tenha retornado alguma linha
            if (queryData.HasRows)
            {
                queryData.Read();

                string cpf = queryData.GetString(0);
                string nome = queryData.GetString(1);
                DateTime dataNascimento = queryData.GetDateTime(2);
                string email = queryData.GetString(3);
                string senha = queryData.GetString(4);

                loggedCliente = new Cliente(cpf, nome, dataNascimento.ToString(), email, senha);
            } else
            {
                loggedCliente = null;
            }

            queryData.Close();

            return loggedCliente;
        }
    }
}
