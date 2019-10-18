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
    public partial class frmPedidoCliente : Form
    {
        public frmPedidoCliente()
        {
            InitializeComponent();
        }

        private void frmPedidoCliente_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Telas.frmMenu r = new Telas.frmMenu();
            r.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telas.frmConfirmarCompra r = new Telas.frmConfirmarCompra();
            r.Show();
            Hide();
        }
    }
}
