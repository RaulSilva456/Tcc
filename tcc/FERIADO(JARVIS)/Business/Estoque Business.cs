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
        public void inserir(Mod.tb_estoquep tabela)
        {
            if (tabela.dt_saida_do_produto <= DateTime.Now)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Data de Saida de Produto Invalida");
                }

            if (tabela.nm_produto == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo nome Produto Vazio");
                }


          
          
            




















            db.inserir(tabela);
        }
        public void remover(Mod.tb_estoquep tabela)
        {
            db.remover(tabela);
          
        }
        public void alterar(Mod.tb_estoquep tabela)
        {
            if (tabela.dt_saida_do_produto <= DateTime.Now)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Data de Saida de Produto Invalida");
                }

            if (tabela.nm_produto == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo nome Produto Vazio");
                }



            if (tabela.pr_preco <= 0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Preço Invalido");
                }

            if (tabela.qtd_quantidade_do_produto <= 0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Quantidade De Produto Invalida");
                }



            db.alterar(tabela);
            
        }
        public List<Mod.tb_estoquep> listar()
        {
            return db.listar();
        }
    }
}
