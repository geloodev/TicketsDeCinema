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
    public partial class SignIn : Form
    {
        string userEmail;
        string userPassword;
        public SignIn()
        {
            InitializeComponent();
        }

        private void lkGoToSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            signUpForm.Activate();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            userEmail = tbEmail.Text;
            userPassword = tbPassword.Text;

            if (userEmail.Trim() == "" || userPassword.Trim() == "")
            {
                MessageBox.Show("Preencha os campos corretamente para entrar");
                return;
            }

            AppContent app = new AppContent();
            app.Show();
            app.Activate();
            this.Hide();
        }
    }
}
