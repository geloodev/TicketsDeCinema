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
    public partial class MovieSessions : UserControl
    {
        public MovieSessions()
        {
            InitializeComponent();
        }

        public PictureBox getPbMoviePoster1()
        {
            return pbMoviePoster1;
        }
    }
}
