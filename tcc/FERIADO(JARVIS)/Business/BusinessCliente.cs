using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class BusinessCliente
    {
        Database.DatabaseCliente db = new Database.DatabaseCliente();
         public void inserir(Mod.tb_clientes tabela)
        {
            db.inserir(tabela);
        }
        public void remover(Mod.tb_clientes tabela)
        {
            db.remover(tabela);
        }
        public void alterar(Mod.tb_clientes tabela)
        {
            db.alterar(tabela);
        }
        public List<Mod.tb_clientes>consu()
        {
            return db.listar();
        }



    }
}
