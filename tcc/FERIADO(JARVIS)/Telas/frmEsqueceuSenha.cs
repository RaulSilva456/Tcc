using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace FERIADO_JARVIS_.Telas
{
    public partial class frmEsqueceuSenha : Form
    {
        public frmEsqueceuSenha()
        {
            InitializeComponent();
        }

        private void FrmEsqueceuSenha_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            rdn.Next();
            string codigo = rdn.Next(0, 1000) + Environment.NewLine;
            string  email;
            email = txtEmailConfirmação.Text;
            string assunto = "Codigo de Verificação";
            Mod.tb_codigop tabela = new Mod.tb_codigop();
            tabela.cd_verificacao = Convert.ToInt32(codigo);
            Business.BusinessLogin bs = new Business.BusinessLogin();
            bs.icd(tabela);
            


            Objetos fub = new Objetos();
            fub.EnviarEmail(email, assunto, codigo);


           
           

            if(txtEmailConfirmação.Text == string.Empty)
            {
                MessageBox.Show("Campo vazio.");
            }

           
            Objetos fun = new Objetos();
            if (!fun.esqueceusenha(email))
            {

             MessageBox.Show("Email inválido.");

            }
          else
            {
                MessageBox.Show("Email válido Foi Enviado Um Codigo De Verificação Ao Seu Email!   Rederecionamos você para a tela de código de recuperação.");
            frmEsqueceuSenha3 r = new frmEsqueceuSenha3();
            r.Show();
            Hide();
            }

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
        public void EnviarEmail()
        {
            System.Net.Mail.MailMessage mensagem = new System.Net.Mail.MailMessage();
            mensagem.To.Add(txtEmailConfirmação.Text);

            Random randNum = new Random();
            randNum.Next();
            int numeros = randNum.Next();
            mensagem.CC.Add("raulger456@gmail.com");

            mensagem.From = new System.Net.Mail.MailAddress("raulger456@gmail.com");
            mensagem.Body="Conseguir";

            System.Net.Mail.SmtpClient smp = new System.Net.Mail.SmtpClient();

            smp.Host = "smtp.gmail.com";
            smp.Port = 587;
            smp.EnableSsl = true;
            smp.UseDefaultCredentials = false;
            smp.Credentials = new System.Net.NetworkCredential("raulger456@gmail.com", "01082002Rr");




            smp.Send(mensagem);
            MessageBox.Show("Código de verificação enviado.");
        }
    }
}
