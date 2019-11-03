using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class Business_Despesas
    {
        Database.Database_Despesas db = new Database.Database_Despesas();
        public void inserir(Mod.tb_despesas tabela)
        {
            
            
            if(tabela.tp_conta == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Compra Vazio");
                }

            if (tabela.vl_valor <= 0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Valor Invalido");
                }







            db.inserir(tabela);
        }
        public void alterar (Mod.tb_despesas tabela)
        {
            //Validações 
            if (tabela.vl_valor == 0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Valor Invalido");

                }
            if (tabela.tp_conta == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo de compra Invalido");

                }



            db.alterar(tabela);
        }
        public List<Mod.tb_despesas> consultarFuncionarios()
        {

            List<Mod.tb_despesas> tabela = db.consultarDespesas();
            return tabela;
        }
        public void deletar(Mod.tb_despesas tabela)
        {
            db.deletar(tabela);


        }
    }
}
