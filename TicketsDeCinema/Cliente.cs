using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsDeCinema
{
    public class Cliente
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

            MySqlCommand query = new MySqlCommand();

            query.Connection = connection;

            query.CommandText = "select * from cliente where cpf = @loginCpf and senha = @base64Password";

            query.Parameters.AddWithValue("@loginCpf", loginCpf);
            query.Parameters.AddWithValue("@base64Password", base64Password);


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

        public string signUp()
        {
            MySqlConnection connection = null;
            MySqlCommand insertUser = null;
            string errMessage = "";

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                insertUser = new MySqlCommand();

                insertUser.Connection = connection;

                insertUser.CommandText = "insert into cliente values (@userId, @userName, @userBirthDate, @userEmail, @userPassword);";

                insertUser.Parameters.AddWithValue("@userId", userId);
                insertUser.Parameters.AddWithValue("@userName", userName);
                insertUser.Parameters.AddWithValue("@userBirthDate", userBirthDate);
                insertUser.Parameters.AddWithValue("@userEmail", userEmail);
                insertUser.Parameters.AddWithValue("@userPassword", utils.Base64Encode(userPassword));

                insertUser.ExecuteNonQuery();
            } catch (MySqlException er) {
                return errMessage = er.Message;
            } finally
            {
                //fecha a conexão com o banco!
                if (connection != null) connection.Close();
            }

            return errMessage;
        }

        public bool updateUserData(Cliente userToUpdate)
        {
            int affectedRows = 0;
            MySqlConnection connection = null;
            MySqlCommand updateUser = null;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                string updateText = $"update cliente set nome = {userToUpdate.getUserName()}, dataNascimento = {userToUpdate.getUserBirthDate()}, email = {userToUpdate.getUserEmail()}, senha = {utils.Base64Encode(userToUpdate.getUserPassword())}";

                updateUser = new MySqlCommand(updateText, connection);
                affectedRows = updateUser.ExecuteNonQuery();
            } finally
            {
                if (connection != null) connection.Close();
            }

            if (affectedRows != 0) return true;
            else return false;
        }
    }
}
