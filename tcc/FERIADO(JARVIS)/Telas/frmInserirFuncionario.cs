﻿using System;
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

            List<Mod.tb_funcionariosp> tabela = bs.consultarFuncionariosp();
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

            List<Mod.tb_funcionariosp> tabela = bs.consultarFuncionariosp();
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
            Mod.tb_funcionariosp mod = new Mod.tb_funcionariosp();
            mod.ad_fgts = Convert.ToDecimal(fgts.Text);
            mod.dt_data_de_contratacao = Convert.ToDateTime(dateTimePicker1.Value);
            mod.fun_endereço = endereço.Text;
            mod.sl_salario = Convert.ToDecimal(salario.Text);
            mod.nm_funcionario = txtNomeFuncionario.Text;
            mod.fun_cpf = cpf.Text;
            mod.fun_rg =  rg.Text;
            mod.dt_nasc = Convert.ToDateTime(nascimento.Value);
            mod.dt_pagamento_do_funcionario = DtpDiaPagamento.Value;
            mod.fun_cargo = txtCargo.Text;
            bs.inserirFuncionario(mod);
            MessageBox.Show("Funcionário cadastrado.");


            //Atualizar a DataGrid
            List<Mod.tb_funcionariosp> tabela = bs.consultarFuncionariosp();
            dgtFuncionario.DataSource = tabela;
            }
            catch (Exception ee)
            {

             MessageBox.Show(ee.Message);
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
                Mod.tb_funcionariosp tb = dgtFuncionario.CurrentRow.DataBoundItem as Mod.tb_funcionariosp;

            tb.ad_fgts = Convert.ToInt32(fgts.Text);
            tb.dt_data_de_contratacao = Convert.ToDateTime(dateTimePicker1.Value);
            tb.fun_endereço = endereço.Text;
            tb.sl_salario = Convert.ToInt32(salario.Text);
            tb.nm_funcionario = txtNomeFuncionario.Text;
            tb.fun_cpf = cpf.Text;
            tb.fun_rg = rg.Text;
            tb.dt_nasc = Convert.ToDateTime(nascimento.Value);
            tb.dt_pagamento_do_funcionario = DtpDiaPagamento.Value;
            tb.fun_cargo = txtCargo.Text;


            Business.funcionarios_bsiness business = new Business.funcionarios_bsiness();
            business.alterar(tb);
            MessageBox.Show("Funcionário alterado.");


            //atualizar datagrid
            List<Mod.tb_funcionariosp> tabela = business.consultarFuncionariosp();
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
            { Mod.tb_funcionariosp tb = dgtFuncionario.CurrentRow.DataBoundItem as Mod.tb_funcionariosp;


            Business.funcionarios_bsiness bs = new Business.funcionarios_bsiness();
            bs.deleta(tb);
            MessageBox.Show("Funcionário removido.");



            //Atualizar a DataGrid
            List<Mod.tb_funcionariosp> tabela = bs.consultarFuncionariosp();
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
