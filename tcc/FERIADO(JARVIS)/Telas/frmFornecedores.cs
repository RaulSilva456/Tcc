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
            Telas.frmMenu r = new Telas.frmMenu();
            r.Show();
            Hide();

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
            Mod.tb_fornecedores tabela = new Mod.tb_fornecedores();
            tabela.end_endereço = txtEndereço.Text;
            tabela.fr_cep =txtCEP.Text;
            tabela.fr_cnpj = txtCNPJ.Text;
            tabela.nm_fornecedor = txtNMFornecedor.Text;
            tabela.nm_produto = txtNMProduto.Text;
            tabela.tl_telefone =  txtTelefone.Text;
            tabela.vl_valor_produto = Convert.ToDecimal(txtValorPago.Text);
            Business.BusinessFornecedores bs = new Business.BusinessFornecedores();
            bs.inserir(tabela);
            MessageBox.Show("Cadastrado");
            
            
            //atualizar Datagrid
            dataGridView1.DataSource = bs.listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mod.tb_fornecedores tabela = dataGridView1.CurrentRow.DataBoundItem as Mod.tb_fornecedores;
            Business.BusinessFornecedores bs = new Business.BusinessFornecedores();
            bs.deletar(tabela);
            MessageBox.Show("Deletado");
            //atualizar Datagrid
            dataGridView1.DataSource = bs.listar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mod.tb_fornecedores tabela = new Mod.tb_fornecedores();
            tabela.end_endereço = txtEndereço.Text;
            tabela.fr_cep = txtCEP.Text;
            tabela.fr_cnpj = txtCNPJ.Text;
            tabela.nm_fornecedor = txtNMFornecedor.Text;
            tabela.nm_produto = txtNMProduto.Text;
            tabela.tl_telefone = txtTelefone.Text;
            tabela.vl_valor_produto = Convert.ToInt32(txtValorPago.Text);
            Business.BusinessFornecedores bs = new Business.BusinessFornecedores();
            bs.alterar(tabela);
            MessageBox.Show("Alteração com sucesso");
            //atualizar Datagrid
            dataGridView1.DataSource = bs.listar();

        }
    }
}
