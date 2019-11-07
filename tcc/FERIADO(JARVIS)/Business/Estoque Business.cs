﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FERIADO_JARVIS_.Business
{
    class Estoque_Business
    {
        Database.Estoque_Database db = new Database.Estoque_Database();
        public void inserir(Mod.tb_estoque tabela)
        {   
            if (tabela.dt_saida<= DateTime.Now)
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

            if (tabela.qtd_produto <= 0)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Quantidade De Produto Invalida");
                }
























            db.inserir(tabela);
        }
        public void remover(Mod.tb_estoque tabela)
        {
            db.remover(tabela);
          
        }
        public void alterar(Mod.tb_estoque tabela)
        {
            if (tabela.dt_saida <= DateTime.Now)
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

            if (tabela.qtd_produto <= 0)
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
        public List<Mod.tb_estoque> listar()
        {
            return db.listar();
        }
    }
}
