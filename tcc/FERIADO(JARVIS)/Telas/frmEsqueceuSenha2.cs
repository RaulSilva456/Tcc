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
    public partial class frmEsqueceuSenha2 : Form
    {
        public frmEsqueceuSenha2()
        {
            InitializeComponent();
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
