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
    public partial class frmFolhaPagamento : Form
    {
        public frmFolhaPagamento()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Telas.frmMenu r = new Telas.frmMenu();
            r.Show();
            Hide();
        }
    }
}
