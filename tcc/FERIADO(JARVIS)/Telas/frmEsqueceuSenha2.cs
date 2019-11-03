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
    public partial class frmEsqueceuSenha2 : Form
    {
        public frmEsqueceuSenha2()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            frmLogin r = new frmLogin();
            r.Show();
            Hide();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEsqueceuSenha2_Load(object sender, EventArgs e)
        {
            Random rdn = new Random();
            rdn.Next();

            txtCodigo.Text += rdn.Next(0, 1000) + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
            if(txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Não mexa no campo de código! Renicie o programa.");
            }
            else
            {
                Mod.tb_codigo tabela = new Mod.tb_codigo();
                tabela.cd_verificacao = Convert.ToInt32(txtCodigo.Text);
                Business.BusinessLogin bs = new Business.BusinessLogin();
                bs.icd(tabela);
                if(MessageBox.Show("Você copiou o código?","Código de Recuperação", MessageBoxButtons.YesNo)== DialogResult.Yes) 
                    {
 
                    Telas.frmEsqueceuSenha3 tela = new frmEsqueceuSenha3();
                    tela.Show();
                    Hide();
                    }
                    else
                    {

                    }
                
                   

                }
            
            }
            catch (Exception)
            {

                MessageBox.Show("Tente mais Tarde.");
            }
        }
    }
}
