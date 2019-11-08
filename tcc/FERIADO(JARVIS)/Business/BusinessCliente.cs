using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class BusinessCliente
    {
        Database.DatabaseCliente db = new Database.DatabaseCliente();
         public void inserir(Mod.tb_clientep tabela)
        {
            if(tabela.doc_cep ==string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Do Cep Vazio");
                }



            if (tabela.doc_rg == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Do Rg Vazio");
                }


            if (tabela.end_endereco == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Do Endereço Vazio");
                }
           
            
            if (tabela.nm_nome == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Do Nome do Cliente Vazio");
                }


           

            


            
                
         
            if(tabela.tel_telefone == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Do Telefone Vazio");
                }
          





            db.inserir(tabela);
        }
        public void remover(Mod.tb_clientep tabela)
        {
            db.remover(tabela);
        }
        public void alterar(Mod.tb_clientep tabela)
        {
            if (tabela.doc_cep == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Do Cep Vazio");
                }



            if (tabela.doc_rg == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Do Rg Vazio");
                }


            if (tabela.end_endereco == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Do Endereço Vazio");
                }


            if (tabela.nm_nome == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Do Nome do Cliente Vazio");
                }










            if (tabela.tel_telefone == string.Empty)
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Do Telefone Vazio");
                }


            db.alterar(tabela);
        }
        public List<Mod.tb_clientep>consu()
        {
            return db.listar();
        }



    }
}
