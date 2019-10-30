using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class funcionarios_bsiness
    {
        Database.Database_Funcionarios data = new Database.Database_Funcionarios();
        public void inserirFuncionario(Mod.tb_funcionarios Tabela)
        {
            //validacoes

            if (Tabela.nm_funcionario == string.Empty)

                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    
                    throw new ArgumentException("Campo  Nome Funcionario Vazio");
           
                }
            
            if(Tabela.fun_cpf == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Cpf Vazio");
                }
            
            if(Tabela.fun_endereço == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Endereço Vazio");

                }

            if(Tabela.fun_rg == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Rg Vazio");
                }
          
            if(Tabela.fun_cargo == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Cargo Vazio");
                }
            if(Tabela.dt_nasc == DateTime.Now)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Data de Nacimento Invalida");

                }
            if(Tabela.dt_pagamento_do_funcionario < DateTime.Now)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Data De Pagamento Invalida");
                }
            if(Tabela.ad_fgts == 0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Fgts Invalido ");
                }
            if(Tabela.sl_salario == 0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Salario Invalido");
                    
                }
            
            

            

        





        data.inserirFuncionario(Tabela);
        }
        public void deleta(   Mod.tb_funcionarios tabela)
        {
            data.deleta(tabela);
            

        }
        public void alterar(Mod.tb_funcionarios Tabela)
        {
            // validacoes

            if (Tabela.nm_funcionario == string.Empty)

                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo  Nome Funcionario Vazio");

                }

            if (Tabela.fun_cpf == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Cpf Vazio");
                }

            if (Tabela.fun_endereço == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Endereço Vazio");

                }

            if (Tabela.fun_rg == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Rg Vazio");
                }

            if (Tabela.fun_cargo == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Cargo Vazio");
                }
            if (Tabela.dt_nasc == DateTime.Now)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Data de Nacimento Invalida");

                }
            if (Tabela.dt_pagamento_do_funcionario < DateTime.Now)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Data De Pagamento Invalida");
                }
            if (Tabela.ad_fgts == 0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Fgts Invalido ");
                }
            if (Tabela.sl_salario == 0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Salario Invalido");

                }


            data.alterar(Tabela);
        }
        public List<Mod.tb_funcionarios> consultarFuncionarios()
        {
          
            List<Mod.tb_funcionarios> tabela = data.consultarFuncionarios();
            return tabela;
        }
    }
}
