using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class Business_Despesas
    {
        Database.DataBaseDespesas db = new Database.DataBaseDespesas();
        public void inserir(Mod.tb_despesas tabela)
        {
            if(tabela.dt_data_pagamento < DateTime.Now)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Data Invalida No Campo Dia de Compra");
                }

            
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







            db.inseir(tabela);
        }
    }
}
