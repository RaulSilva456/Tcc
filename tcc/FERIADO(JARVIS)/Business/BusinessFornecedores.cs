using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class BusinessFornecedores
    {
        Database.DatabaseFornecedores db = new Database.DatabaseFornecedores();
        public void inserir(Mod.tb_fornecedores tabela)
        {
            db.inserir(tabela);
          
        }
        public void deletar(Mod.tb_fornecedores tabela)
        {
            db.deletar(tabela);

        }
        public void alterar(Mod.tb_fornecedores tabela)
        {
            db.alterar(tabela);




        }
        public List<Mod.tb_fornecedores> listar()
        {
           return  db.listar();

        }
    }
}
