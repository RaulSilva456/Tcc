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
            bool ativo = true;

            if(ativo)
            {
                this.Opacity -= 0.01D;
            }
            if(this.Opacity == 0)
            {
                ativo = false;
                timer1.Enabled = false;
                frmMenu r = new frmMenu();
                r.Show();
                Hide();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
