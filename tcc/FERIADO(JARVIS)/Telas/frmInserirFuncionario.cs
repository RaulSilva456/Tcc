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
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Business.funcionarios_bsiness bs = new Business.funcionarios_bsiness();

            List<Mod.tb_funcionario> tabela = bs.consultarFuncionarios();
            dgtFuncionario.DataSource = tabela;
        }

        private void label6_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void frmInserirFuncionario_Load(object sender, EventArgs e)
        {

            Business.funcionarios_bsiness bs = new Business.funcionarios_bsiness();

            List<Mod.tb_funcionario> tabela = bs.consultarFuncionarios();
            dgtFuncionario.DataSource = tabela;
        }

        private void dgtFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            


            try
            {
                if(salario.Text == string.Empty)
                {
                    MessageBox.Show("Campo de salário vazio.");
                }
                if (fgts.Text == string.Empty)
                {
                    MessageBox.Show("Campo de FGTS vazio.");
                }
               


             Business.funcionarios_bsiness bs = new Business.funcionarios_bsiness();
            Mod.tb_funcionario tb = new Mod.tb_funcionario();

                tb.fc_telefone = fgts.Text;
                tb.dt_data_de_contratacao = Convert.ToDateTime(dateTimePicker1.Value);
                tb.fc_endereço = endereço.Text;
                tb.sl_salario = Convert.ToDecimal(salario.Text);
                tb.nm_funcionario = txtNomeFuncionario.Text;
                tb.fc_cpf = cpf.Text;
                tb.fc_rg = rg.Text;
                tb.dt_nasc = Convert.ToDateTime(nascimento.Value);
                tb.dt_pagamento = DtpDiaPagamento.Value;
                tb.fc_cargo = txtCargo.Text;
                bs.inserirFuncionario(tb);
            MessageBox.Show("Funcionário cadastrado.");


            //Atualizar a DataGrid
            List<Mod.tb_funcionario> tabela = bs.consultarFuncionarios();
            dgtFuncionario.DataSource = tabela;
            }
            catch (Exception )
            {

             MessageBox.Show("erros");
            }
            

            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          

            try
            {


                if (salario.Text == string.Empty)
                {
                    MessageBox.Show("Campo de salário vazio.");
                }
                if (fgts.Text == string.Empty)
                {
                    MessageBox.Show("Campo de FGTS vazio.");
                }
                Mod.tb_funcionario tb = dgtFuncionario.CurrentRow.DataBoundItem as Mod.tb_funcionario;

            tb.fc_telefone = fgts.Text;
            tb.dt_data_de_contratacao = Convert.ToDateTime(dateTimePicker1.Value);
            tb.fc_endereço = endereço.Text;
            tb.sl_salario = Convert.ToDecimal(salario.Text);
            tb.nm_funcionario = txtNomeFuncionario.Text;
            tb.fc_cpf = cpf.Text;
            tb.fc_rg = rg.Text;
            tb.dt_nasc = Convert.ToDateTime(nascimento.Value);
            tb.dt_pagamento = DtpDiaPagamento.Value;
            tb.fc_cargo = txtCargo.Text;


            Business.funcionarios_bsiness business = new Business.funcionarios_bsiness();
            business.alterar(tb);
            MessageBox.Show("Funcionário alterado.");


            //atualizar datagrid
            List<Mod.tb_funcionario> tabela = business.consultarFuncionarios();
            dgtFuncionario.DataSource = tabela;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
    }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            { Mod.tb_funcionario tb = dgtFuncionario.CurrentRow.DataBoundItem as Mod.tb_funcionario;


            Business.funcionarios_bsiness bs = new Business.funcionarios_bsiness();
            bs.deleta(tb);
            MessageBox.Show("Funcionário removido.");



            //Atualizar a DataGrid
            List<Mod.tb_funcionario> tabela = bs.consultarFuncionarios();
            dgtFuncionario.DataSource = tabela;

            }
            catch (Exception)
            {

                MessageBox.Show("Erro!");
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void salario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            Telas.frmMenu r = new Telas.frmMenu();
            r.Show();
            Hide();
        }
    }
}
