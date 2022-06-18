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
        //String de conexão com o banco de dados local
        string connectionString = @"server=localhost;uid=root;pwd=admin;database=cinema;ConnectionTimeout=2";

        private string userId;
        private string userName;
        private string userBirthDate;
        private string userEmail;
        private string userPassword;

        public Cliente (string cpf, string nome, string dataNascimento, string email, string senha)
        {
            this.userId = cpf;
            this.userName = nome;
            this.userBirthDate = dataNascimento;
            this.userEmail = email;
            this.userPassword = senha;
        }

        ///////////////////////////////
        // GETTERS
        ///////////////////////////////
        
        public string getUserId() { return userId; }

        public string getUserName() { return userName; }

        public string getUserBirthDate() { return userBirthDate; }

        public string getUserEmail() { return userEmail; }

        public string getUserPassword() { return userPassword;  }

        ///////////////////////////////
        // SETTERS  
        ///////////////////////////////

        public void setUserId(string cpf) { this.userId = cpf; }

        public void setUserName(string nome) { this.userName = nome; }

        public void setUserBirthDate(string dataNascimento) { this.userBirthDate = dataNascimento; }

        public void setUserEmail(string email) { this.userEmail = email; }

        public void setUserPassword(string senha) { this.userPassword = senha;  }

        public Cliente SignIn(string loginCpf, string loginPassword)
        {
            Cliente loggedCliente;

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

                string userId = queryData.GetString(0);
                string userName = queryData.GetString(1);
                DateTime userBirthDate = queryData.GetDateTime(2);
                string userEmail = queryData.GetString(3);
                string userPassword = queryData.GetString(4);

                loggedCliente = new Cliente(userId, userName, userBirthDate.ToString(), userEmail, userPassword);
            } else
            {
                loggedCliente = null;
            }

            queryData.Close();

            return loggedCliente;
        }

        public bool signUp(Cliente userToSignUp)
        {
            MySqlConnection connection = null;
            MySqlCommand insertUser = null;
            int affectedRows = 0;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                string insertText = $"insert into cliente values ({userToSignUp.getUserId()}, {userToSignUp.getUserName()}, {userToSignUp.getUserBirthDate()}, {userToSignUp.getUserEmail()}, {utils.Base64Encode(userToSignUp.getUserPassword())})";

                insertUser = new MySqlCommand(insertText, connection);

                affectedRows = insertUser.ExecuteNonQuery();
            } finally
            {
                //fecha a conexão com o banco!
                if (connection != null) connection.Close();
            }

            if (affectedRows != 0) return true;
            else return false;
        }
    }
}
