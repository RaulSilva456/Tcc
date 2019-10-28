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
            Mod.tb_clientes tabela = new Mod.tb_clientes();
            tabela.tp_conta = txtCompra.Text;
            tabela.dt_data_pagamento = Convert.ToDateTime(dtpDiaCompra);
            tabela.vl_valor = txtValor.Text;
            
          

            Business.BusinessCliente bs = new Business.BusinessCliente();
            bs.inserir(tabela);
            MessageBox.Show("Nova Despesa Adicionada");
        }
    }
}
