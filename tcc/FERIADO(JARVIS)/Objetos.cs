using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_
{
    class Objetos
    {
        Mod.db_a4fcff_tccEntities md = new Mod.db_a4fcff_tccEntities();
        public bool login(string login, string senha, string email)
        {
         

            var usuario = md.tb_login.FirstOrDefault(x =>( x.nm_nome == login || x.pes_email == email) && x.pes_senha == senha );
            if (usuario != null)
            {
                return true;
            }
            return false;
        }
        public bool esqueceusenha(string email)
        {

            var usuario = md.tb_login.FirstOrDefault(x => x.pes_email == email);
            if (usuario != null)
            {
                return true;
            }
            return false;
        }
        public bool cod(int codigo)
        {
            var tabela = md.tb_codigo.FirstOrDefault(x => x.cd_verificacao == codigo);
          
            if (tabela != null)
            {
                return true;
            }
            return false;

        }
        public bool usuario(string usuario)
        {
            var tabela = md.tb_login.FirstOrDefault(x => x.nm_nome == usuario);

            if (tabela != null)
            {
                return true;
            }
            return false;

        }
        public void EnviarEmail(string emailPara, string assunto, string mensagem)
        {
            Task.Factory.StartNew(() =>
            {
                System.Net.Mail.MailMessage email = new System.Net.Mail.MailMessage();

                string remetente = "raulger456@gmail.com";
                string senha = "01082002Rr";

                // Configura Remetente, Destinatário
                email.From = new System.Net.Mail.MailAddress(remetente);
                email.To.Add(emailPara);

                // Configura Assunto, Corpo e se o Corpo está em Html
                email.Subject = assunto;
                email.Body = mensagem;
                email.IsBodyHtml = true;

                // Configura os parâmetros do objeto SMTP
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                // Atribui credenciais
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(remetente, senha);

                // Envia a mensagem
                smtp.Send(email);


            });
        }
    }
}
