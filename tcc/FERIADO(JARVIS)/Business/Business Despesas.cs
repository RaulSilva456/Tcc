using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class Business_Despesas
    {
        Database.DatabaseCliente db = new Database.DatabaseCliente();
        public void inserir(Mod.tb_despesas tabela)
        {
            db.inserir(tabela);
        }
    }
}
