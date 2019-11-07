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
            Mod.tb_cliente tabela = new Mod.tb_cliente();
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
                MessageBox.Show("Cadastro realizado com sucesso.");

                }
                else
                {
                    MessageBox.Show("Email inválido.");
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
            {Mod.tb_cliente tabela = dgvClientes.CurrentRow.DataBoundItem as Mod.tb_cliente;
            Business.BusinessCliente bs = new Business.BusinessCliente();

            bs.remover(tabela);
            MessageBox.Show("Cliente foi removido.");
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
            {Mod.tb_cliente tabela = dgvClientes.CurrentRow.DataBoundItem as Mod.tb_cliente;
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
            MessageBox.Show("Dados do cliente alterados.");

                }
                else
                {
                    MessageBox.Show("Email inválido.");

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
