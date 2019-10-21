using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class Business_Produtos
    {
        Database.DatabaseProduto db = new Database.DatabaseProduto();
        public void inerir(Mod.tb_produto tabela)
        {
            db.inerir(tabela);
        }
        public void deletar(Mod.tb_produto tabela)
        {
            db.deletar(tabela);
        }
        public void alterar(Mod.tb_produto tabela)
        {
            db.alterar(tabela);
           
        }
        public List<Mod.tb_produto> listar()
        {
            return db.listar();
        }
        public Mod.tb_produto fornecedor(string nome)
        {
          return  db.fornecedores(nome);
        }
        public List<Mod.tb_fornecedores> listarF()
        {
            return db.lista();
        }
    }
}
