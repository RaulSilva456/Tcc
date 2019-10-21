using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class DatabaseProduto
    {
        Mod.tccEntities3 md = new Mod.tccEntities3();

        public void inerir(Mod.tb_produto tabela)
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
            altera.sb_sabor = tabela.sb_sabor;
            altera.cat_categoria = tabela.cat_categoria;
            md.SaveChanges();
         }
        public List<Mod.tb_produto> listar()
        {
            return md.tb_produto.ToList();
        }
    }
}
