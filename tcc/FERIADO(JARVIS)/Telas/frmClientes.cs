using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

          dgvClientes.DataSource =  bs.consu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {Business.BusinessCliente bs = new Business.BusinessCliente();
            Mod.tb_clientes tabela = new Mod.tb_clientes();
            tabela.doc_cep = txtCep.Text;
            tabela.doc_rg = txtRg.Text;
            tabela.end_endereco = txtEndereço.Text;
            tabela.nm_nome = txtNomeCliente.Text;
            tabela.pes_email = txtEmail.Text;
            tabela.tel_telefone = txtTelefone.Text;


                Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");



                if (rg.IsMatch(tabela.pes_email))
                {
                bs.inserir(tabela);
                MessageBox.Show("Cadastrado");

                }
                else
                {
                    MessageBox.Show("Email Invalido");
                }


                    
           
              



                






            //atualizar Datagrid
            dgvClientes.DataSource = bs.consu();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {Mod.tb_clientes tabela = dgvClientes.CurrentRow.DataBoundItem as Mod.tb_clientes;
            Business.BusinessCliente bs = new Business.BusinessCliente();

            bs.remover(tabela);
            MessageBox.Show("Deletado Com Suceso");
            //atualizar Datagrid 
            dgvClientes.DataSource = bs.consu();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            try
            {Mod.tb_clientes tabela = dgvClientes.CurrentRow.DataBoundItem as Mod.tb_clientes;
            tabela.doc_cep = txtCep.Text;
            tabela.doc_rg = txtRg.Text;
            tabela.end_endereco = txtEndereço.Text;
            tabela.nm_nome = txtNomeCliente.Text;
            tabela.pes_email = txtEmail.Text;
            tabela.tel_telefone = txtTelefone.Text;


            Business.BusinessCliente bs = new Business.BusinessCliente();

                Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

                if(rg.IsMatch((tabela.pes_email)))
                {
                bs.alterar(tabela);
            MessageBox.Show("Alterado Com sucesso");

                }
                else
                {
                    MessageBox.Show("Email Invalido");

                }


            //atualizar Datagrid 
            dgvClientes.DataSource = bs.consu();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

    
        }

        private void Label8_Click(object sender, EventArgs e)
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
