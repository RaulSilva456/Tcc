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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
       
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            frmRH r = new frmRH();
            r.Show();
            Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            frmFinanceiro r = new frmFinanceiro();
            r.Show();
            Hide();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            frmSuprimentos r = new frmSuprimentos();
            r.Show();
            Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            frmEstoqueDirecionador r = new frmEstoqueDirecionador();
            r.Show();
            Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            frmRH r = new frmRH();
            r.Show();
            Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            frmFinanceiro r = new frmFinanceiro();
            r.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmEstoqueDirecionador r = new frmEstoqueDirecionador();
            r.Show();
            Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            frmSuprimentos r = new frmSuprimentos();
            r.Show();
            Hide();
        }

        private void Label4_Click_1(object sender, EventArgs e)
        {
            Jarvis r = new Jarvis();
            r.Show();
            Hide();
        }
    }
}
