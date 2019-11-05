using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class BusinessMostruario
    {

        Database.DatabaseMostruario db = new Database.DatabaseMostruario();
        public void deletar(Mod.tb_mostruario tabela)
        {

           

















            db.deletar(tabela);
        }
        public void inserir(Mod.tb_mostruario tabela)
        {
            if (tabela.cat_categoria == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo de categoria vazio.");
                }

            if (tabela.nm_fornecedor_produto == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo de Nome Fornecedor vazio.");
                }



            if (tabela.nm_produtomostruario == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo de Produto Monstruario vazio.");
                }

            if (tabela.sb_sabor == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo de Sabor vazio.");
                }
            db.inserir(tabela);
           
        }
        public List<Mod.tb_mostruario> lista()
        {
            return db.lista();
        }
    }
}
