using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class DatabaseProduto
    {
        Mod.db_a4fd25_pppEntities1 md = new Mod.db_a4fd25_pppEntities1();

        public void inerir(Mod.tb_produtop tabela )
        {
            


           
            md.tb_produtop.Add(tabela);
         
            md.SaveChanges();
        }
        public void deletar(Mod.tb_produtop tabela)
        {
            tabela = md.tb_produtop.First(x => x.id_produto == tabela.id_produto);
            md.tb_produtop.Remove(tabela);
            md.SaveChanges();
        }
        public void alterar (Mod.tb_produtop tabela)
        {
            Mod.tb_produtop altera = md.tb_produtop.First(x => x.id_produto == tabela.id_produto);
            altera.nm_produto = tabela.nm_produto;
            altera.sb_sabor = tabela.sb_sabor;
            altera.cat_categoria = tabela.cat_categoria;
            altera.nm_fornecedor_produto = tabela.nm_fornecedor_produto;
            md.SaveChanges();
         }
        public List<Mod.tb_produtop> listar()
        {
            return md.tb_produtop.ToList();
        }
        public  Mod.tb_produtop fornecedores(string nome)
        {
            Mod.tb_fornecedorp f = new Mod.tb_fornecedorp();
           Mod.tb_produtop fornecedor = md.tb_produtop.FirstOrDefault(x => f.nm_fornecedor == nome  );
                                                                       

            return fornecedor;
        }
        public List<Mod.tb_fornecedorp> lista()
        {
            return md.tb_fornecedorp.ToList();
        }
    }
}
