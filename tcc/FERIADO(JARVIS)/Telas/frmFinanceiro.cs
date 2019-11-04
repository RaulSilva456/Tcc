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
    public partial class frmFinanceiro : Form
    {
        public frmFinanceiro()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenu r = new frmMenu();
            r.Show();
            Hide();
        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string escolha = comboBox1.Text;

            if (escolha == "Folha de Pagamento")
            {
                frmFolhaPagamento r = new frmFolhaPagamento();
                r.Show();
                Hide();
            }
            if (escolha == "Despesas")
            {
                frmDespesas r = new frmDespesas();
                r.Show();
                Hide();
            }
            if (escolha == "Fornecedores")
            {
                frmFornecedores r = new frmFornecedores();
                r.Show();
                Hide();
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            frmMenu r = new frmMenu();
            r.Show();
            Hide();
        }
    }
}
