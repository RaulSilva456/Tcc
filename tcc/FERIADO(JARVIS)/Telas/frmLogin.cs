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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string login, senha,email;
            login = txtNome.Text;
            senha = txtSenha.Text;
            email = txtNome.Text;
            

            Objetos funcao = new Objetos();

            if(txtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo de usuário vazio.");
                
            }
           else  if  (txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Campo de senha vazio.");
            }
            else
            {
                if (funcao.login(login,senha,email)== false)
                {
                    MessageBox.Show("Senha ou Usuário incorreto.");
                }
                else
                {
                    
                    frmSplash r = new frmSplash();
                    r.Show();
                    Hide();

                }



            }
            



        
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmCadastro r = new frmCadastro();
            r.Show();
            Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {
         
            
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
           
          
        }

        private void lblEsqueceuSenha_Click(object sender, EventArgs e)
        {
            Telas.frmEsqueceuSenha r = new Telas.frmEsqueceuSenha();
            r.Show();
            Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
