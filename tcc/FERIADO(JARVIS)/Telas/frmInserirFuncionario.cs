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
    public partial class frmInserirFuncionario : Form
    {
        public frmInserirFuncionario()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Business.funcionarios_bsiness bs = new Business.funcionarios_bsiness();
            Mod.tb_funcionarios mod = new Mod.tb_funcionarios();
            mod.ad_fgts = Convert.ToDecimal( fgts.Text);
            mod.dt_data_de_contratacao = Convert.ToDateTime( dateTimePicker1.Value);
            mod.fun_endereço =  endereço.Text;
            mod.sl_salario =Convert.ToDecimal( salario.Text);
            mod.nm_funcionario = txtNomeFuncionario.Text;
            mod.fun_cpf = Convert.ToInt32( cpf.Text);
            mod.fun_rg = Convert.ToInt32(rg.Text);
            mod.dt_nasc = Convert.ToDateTime(nacimento.Value);
            bs.inserirFuncionario(mod);
            MessageBox.Show("inserido");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Business.consultas bs = new Business.consultas();

            List<Mod.tb_funcionarios> tabela = bs.consultarFuncionarios();
            dgtFuncionario.DataSource = tabela;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown1.Value);
            Business.funcionarios_bsiness bs = new Business.funcionarios_bsiness();
            bs.deleta(id);
            MessageBox.Show("Removido Com Sucesso");
        }
    }
}
