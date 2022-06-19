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
    public partial class AppContent : Form
    {
        public AppContent(Cliente loggedUser)
        {
            InitializeComponent();
            btnMovieSession.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 199, 116);
            btnMyTickets.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 199, 116);
            btnMyProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 199, 116);
            btnSignOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 199, 116);
        }

        private void btnMovieSession_MouseEnter(object sender, EventArgs e)
        {
            btnMovieSession.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnMovieSession_MouseLeave(object sender, EventArgs e)
        {
            btnMovieSession.ForeColor = Color.FromArgb(51, 51, 51);
        }

        private void btnMyTickets_MouseEnter(object sender, EventArgs e)
        {
            btnMyTickets.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnMyTickets_MouseLeave(object sender, EventArgs e)
        {
            btnMyTickets.ForeColor = Color.FromArgb(51, 51, 51);
        }

        private void btnMyProfile_MouseEnter(object sender, EventArgs e)
        {
            btnMyProfile.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnMyProfile_MouseLeave(object sender, EventArgs e)
        {
            btnMyProfile.ForeColor = Color.FromArgb(51, 51, 51);
        }

        private void btnSignOut_MouseEnter(object sender, EventArgs e)
        {
            btnSignOut.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnSignOut_MouseLeave(object sender, EventArgs e)
        {
            btnSignOut.ForeColor = Color.FromArgb(51, 51, 51);
        }
    }
}
