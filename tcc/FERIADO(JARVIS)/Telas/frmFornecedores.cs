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
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            Business.BusinessFornecedores BS = new Business.BusinessFornecedores();
           
            dataGridView1.DataSource = BS.listar();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(txtValorPago.Text == string.Empty)
                {
                    MessageBox.Show("Campo de valor pago vazio.");
                }
                
            Mod.tb_fornecedorp tabela = new Mod.tb_fornecedorp();
               
            tabela.end_endereço = txtEndereço.Text;
            tabela.fr_cep = txtCEP.Text;
            tabela.fr_cnpj = txtCNPJ.Text;
            tabela.nm_fornecedor = txtNMFornecedor.Text;
            tabela.nm_produto = txtNMProduto.Text;
            tabela.tl_telefone = txtTelefone.Text;
            tabela.vl_valor_produto = Convert.ToDecimal(txtValorPago.Text);
             tabela.dt_entrada_do_produto = DataProduto.Value;
            Business.BusinessFornecedores bs = new Business.BusinessFornecedores();
            bs.inserir(tabela);
            MessageBox.Show("Fornecedor novo adicionado.");


            //atualizar Datagrid
            dataGridView1.DataSource = bs.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            { Mod.tb_fornecedorp tabela = dataGridView1.CurrentRow.DataBoundItem as Mod.tb_fornecedorp;
            Business.BusinessFornecedores bs = new Business.BusinessFornecedores();
            bs.deletar(tabela);
            MessageBox.Show("Fornecedor deletado.");
            //atualizar Datagrid
            dataGridView1.DataSource = bs.listar();

            }
            catch (Exception)
            {

                MessageBox.Show("Erro!");
            }

           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (txtValorPago.Text == string.Empty)
                {
                    MessageBox.Show("Campo de valor pago vazio.");
                }

                Mod.tb_fornecedorp tabela = dataGridView1.CurrentRow.DataBoundItem as Mod.tb_fornecedorp;
            tabela.end_endereço = txtEndereço.Text;
            tabela.fr_cep = txtCEP.Text;
            tabela.fr_cnpj = txtCNPJ.Text;
            tabela.nm_fornecedor = txtNMFornecedor.Text;
            tabela.nm_produto = txtNMProduto.Text;
            tabela.tl_telefone = txtTelefone.Text;
            tabela.vl_valor_produto = Convert.ToDecimal(txtValorPago.Text);
            Business.BusinessFornecedores bs = new Business.BusinessFornecedores();
            bs.alterar(tabela);
            MessageBox.Show("Fornecedor alterado.");
            //atualizar Datagrid
            dataGridView1.DataSource = bs.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMenu r = new frmMenu();
            r.Show();
            Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
