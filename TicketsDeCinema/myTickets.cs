﻿using MySql.Data.MySqlClient;
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
    public partial class myTickets : UserControl
    {
        public myTickets()
        {
            InitializeComponent();
        }

        public DataGridView getDgTickets()
        {
            return dgTickets;
        }
    }
}
