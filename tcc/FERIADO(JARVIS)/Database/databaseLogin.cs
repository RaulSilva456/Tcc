using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class databaseLogin
    {
        Mod.tccEntities10 md = new Mod.tccEntities10();
        
        public void Cadastrar(Mod.tb_login tabela)
        {
          





            md.tb_login.Add(tabela);
            md.SaveChanges();
        }
    }
}
