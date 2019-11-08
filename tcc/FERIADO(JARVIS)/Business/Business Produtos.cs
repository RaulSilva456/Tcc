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
        public void inerir(Mod.tb_produtop tabela)
        {

            if(tabela.cat_categoria == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Categoria Vazio");
                }

            if (tabela.nm_produto == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Nome produto Vazio");
                }

            if (tabela.sb_sabor == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Sabor Vazio");
                }

            





            db.inerir(tabela);
        }
        public void deletar(Mod.tb_produtop tabela)
        {
            db.deletar(tabela);
        }
        public void alterar(Mod.tb_produtop tabela)

        {
            if (tabela.cat_categoria == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Categoria Vazio");
                }

            if (tabela.nm_produto == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Nome produto Vazio");
                }

            if (tabela.sb_sabor == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Sabor Vazio");
                }

            db.alterar(tabela);
           
        }
        public List<Mod.tb_produtop> listar()
        {
            return db.listar();
        }
        public Mod.tb_produtop fornecedor(string nome)
        {
          return  db.fornecedores(nome);
        }
        public List<Mod.tb_fornecedorp> listarF()
        {
            return db.lista();
        }
    }
}
