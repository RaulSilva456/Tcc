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
            var funcao = new Database.databaseLogin();

            string login, senha;
            login = txtNome.Text;
            senha = txtSenha.Text;

            if(!funcao.login(login,senha))
            {
                MessageBox.Show("Login Ou Senha Incorretos", "ATENÇÃO");
            }
            else
            {
                MessageBox.Show("Logado");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
