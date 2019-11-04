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
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          try
            {
                if (txtHRExtra.Text == string.Empty)
                {
                    MessageBox.Show("Campo de hora extra vazio.");

                }
                else if (txtFaltas.Text == string.Empty)
                {
                    MessageBox.Show("Campo de faltas vazio");

                }
                else if (txtGratificação.Text == string.Empty)
                {
                    MessageBox.Show("Campo de gratificação vazio.");

                }
                else if (txtINSS.Text == string.Empty)
                {
                    MessageBox.Show("Campo de INSS Vazio.");

                }
                else if (txtImpostoRenda.Text == string.Empty)
                {
                    MessageBox.Show("Campo de imposto de renda vazio.");

                }
                else if (txtSalarioBruto.Text == string.Empty)
                {
                    MessageBox.Show("Campo de salário bruto vazio.");

                }
                else if (txtSalarioLiquido.Text == string.Empty)
                {
                    MessageBox.Show("Campo de salário liquido vazio.");

                }
                else if (txtVA.Text == string.Empty)
                {
                    MessageBox.Show("Campo de vale alimentação vazio.");

                }
                else if (txtVT.Text == string.Empty)
                {
                    MessageBox.Show("Campo de vale tranporte vazio.");

                }










                Mod.tb_folhapagamento tabela = new Mod.tb_folhapagamento();

                tabela.ad_gratificação = Convert.ToDecimal(txtGratificação.Text);
                tabela.ds_faltas = Convert.ToInt32(txtFaltas.Text);
                tabela.ds_inss = Convert.ToDecimal(txtINSS.Text);
                tabela.dt_pagamento = pagamento.Value;
                tabela.hora_extra = Convert.ToDecimal(txtHRExtra.Text);
                tabela.imposto_renda = Convert.ToDecimal(txtImpostoRenda.Text);
                tabela.sl_salario_bruto = Convert.ToDecimal(txtSalarioBruto.Text);
                tabela.sl_salario_liquido = Convert.ToDecimal(txtSalarioLiquido.Text);
                tabela.vl_alimentação = Convert.ToDecimal(txtVA.Text);
                tabela.vl_transporte = Convert.ToDecimal(txtVT.Text);
                tabela.nm_funcionario = cboFuncionario.Text;

                Business.Business_Folha_de_Pagamento bs = new Business.Business_Folha_de_Pagamento();
                bs.inserir(tabela);
                MessageBox.Show("Funcionário inserido com sucesso.");

                //Atualizar DataGrid
                dgvFolhaPagamento.DataSource = bs.listar();
          }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void frmFolhaPagamento_Load(object sender, EventArgs e)
        {


            Business.funcionarios_bsiness bs = new Business.funcionarios_bsiness();
            Business.Business_Folha_de_Pagamento bss = new Business.Business_Folha_de_Pagamento();
            dgvFolhaPagamento.DataSource = bss.listar();



            List<Mod.tb_funcionarios> funcionario = bs.consultarFuncionarios();

            cboFuncionario.DisplayMember = nameof(Mod.tb_funcionarios.nm_funcionario);
            cboFuncionario.DataSource = funcionario;

        }

        private void button2_Click(object sender, EventArgs e)
        {

           





        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                Mod.tb_folhapagamento tabela = dgvFolhaPagamento.CurrentRow.DataBoundItem as Mod.tb_folhapagamento;
                Business.Business_Folha_de_Pagamento bs = new Business.Business_Folha_de_Pagamento();
                bs.remover(tabela);

                //Atualizar DataGrid
                dgvFolhaPagamento.DataSource = bs.listar();

            }
            catch (Exception)
            {

                MessageBox.Show("Erro!");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Mod.tb_folhapagamento tabela = dgvFolhaPagamento.CurrentRow.DataBoundItem as Mod.tb_folhapagamento;

                tabela.ad_gratificação = Convert.ToDecimal(txtGratificação.Text);
                tabela.ds_faltas = Convert.ToInt32(txtFaltas.Text);
                tabela.ds_inss = Convert.ToInt32(txtINSS.Text);
                tabela.dt_pagamento = pagamento.Value;
                tabela.hora_extra = Convert.ToInt32(txtHRExtra.Text);
                tabela.imposto_renda = Convert.ToInt32(txtImpostoRenda.Text);
                tabela.sl_salario_bruto = Convert.ToInt32(txtSalarioBruto.Text);
                tabela.sl_salario_liquido = Convert.ToInt32(txtSalarioLiquido.Text);
                tabela.vl_alimentação = Convert.ToInt32(txtVA.Text);
                tabela.vl_transporte = Convert.ToInt32(txtVT.Text);
                tabela.nm_funcionario = cboFuncionario.Text;


                Business.Business_Folha_de_Pagamento bs = new Business.Business_Folha_de_Pagamento();
                bs.alterar(tabela);
                MessageBox.Show("Funcionário alterado.");









                //Atualizar DataGrid
                dgvFolhaPagamento.DataSource = bs.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                Mod.tb_folhapagamento tabela = dgvFolhaPagamento.CurrentRow.DataBoundItem as Mod.tb_folhapagamento;
                Business.Business_Folha_de_Pagamento bs = new Business.Business_Folha_de_Pagamento();
                bs.remover(tabela);
                MessageBox.Show(" Funcionário deletado.");

                //Atualizar DataGrid
                dgvFolhaPagamento.DataSource = bs.listar();

            }
            catch (Exception)
            {

                MessageBox.Show("Erro!");
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMenu r = new frmMenu();
            r.Show();
            Hide();
        }
    }
}

