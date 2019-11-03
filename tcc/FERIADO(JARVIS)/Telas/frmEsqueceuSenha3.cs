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
    public partial class frmEsqueceuSenha3 : Form
    {
        public frmEsqueceuSenha3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
             {
            Database.databaseLogin db = new Database.databaseLogin();
                Business.BusinessLogin bs = new Business.BusinessLogin();
                int codigo = Convert.ToInt32(txtcodigo.Text);
                Mod.tb_codigo tabela = new Mod.tb_codigo();
                tabela.cd_verificacao = Convert.ToInt32(txtcodigo.Text);

                tabela.cd_verificacao = Convert.ToInt32(txtcodigo.Text);



                if (txtcodigo.Text == string.Empty)
                {
                    MessageBox.Show("Campo codigo vazio");
                }
                else
                {
                    Objetos fun = new Objetos();
                    if (!fun.cod(codigo))
                    {
                        MessageBox.Show("codigo Invalido ");

                    }
                    else

                    {
                        MessageBox.Show("codigo Esta correto Pode Proseguir Nos Campos Abaixo ");

                        db.remover(tabela);
                    txtUsuario.Enabled = true;
                    txtConfirmarSenha.Enabled = true;
                    txtNovaSenha.Enabled = true;
                    txtcodigo.Enabled = false;

                    }

                }
           }
           catch (Exception)
            {

                MessageBox.Show("Erro Nao Pode Conter Letras No Campo De Codigos Ou Pode Estar Vazio o Campo");
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string usurario = txtUsuario.Text;
                Mod.tb_login tabelea = new Mod.tb_login();
                tabelea.nm_nome = txtUsuario.Text;
                tabelea.pes_senha = txtNovaSenha.Text;

                Objetos fun = new Objetos();
                if (!fun.usuario(usurario))
                {
                    MessageBox.Show("Usuario Invalido ");

                }
                else
                {
                    if (txtConfirmarSenha.Text == txtNovaSenha.Text)
                    {
                        Business.BusinessLogin bs = new Business.BusinessLogin();
                        bs.alterar(tabelea);
                        MessageBox.Show("Senha Nova Alterada Com Sucesso");
                        Telas.frmLogin tela = new frmLogin();
                        tela.Show();
                        Hide();


                    }
                    else
                    {
                        MessageBox.Show("Senha Nao Estão iguais");
                    }



                }
            }
            catch (Exception)
            {

                MessageBox.Show("Campos Vazios");
            }
            
            

            

           
        }
    }


        
        












    }
          

           
           
        

        
    

