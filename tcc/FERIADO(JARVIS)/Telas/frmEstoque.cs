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

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            Business.Estoque_Business bs = new Business.Estoque_Business();
            dataGridView1.DataSource = bs.listar();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Mod.tb_estoque tabela = new Mod.tb_estoque();
            tabela.nm_produto = txtNomeProduto.Text;
            tabela.pr_preço = Convert.ToDecimal( txtPreço.Text);
            tabela.vl_validade_produto = dtpValidadeProduto.Value;
            Business.Estoque_Business bs = new Business.Estoque_Business();
            bs.inserir(tabela);
            MessageBox.Show("Inserido Com Sucesso");

            //Atualizar datagrid
            dataGridView1.DataSource = bs.listar();
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            Mod.tb_estoque tabela = dataGridView1.CurrentRow.DataBoundItem as Mod.tb_estoque;
            Business.Estoque_Business bs = new Business.Estoque_Business();

            bs.remover(tabela);
            MessageBox.Show("Deletado");

            //Atualizar datagrid
            dataGridView1.DataSource = bs.listar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mod.tb_estoque tabela = dataGridView1.CurrentRow.DataBoundItem as Mod.tb_estoque;
            tabela.nm_produto = txtNomeProduto.Text;
            tabela.pr_preço = Convert.ToDecimal(txtPreço.Text);
            tabela.vl_validade_produto = dtpValidadeProduto.Value;
            Business.Estoque_Business bs = new Business.Estoque_Business();
            bs.alterar(tabela);
            MessageBox.Show("Alterado Com Sucesso");


            //Atualizar datagrid
            dataGridView1.DataSource = bs.listar();

        }
    }
}
