﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_management
{
    public partial class ReservationDetails : Form
    {
        public ReservationDetails()
        {
            InitializeComponent();

            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Disable maximize box
            this.MaximizeBox = false;

            // Disable minimize box
            this.MinimizeBox = false;

            // Set form border style to fixed single
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ReservationDetails_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
