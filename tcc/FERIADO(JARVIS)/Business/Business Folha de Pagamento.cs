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
        public void inserir(Mod.tb_folhapagamento tabela)
        {

           


          
            if (tabela.dt_pagamento < DateTime.Now)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Data Invalida");
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


            if (tabela.sl_salario_bruto <=0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Salario Bruto Invalido");
                }


            if (tabela.sl_salario_liquido <= 0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Salario liquido Invalido");
                }

            if (tabela.vl_alimentação <= 0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Vale Alimentação Invalido");
                }


            if (tabela.vl_transporte <= 0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Vale Tranporte Invalido");
                }
            if (tabela.ad_gratificação <=   0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Gratificação Invalido");
                }
            if (tabela.imposto_renda <= 0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo imposto de Renda Invalido");
                }
            if (tabela.ds_inss <= 0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo  INSS Invalido");
                }
         
































































            dt.inserir(tabela);
        }
        public void remover(Mod.tb_folhapagamento tabela)
        {
            dt.remover(tabela);
        }
        public void alterar(Mod.tb_folhapagamento tabela)
        {
            dt.alterar(tabela);


        }
        public List<Mod.tb_folhapagamento> listar()
        {
          return  dt.listar();
        }

    }
}
