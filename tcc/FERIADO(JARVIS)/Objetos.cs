using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_
{
    class Objetos
    {
        Mod.tccEntities10 md = new Mod.tccEntities10();
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
    }
}
