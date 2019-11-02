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
    public partial class frmEsqueceuSenha : Form
    {
        public frmEsqueceuSenha()
        {
            InitializeComponent();
        }

        private void FrmEsqueceuSenha_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmEsqueceuSenha2 r = new frmEsqueceuSenha2();
            r.Show();
            Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            frmLogin r = new frmLogin();
            r.Show();
            Hide();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
