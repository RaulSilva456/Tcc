using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class Business_Despesas
    {
        Database.DataBaseDespesas db = new Database.DataBaseDespesas();
        public void inserir(Mod.tb_despesas tabela)
        {
            db.inseir(tabela);
        }
    }
}
