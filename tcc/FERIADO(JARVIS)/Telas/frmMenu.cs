using System;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

       
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmSuprimentos r = new frmSuprimentos();
            r.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmRH r = new frmRH();
            r.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmFinanceiro r = new frmFinanceiro();
            r.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmEstoqueDirecionador r = new frmEstoqueDirecionador();
            r.Show();
            Hide();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
