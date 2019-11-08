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
    public partial class frmCadastroProdutos : Form
    {
        public frmCadastroProdutos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroProdutos_Load(object sender, EventArgs e)
        {

            Business.Business_Produtos bs = new Business.Business_Produtos();
            dgtFuncionario.DataSource = bs.listar();


            List<Mod.tb_fornecedorp> fornecedor = bs.listarF();

            cboFornecedor.DisplayMember = nameof(Mod.tb_fornecedorp.nm_fornecedor);
            cboFornecedor.DataSource = fornecedor;


        }

        private void label5_Click(object sender, EventArgs e)
        {
            Telas.frmMenu r = new Telas.frmMenu();
            r.Show();
            Hide();
        }

        private void btnInserirProduto_Click(object sender, EventArgs e)
        { Mod.tb_produtop tabela = new Mod.tb_produtop();

          Business.Business_Produtos bs = new Business.Business_Produtos();






            tabela.nm_fornecedor_produto = cboFornecedor.Text;

           
            tabela.cat_categoria = txtCategoria.Text;
            tabela.nm_produto = txtNomeProduto.Text;
            tabela.sb_sabor = txtSabor.Text;
           
          
                                        
            
            bs.inerir(tabela);
            MessageBox.Show("Produto cadastrado.");
            //Atualizar Datagrid
            dgtFuncionario.DataSource = bs.listar();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mod.tb_produtop tabela = dgtFuncionario.CurrentRow.DataBoundItem as Mod.tb_produtop;
            tabela.cat_categoria = txtCategoria.Text;
            tabela.nm_produto = txtNomeProduto.Text;
            tabela.sb_sabor = txtSabor.Text;
            Business.Business_Produtos bs = new Business.Business_Produtos();
            bs.alterar(tabela);
            MessageBox.Show("Produto alterardo.");
            //Atualizar Datagrid
            dgtFuncionario.DataSource = bs.listar();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mod.tb_produtop tabela = dgtFuncionario.CurrentRow.DataBoundItem as Mod.tb_produtop;
            Business.Business_Produtos bs = new Business.Business_Produtos();
            bs.deletar(tabela);
            MessageBox.Show("Produto retirado.");
            
            
            //Atualizar Datagrid
            dgtFuncionario.DataSource = bs.listar();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenu r = new frmMenu();
            r.Show();
            Hide();
        }

        private void btnInserirProduto_Click_1(object sender, EventArgs e)
        {
            try
            {
                Mod.tb_produtop tabela = new Mod.tb_produtop();

            Business.Business_Produtos bs = new Business.Business_Produtos();






            
            tabela.nm_fornecedor_produto = cboFornecedor.Text;
            tabela.cat_categoria = txtCategoria.Text;
            tabela.nm_produto = txtNomeProduto.Text;
            tabela.sb_sabor = txtSabor.Text;




            bs.inerir(tabela);
            MessageBox.Show("Produto cadastrado.");

            //Atualizar Datagrid
            dgtFuncionario.DataSource = bs.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            try
            {
                Mod.tb_produtop tabela = dgtFuncionario.CurrentRow.DataBoundItem as Mod.tb_produtop;

            Business.Business_Produtos bs = new Business.Business_Produtos();

            tabela.nm_fornecedor_produto = cboFornecedor.Text;
            tabela.cat_categoria = txtCategoria.Text;
            tabela.nm_produto = txtNomeProduto.Text;
            tabela.sb_sabor = txtSabor.Text;




            bs.alterar(tabela);
            MessageBox.Show("Produto alterado.");
            //Atualizar Datagrid
            dgtFuncionario.DataSource = bs.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           








        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            { Mod.tb_produtop tabela = dgtFuncionario.CurrentRow.DataBoundItem as Mod.tb_produtop;

            Business.Business_Produtos bs = new Business.Business_Produtos();
            bs.deletar(tabela);
            MessageBox.Show("Produto foi removido com sucesso.");
            dgtFuncionario.DataSource = bs.listar();

            }
            catch (Exception)
            {

                throw;
            }
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
