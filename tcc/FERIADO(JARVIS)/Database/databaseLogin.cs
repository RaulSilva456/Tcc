using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class databaseLogin
    {
        Mod.tccEntities1 md = new Mod.tccEntities1();
        public bool login(string login,string senha,string email)
        {
            var md = new Mod.tccEntities1();

            var usuario = md.tb_login.FirstOrDefault(x => x.nm_nome == login && x.pes_senha == senha && x.nm_nome == email);
            if(usuario != null)
            {
                return true;
            }
            return false;
        }
        public void Cadastrar(Mod.tb_login tabela)
        {
             md.tb_login.Add(tabela);
            md.SaveChanges();
        }
    }
}
