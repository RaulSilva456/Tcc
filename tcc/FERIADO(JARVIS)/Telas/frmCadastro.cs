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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        } 
         Business.BusinessLogin bs = new Business.BusinessLogin();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Mod.tb_login tabela = new Mod.tb_login();
            tabela.nm_nome = txtUsuario.Text;
            tabela.pes_email = txtEmail.Text;
            tabela.pes_senha = txtSenha.Text;
          

            if (txtconfi.Text == txtSenha.Text)
            {
                bs.Cadastrar(tabela);
                MessageBox.Show("cadastrado realizado com sucesso");

                frmLogin r = new frmLogin();
                r.Show();
                Hide();

            }

            //validação na verificação de senha
            if(txtconfi.Text != txtSenha.Text)
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    MessageBox.Show("Senha Nao se Coecidem");
                }
            }

          
            




            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtconfi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Txtconfi_TextChanged_1(object sender, EventArgs e)
        {
            if (txtconfi.Text != txtSenha.Text)
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
