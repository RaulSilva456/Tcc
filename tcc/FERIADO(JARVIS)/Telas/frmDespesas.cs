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
    public partial class frmDespesas : Form
    {
        public frmDespesas()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Telas.frmMenu r = new Telas.frmMenu();
            r.Show();
            Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtValor.Text == string.Empty)
                {
                    MessageBox.Show("Preencha todos os campos corretamente.");
                }

            Mod.tb_despesas tabela = new Mod.tb_despesas();
            tabela.tp_conta = txtCompra.Text;
            tabela.dt_data_pagamento = dtpDiaCompra.Value;
            tabela.vl_valor = Convert.ToInt32( txtValor.Text);
            
          

            Business.Business_Despesas bs = new Business.Business_Despesas();
            bs.inserir(tabela);
            MessageBox.Show("Nova despesa adicionada.");
              //Atualizar a DataGrid
          
            dgvDespesas.DataSource = bs.consultarFuncionarios(); 
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
              
            }

           
        
          


        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            frmMenu r = new frmMenu();
            r.Show();
            Hide();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {

            if (txtCompra.Text == string.Empty || txtValor.Text == string.Empty)
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos.");
            }
   
            Mod.tb_despesas tb = dgvDespesas.CurrentRow.DataBoundItem as Mod.tb_despesas;

            tb.vl_valor = Convert.ToDecimal(txtCompra.Text);
            tb.dt_data_pagamento = Convert.ToDateTime(dtpDiaCompra.Value);
            tb.tp_conta = txtCompra.Text;
                Business.Business_Despesas Bs = new Business.Business_Despesas();
                Bs.alterar(tb);

            
             

                MessageBox.Show("Despesa alterada com sucesso.");

            //atualizar datagrid
          
            dgvDespesas.DataSource =  Bs.consultarFuncionarios();
        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Mod.tb_despesas tb = dgvDespesas.CurrentRow.DataBoundItem as Mod.tb_despesas;


                Business.Business_Despesas bs = new Business.Business_Despesas();
                bs.deletar(tb);
                MessageBox.Show("Despesa removido com sucesso.");



                //Atualizar a DataGrid
                List<Mod.tb_despesas> tabela = bs.consultarFuncionarios();
                dgvDespesas.DataSource = tabela;

            }
            catch (Exception)
            {

                MessageBox.Show("Erro");
            }

        }

        private void frmDespesas_Load(object sender, EventArgs e)
        {
            Business.Business_Despesas bs = new Business.Business_Despesas();
            //Atualizar a DataGrid
            List<Mod.tb_despesas> tabela = bs.consultarFuncionarios();
            dgvDespesas.DataSource = tabela;
        }
    }
}

