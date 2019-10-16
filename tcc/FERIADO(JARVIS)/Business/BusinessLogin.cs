using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class BusinessLogin
    {
        Database.databaseLogin db = new Database.databaseLogin();
        public void Cadastrar(Mod.tb_login tabela)
        {
            db.Cadastrar(tabela);   
        }
    }
}
