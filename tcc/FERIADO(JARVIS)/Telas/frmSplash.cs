﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FERIADO_JARVIS_.Telas
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            Telas.frmMenu r = new frmMenu();
            r.Show();

            timer1.Stop();
            Hide();
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
