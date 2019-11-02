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
    public partial class frmConfirmarCompra : Form
    {
        public frmConfirmarCompra()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Telas.frmMenu r = new Telas.frmMenu();
            r.Show();
            Hide();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmConfirmarCompra_Load(object sender, EventArgs e)
        {
            Business.BusinessPedidoCliente bs = new Business.BusinessPedidoCliente();
            bs.listar();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            frmPedidoCliente r = new frmPedidoCliente();
            r.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
