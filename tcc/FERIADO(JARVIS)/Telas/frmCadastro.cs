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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Mod.tb_login tabela = new Mod.tb_login();
            tabela.nm_nome = txtUsuario.Text;
            tabela.pes_email = txtEmail.Text;
            tabela.pes_senha = txtSenha.Text;
            Business.BusinessLogin bs = new Business.BusinessLogin();
            bs.Cadastrar(tabela);
            MessageBox.Show("cadastrado");
        }
    }
}
