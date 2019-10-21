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
           
            Telas.frmMenu r = new Telas.frmMenu();
            r.Show();
            Hide();
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
            
            
          //Atualizar a DataGrid
            List<Mod.tb_funcionarios> tabela = bs.consultarFuncionarios();
            dgtFuncionario.DataSource = tabela;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Business.funcionarios_bsiness bs = new Business.funcionarios_bsiness();

            List<Mod.tb_funcionarios> tabela = bs.consultarFuncionarios();
            dgtFuncionario.DataSource = tabela;
        }

        private void label6_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
             Mod.tb_funcionarios tb = dgtFuncionario.CurrentRow.DataBoundItem as Mod.tb_funcionarios;
                

            Business.funcionarios_bsiness bs = new Business.funcionarios_bsiness();
            bs.deleta(tb);
            MessageBox.Show("Removido Com Sucesso");


            
   //Atualizar a DataGrid
            List<Mod.tb_funcionarios> tabela = bs.consultarFuncionarios();
            dgtFuncionario.DataSource = tabela;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mod.tb_funcionarios tb = dgtFuncionario.CurrentRow.DataBoundItem as Mod.tb_funcionarios;
           
            tb.ad_fgts = Convert.ToDecimal(fgts.Text);
            tb.dt_data_de_contratacao = Convert.ToDateTime(dateTimePicker1.Value);
            tb.fun_endereço = endereço.Text;
            tb.sl_salario = Convert.ToDecimal(salario.Text);
            tb.nm_funcionario = txtNomeFuncionario.Text;
            tb.fun_cpf = Convert.ToInt32(cpf.Text);
            tb.fun_rg = Convert.ToInt32(rg.Text);
            tb.dt_nasc = Convert.ToDateTime(nacimento.Value);

           
            Business.funcionarios_bsiness business = new Business.funcionarios_bsiness();
            business.alterar(tb);
            MessageBox.Show("alterado Com Sucesso");

           
            List<Mod.tb_funcionarios> tabela = business.consultarFuncionarios();
            dgtFuncionario.DataSource = tabela;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void frmInserirFuncionario_Load(object sender, EventArgs e)
        {

            Business.funcionarios_bsiness bs = new Business.funcionarios_bsiness();

            List<Mod.tb_funcionarios> tabela = bs.consultarFuncionarios();
            dgtFuncionario.DataSource = tabela;
        }

        private void dgtFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
