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
            dgvPedido.DataSource = bs.listar();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            frmPedidoCliente r = new frmPedidoCliente();
            r.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mod.tb_pedido_clientep tb = dgvPedido.CurrentRow.DataBoundItem as Mod.tb_pedido_clientep;
            Business.BusinessPedidoCliente bs = new Business.BusinessPedidoCliente();
            bs.deletar(tb);
            MessageBox.Show("Pedido realizado com sucesso.");
           dgvPedido.DataSource =  bs.listar();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmAlterarPedido r  = new frmAlterarPedido();
            r.Show();
            Hide();
        }
    }
}
