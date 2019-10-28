using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class Database_Despesas
    {
        Mod.tccEntities5 md = new Mod.tccEntities5();

        public void inserir(Mod.tb_despesas tabela)
        {
            md.tb_clientes.Add(tabela);
            md.SaveChanges();

        }
    }
}
