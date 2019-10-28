using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class Database_Despesas
    {
        Mod.tccEntities10 md = new Mod.tccEntities10();

        public void inserir(Mod.tb_despesas tabela)
        {
            md.tb_despesas.Add(tabela);
            md.SaveChanges();

        }
    }
}
