using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_
{
    class Objetos
    {
        Mod.tccEntities5 md = new Mod.tccEntities5();
        public bool login(string login, string senha, string email)
        {
         

            var usuario = md.tb_login.FirstOrDefault(x => x.nm_nome == login && x.pes_senha == senha && x.nm_nome == email);
            if (usuario != null)
            {
                return true;
            }
            return false;
        }
    }
}
