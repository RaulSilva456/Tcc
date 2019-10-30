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
            Business.BusinessPedidoCliente bs = new Business.BusinessPedidoCliente();

             dgvEstoque.DataSource = bs.listar();

            Business.Business_Produtos bss = new Business.Business_Produtos();

            List<Mod.tb_produto> produto = bss.listar();
            CboProduto.DisplayMember = nameof(Mod.tb_produto.nm_produto);
            CboProduto.DataSource = produto;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {Mod.tb_pedido_cliente tabela = new Mod.tb_pedido_cliente();
            tabela.nm_produto_cliente = CboProduto.Text;
            tabela.qtd_quantidade = Convert.ToInt32(nudQuantidadePedido.Value);
            Business.BusinessPedidoCliente bs = new Business.BusinessPedidoCliente();
            bs.inseri(tabela);
                MessageBox.Show("Pedido Enviado");
            
            //atualizar Data Grid
            dgvEstoque.DataSource = bs.listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nudQuantidadePedido_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtProdutoPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
