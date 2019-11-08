using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class Business_Folha_de_Pagamento
    {
        Database.Database_FolhaDePagamento_ dt = new Database.Database_FolhaDePagamento_();
        public void inserir(Mod.tb_folhapagamentop tabela)
        {

           


          
            if (tabela.dt_pagamento < DateTime.Now)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {


                    throw new ArgumentException("Data inválida.");
                }

            
            if (tabela.nm_funcionario == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Nome Funcionario Invalido");
                }


































































            dt.inserir(tabela);
        }
        public void remover(Mod.tb_folhapagamentop tabela)
        {
            dt.remover(tabela);
        }
        public void alterar(Mod.tb_folhapagamentop tabela)
        {


            if (tabela.dt_pagamento < DateTime.Now)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {


                    throw new ArgumentException("Data inválida.");
                }


            if (tabela.nm_funcionario == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Nome Funcionario Invalido");
                }



            dt.alterar(tabela);


        }
        public List<Mod.tb_folhapagamentop> listar()
        {
          return  dt.listar();
        }

    }
}
