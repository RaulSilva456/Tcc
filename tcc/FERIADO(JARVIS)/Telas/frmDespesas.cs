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
                    MessageBox.Show("Campo Valor Vazio");
                }

        Mod.tb_despesas tabela = new Mod.tb_despesas();
            tabela.tp_conta = txtCompra.Text;
            tabela.dt_data_pagamento = dtpDiaCompra.Value;
            tabela.vl_valor = Convert.ToInt32( txtValor.Text);
            
          

            Business.Business_Despesas bs = new Business.Business_Despesas();
            bs.inserir(tabela);
            MessageBox.Show("Nova Despesa Adicionada");
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
              
            }

          
        }
    }
}
