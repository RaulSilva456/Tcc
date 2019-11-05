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
    public partial class frmMostruario : Form
    {
        public frmMostruario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMenu r = new frmMenu();
            r.Show();
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmMostruario_Load(object sender, EventArgs e)
        {
            Business.BusinessMostruario r = new Business.BusinessMostruario();
            dgvMostruario.DataSource = r.lista();

            Business.funcionarios_bsiness bs = new Business.funcionarios_bsiness();
            List<Mod.tb_funcionarios> funcionario = bs.consultarFuncionarios();

            cboFornecedor.DisplayMember = nameof(Mod.tb_funcionarios.nm_funcionario);
            cboFornecedor.DataSource = funcionario;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mod.tb_mostruario tabela = new Mod.tb_mostruario();

                Business.BusinessMostruario bs = new Business.BusinessMostruario();







                tabela.nm_produtomostruario = txtNomeProduto.Text;
                tabela.cat_categoria = txtCategoria.Text;
                tabela.sb_sabor = txtSabor.Text;
                



                bs.inserir(tabela);
                MessageBox.Show("Produto inserido no mostruário.");

                //Atualizar Datagrid
                dgvMostruario.DataSource = bs.lista();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                Mod.tb_mostruario tabela = dgvMostruario.CurrentRow.DataBoundItem as Mod.tb_mostruario;

                Business.BusinessMostruario bs = new Business.BusinessMostruario();
                
               if( MessageBox.Show("Tem Certeza que deseja Remover.", "",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MessageBox.Show("Removido Com Sucesso");

                    dgvMostruario.DataSource = bs.lista();

                    //Atualizar Datagrid
                    bs.deletar(tabela);
                dgvMostruario.DataSource = bs.lista();

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Erro");
            }

        }
    }
}
