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
    public partial class MyProfile : UserControl
    {
        string connectionString;
        MySqlConnection connection;
        string userToLogInName = "";
        string userToLogInId = "";
        string userToLogInBirthDate = "";
        string userToLogInPassword = "";
        string userToLogInEmail = "";
        public MyProfile()
        {
            InitializeComponent();
            connectionString = @"server=localhost;uid=root;pwd=admin;database=cinema;ConnectionTimeout=2";
            connection = new MySqlConnection(connectionString);
        }

        public void updateUserData()
        {
            bool updateStatus;
            try
            {
                Cliente userToUpdate;
                userToLogInId = tbId.Text;
                userToLogInName = tbName.Text;
                userToLogInBirthDate = tbBirthDate.Text;
                userToLogInEmail = tbEmail.Text;
                userToLogInPassword = tbPassword.Text;

                if (userToLogInId.Trim() == "" || userToLogInName.Trim() == "" || userToLogInBirthDate.Trim() == "" || userToLogInEmail.Trim() == "" || userToLogInPassword.Trim() == "")
                {
                    MessageBox.Show("Preencha os campos corretamente para realizar o cadastro");
                    return;
                }

                userToUpdate = new Cliente(userToLogInId, userToLogInName, userToLogInBirthDate, userToLogInEmail, userToLogInPassword);

                updateStatus = userToUpdate.updateUserData(userToUpdate);

                if (!updateStatus)
                {
                    MessageBox.Show("Nao foi possivel atualizar os dados");
                }
                else
                {
                    MessageBox.Show("Dados atualizados com sucesso! Faca login novamente");
                    SignIn signInForm = new SignIn();
                    signInForm.Show();
                    signInForm.Activate();
                    ((AppContent)Parent).Close();
                }
            }
            catch (FormatException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        public void setUserData()
        {
            tbName.Text = userToLogInName;
            tbId.Text = userToLogInId;
            tbBirthDate.Text = userToLogInBirthDate;
            tbPassword.Text = userToLogInPassword;
            tbEmail.Text = userToLogInEmail;
        }

        public void setUserToLogInName(string userToLogInName)
        {
            this.userToLogInName = userToLogInName;
        }

        public void setUserToLogInId(string userToLogInId)
        {
            this.userToLogInId = userToLogInId;
        }

        public void setUserToLogInBirthDate(string userToLogInBirthDate)
        {
            this.userToLogInBirthDate = userToLogInBirthDate;
        }

        public void setUserToLogInEmail(string userToLogInEmail)
        {
            this.userToLogInEmail = userToLogInEmail;
        }

        public void setUserToLogInPassword(string userToLogInPassword)
        {
            this.userToLogInPassword = userToLogInPassword;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            updateUserData();
        }
    }
}
