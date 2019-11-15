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
    public partial class frmRH : Form
    {
        public frmRH()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenu r = new frmMenu();
            r.Show();
            Hide();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string escolha = comboBox1.Text;

            if(escolha == "Funcionarios")
            {
                frmInserirFuncionario r = new frmInserirFuncionario();
                r.Show();
                Hide();
            }
            if (escolha == "Clientes")
            {
                frmClientes r = new frmClientes();
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
