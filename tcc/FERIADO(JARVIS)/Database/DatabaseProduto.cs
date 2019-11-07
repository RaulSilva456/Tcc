using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class DatabaseProduto
    {
        Mod.db_a4fcff_tccEntities md = new Mod.db_a4fcff_tccEntities();

        public void inerir(Mod.tb_produto tabela )
        {
      


           
            md.tb_produto.Add(tabela);
         
            md.SaveChanges();
        }
        public void deletar(Mod.tb_produto tabela)
        {
            tabela = md.tb_produto.First(x => x.id_produto == tabela.id_produto);
            md.tb_produto.Remove(tabela);
            md.SaveChanges();
        }
        public void alterar (Mod.tb_produto tabela)
        {
            Mod.tb_produto altera = md.tb_produto.First(x => x.id_produto == tabela.id_produto);
            altera.nm_produto = tabela.nm_produto;
            altera.dt_entrada = tabela.dt_entrada;
            
           
            altera.nm_fornecedor = altera.nm_fornecedor;
            md.SaveChanges();
         }
        public List<Mod.tb_produto> listar()
        {
            return md.tb_produto.ToList();
        }
        public  Mod.tb_produto fornecedores(string nome)
        {
            Mod.tb_fornecedor f = new Mod.tb_fornecedor();
           Mod.tb_produto fornecedor = md.tb_produto.FirstOrDefault(x => f.nm_fornecedor == nome  );
                                                                       

            return fornecedor;
        }
        public List<Mod.tb_fornecedor> lista()
        {
            return md.tb_fornecedor.ToList();
        }
    }
}
