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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Telas.frmMenu r = new Telas.frmMenu();
            r.Show();
            Hide();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
           Business.BusinessCliente bs = new Business.BusinessCliente();

          dataGridView1.DataSource =  bs.consu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mod.tb_clientes tabela = new Mod.tb_clientes();
            tabela.doc_cep = txtCep.Text;
            tabela.doc_rg = txtRg.Text;
            tabela.end_endereco = txtEndereço.Text;
            tabela.nm_nome = txtNomeCliente.Text;
            tabela.pes_email = txtEmail.Text;
            tabela.tel_telefone = txtTelefone.Text;

            Business.BusinessCliente bs = new Business.BusinessCliente();
            bs.inserir(tabela);
            MessageBox.Show(" Cadastrado");

            //atualizar Datagrid
             dataGridView1.DataSource = bs.consu();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Mod.tb_clientes tabela = dataGridView1.CurrentRow.DataBoundItem as Mod.tb_clientes;
            Business.BusinessCliente bs = new Business.BusinessCliente();

            bs.remover(tabela);
            MessageBox.Show("Deletado Com Suceso");
            //atualizar Datagrid 
            dataGridView1.DataSource = bs.consu();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mod.tb_clientes tabela = dataGridView1.CurrentRow.DataBoundItem as Mod.tb_clientes;
            tabela.doc_cep = txtCep.Text;
            tabela.doc_rg = txtRg.Text;
            tabela.end_endereco = txtEndereço.Text;
            tabela.nm_nome = txtNomeCliente.Text;
            tabela.pes_email = txtEmail.Text;
            tabela.tel_telefone = txtTelefone.Text;


            Business.BusinessCliente bs = new Business.BusinessCliente();
            bs.alterar(tabela);
            MessageBox.Show("Alterado Com sucesso");

            //atualizar Datagrid 
            dataGridView1.DataSource = bs.consu();
        }
    }
}
