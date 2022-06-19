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
    public partial class SignUp : Form
    {
        string userId;
        string userName;
        string userBirthDate;
        string userEmail;
        string userPassword;

        public SignUp()
        {
            InitializeComponent();
        }

        private void lkGoToSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn signInForm = new SignIn();
            signInForm.Show();
            signInForm.Activate();
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string signUpStatus;
            try
            {
                Cliente userToSignUp;
                userId = tbId.Text;
                userName = tbName.Text;
                userBirthDate = tbBirthDate.Text;
                userEmail = tbEmail.Text;
                userPassword = tbPassword.Text;

                if (userId.Trim() == "" || userName.Trim() == "" || userBirthDate.Trim() == "" || userEmail.Trim() == "" || userPassword.Trim() == "")
                {
                    MessageBox.Show("Preencha os campos corretamente para realizar o cadastro");
                    return;
                }

                userToSignUp = new Cliente(userId, userName, userBirthDate, userEmail, userPassword);

                signUpStatus = userToSignUp.signUp();

                if (signUpStatus != "") {
                    if (signUpStatus.Contains("Duplicate entry"))
                    {
                        MessageBox.Show("CPF ja cadastrado em nosso sistema, realize o login");
                    } else
                    {
                        MessageBox.Show(signUpStatus);
                    }
                } else
                {
                    MessageBox.Show("Cadastro realizado com sucesso, realize o login");
                    SignIn signInForm = new SignIn();
                    signInForm.Show();
                    signInForm.Activate();
                    this.Close();
                }
            }
            catch (FormatException er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
