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
    public partial class frmAlterarPedido : Form
    {
        public frmAlterarPedido()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            frmConfirmarCompra r = new frmConfirmarCompra();
            r.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Mod.tb_pedido_cliente tabela = dataGridView1.CurrentRow.DataBoundItem as Mod.tb_pedido_cliente;

                tabela.qtd_quantidade = Convert.ToInt32(nudQuantidadeAlteração.Value);
                tabela.nm_nome = CboProduto.Text;
               
                Business.BusinessPedidoCliente bs = new Business.BusinessPedidoCliente();
                bs.alterar(tabela);
                MessageBox.Show("Pedido alterado com sucesso.");

                //atualizar Data Grid
                dataGridView1.DataSource = bs.listar();

                frmConfirmarCompra r = new frmConfirmarCompra();
                r.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void frmAlterarPedido_Load(object sender, EventArgs e)
        {
           

        }

        private void frmAlterarPedido_Load_1(object sender, EventArgs e)
        {
 Business.BusinessPedidoCliente bs = new Business.BusinessPedidoCliente();

            dataGridView1.DataSource = bs.listar();

            Business.Business_Produtos bss = new Business.Business_Produtos();

            List<Mod.tb_produto> produto = bss.listar();
            CboProduto.DisplayMember = nameof(Mod.tb_produto.nm_produto);
            CboProduto.DataSource = produto;
        }
    }
}
