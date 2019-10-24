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
    public partial class frmFolhaPagamento : Form
    {
        public frmFolhaPagamento()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Telas.frmMenu r = new Telas.frmMenu();
            r.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mod.tb_folhapagamento tabela = new Mod.tb_folhapagamento();

            tabela.ad_gratificação =Convert.ToDecimal( txtGratificação.Text);
            tabela.ds_faltas = Convert.ToInt32(txtFaltas.Text);
            tabela.ds_inss = Convert.ToInt32(txtINSS.Text);
            tabela.dt_pagamento = pagamento.Value;
            tabela.hora_extra = Convert.ToInt32(txtHRExtra.Text);
            tabela.imposto_renda = Convert.ToInt32(txtImpostoRenda.Text);
            tabela.sl_salario_bruto = Convert.ToInt32(txtSalarioBruto.Text);
            tabela.sl_salario_liquido = Convert.ToInt32(txtSalarioLiquido.Text);
            tabela.vl_alimentação = Convert.ToInt32(txtVA.Text);
            tabela.vl_transporte = Convert.ToInt32(txtVT.Text);

            Business.Business_Folha_de_Pagamento bs = new Business.Business_Folha_de_Pagamento();
            bs.inserir(tabela);
            MessageBox.Show("Inserido com sucesso");
        }
    }
}
