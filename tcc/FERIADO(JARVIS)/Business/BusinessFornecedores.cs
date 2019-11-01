﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class BusinessFornecedores
    {
        Database.DatabaseFornecedores db = new Database.DatabaseFornecedores();
        public void inserir(Mod.tb_fornecedores tabela)
        {
            if(tabela.fr_cep == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Cep Vazio");
                }


            if (tabela.fr_cnpj == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Cnpj Vazio");
                }

            if (tabela.dt_entrada_do_produto <DateTime.Now)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Data Invalida");
                }

            if (tabela.end_endereço == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("endereço Invalido");
                }

            if (tabela.nm_fornecedor == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Nome Do Fornecedor Vazio");
                }

            if (tabela.tl_telefone == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Telefone Vazio");
                }

            if (tabela.vl_valor_produto <= 0)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Valor Produto Invalido ");
                }

            














            db.inserir(tabela);
          
        }
        public void deletar(Mod.tb_fornecedores tabela)
        {
            db.deletar(tabela);

        }
        public void alterar(Mod.tb_fornecedores tabela)
        {
            if (tabela.fr_cep == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Cep Vazio");
                }


            if (tabela.fr_cnpj == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Cnpj Vazio");
                }

            if (tabela.dt_entrada_do_produto < DateTime.Now)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Data Invalida");
                }

            if (tabela.end_endereço == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("endereço Invalido");
                }

            if (tabela.nm_fornecedor == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Nome Do Fornecedor Vazio");
                }

            if (tabela.tl_telefone == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Telefone Vazio");
                }

            if (tabela.vl_valor_produto < 0)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Valor Produto Invalido ");
                }
            db.alterar(tabela);




        }
        public List<Mod.tb_fornecedores> listar()
        {
           return  db.listar();

        }
    }
}
