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
           
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            Business.Estoque_Business bs = new Business.Estoque_Business();
            dgvEstoque.DataSource = bs.listar();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Mod.tb_estoque tabela = new Mod.tb_estoque();
            tabela.nm_produto = txtNome.Text;
            tabela.pr_preco = Convert.ToDecimal( txtPreço.Text);
            
            Business.Estoque_Business bs = new Business.Estoque_Business();
            bs.inserir(tabela);
            MessageBox.Show("Inserido Com Sucesso");

            //Atualizar datagrid
            dgvEstoque.DataSource = bs.listar();
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            Mod.tb_estoque tabela = dgvEstoque.CurrentRow.DataBoundItem as Mod.tb_estoque;
            Business.Estoque_Business bs = new Business.Estoque_Business();

            bs.remover(tabela);
            MessageBox.Show("Deletado");

            //Atualizar datagrid);
            dgvEstoque.DataSource = bs.listar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mod.tb_estoque tabela = dgvEstoque.CurrentRow.DataBoundItem as Mod.tb_estoque;
            
            Business.Estoque_Business bs = new Business.Estoque_Business();
            bs.alterar(tabela);
            MessageBox.Show("Alterado Com Sucesso");


            //Atualizar datagrid
            dgvEstoque.DataSource = bs.listar();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEstoque_Click_1(object sender, EventArgs e)
        {
            try
            { 
                
                if (txtPreço.Text == string.Empty)
                {
                    MessageBox.Show("Campo de preço vazio.");
                }
                if (txtQuantidade.Text == string.Empty)
                {
                    MessageBox.Show("Campo de quantidade vazio.");
                }



            Mod.tb_estoque tabela = new Mod.tb_estoque();
            tabela.dt_saida_do_produto = dtpSaidaProduto.Value;
            tabela.nm_produto = txtNome.Text;
            tabela.pr_preco = Convert.ToDecimal(txtPreço.Text);
            tabela.qtd_quantidade_do_produto = Convert.ToDecimal(txtQuantidade.Text);


                //validaçoes

               
           

            if(rdbSim.Checked == true)
            {
               tabela.pro_vencido = "Perecivel" ;
            }

            if (rdbNao.Checked == true)
            {
                tabela.pro_vencido = "vencido";
            }



            Business.Estoque_Business bs = new Business.Estoque_Business();
            bs.inserir(tabela);
            MessageBox.Show("Produto inserido no estoque.");



            //atualizar datagrid 
            dgvEstoque.DataSource = bs.listar();

            }
        catch (Exception EX)
           {

            MessageBox.Show(EX.Message);
         }

           
            
            
        }

        private void Deletar_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (txtPreço.Text == string.Empty)
                {
                    MessageBox.Show("Campo de preço vazio.");
                }
                if (txtQuantidade.Text == string.Empty)
                {
                    MessageBox.Show("Campo de quantidade vazio.");
                }


                Mod.tb_estoque tabela = dgvEstoque.CurrentRow.DataBoundItem as Mod.tb_estoque;
            tabela.dt_saida_do_produto = dtpSaidaProduto.Value;
            tabela.nm_produto = txtNome.Text;
            tabela.pr_preco = Convert.ToDecimal(txtPreço.Text);
            tabela.qtd_quantidade_do_produto = Convert.ToInt32(txtQuantidade.Text);

                if (rdbSim.Checked == true)
                {
                    tabela.pro_vencido = "Perecivel";
                }

                if (rdbNao.Checked == true)
                {
                    tabela.pro_vencido = "vencido";
                }

                Business.Estoque_Business bs = new Business.Estoque_Business();
            bs.alterar(tabela);
            MessageBox.Show("Produto alterado.");


            //Atualizar datagrid
            dgvEstoque.DataSource = bs.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            Mod.tb_estoque tabela = dgvEstoque.CurrentRow.DataBoundItem as Mod.tb_estoque;
            Business.Estoque_Business bs = new Business.Estoque_Business();

            bs.remover(tabela);
            MessageBox.Show("Produto deletado.");

            //Atualizar datagrid);
            dgvEstoque.DataSource = bs.listar();


        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            frmMenu r = new frmMenu();
            r.Show();
            Hide();
        }
    }
}
