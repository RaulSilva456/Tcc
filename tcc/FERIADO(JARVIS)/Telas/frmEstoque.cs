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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Telas.frmMenu r = new Telas.frmMenu();
            r.Show();
            Hide();
        }
    }
}
