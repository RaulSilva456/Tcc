using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class Estoque_Business
    {
        Database.Estoque_Database db = new Database.Estoque_Database();
        public void inserir(Mod.tb_estoque tabela)
        {
            db.inserir(tabela);
        }
        public void remover(Mod.tb_estoque tabela)
        {
            db.remover(tabela);
          
        }
        public void alterar(Mod.tb_estoque tabela)
        {
            db.alterar(tabela);
            
        }
        public List<Mod.tb_estoque> listar()
        {
            return db.listar();
        }
    }
}
