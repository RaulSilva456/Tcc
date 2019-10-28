using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class Estoque_Database
    {
        Mod.tccEntities10 md = new Mod.tccEntities10();

        public void inserir(Mod.tb_estoque tabela)
        {
            md.tb_estoque.Add(tabela);
            md.SaveChanges();
        }
        public void remover(Mod.tb_estoque tabela)
        {
           tabela= md.tb_estoque.First(x => x.id_produto == tabela.id_produto);
            md.tb_estoque.Remove(tabela);
            md.SaveChanges();
        }
        public void alterar(Mod.tb_estoque tabela)
        {
           
                
            Mod.tb_estoque altear = md.tb_estoque.FirstOrDefault(x => x.id_produto == tabela.id_produto);
            altear.nm_produto = tabela.nm_produto;
            altear.pr_preco = tabela.pr_preco;
            altear.dt_saida_do_produto = tabela.dt_saida_do_produto ;
            altear.qtd_quantidade_do_produto = tabela.qtd_quantidade_do_produto;
            altear.pro_vencido = altear.pro_vencido;
           

            md.SaveChanges();

       
        }
        public List<Mod.tb_estoque> listar()
        {
            return md.tb_estoque.ToList();
        }
    }
}
