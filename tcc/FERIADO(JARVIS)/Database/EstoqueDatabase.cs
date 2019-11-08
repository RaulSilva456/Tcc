using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class Estoque_Database
    {
        Mod.db_a4fd25_pppEntities1 md = new Mod.db_a4fd25_pppEntities1();

        public void inserir(Mod.tb_estoquep tabela)
        {
           
            md.tb_estoquep.Add(tabela);
            md.SaveChanges();
        }
        public void remover(Mod.tb_estoquep tabela)
        {
           tabela= md.tb_estoquep.First(x => x.id_produto == tabela.id_produto);
            md.tb_estoquep.Remove(tabela);
            md.SaveChanges();
        }
        public void alterar(Mod.tb_estoquep tabela)
        {
           
                
            Mod.tb_estoquep altear = md.tb_estoquep.First(x => x.id_produto == tabela.id_produto);
            altear.nm_produto = tabela.nm_produto;
            altear.pr_preco = tabela.pr_preco;
            altear.dt_saida_do_produto = tabela.dt_saida_do_produto ;
            altear.qtd_quantidade_do_produto = tabela.qtd_quantidade_do_produto;
            altear.pro_vencido = tabela.pro_vencido;
            
           
           

            md.SaveChanges();

       
        }
        public List<Mod.tb_estoquep> listar()
        {
            return md.tb_estoquep.ToList();
        }
    }
}
