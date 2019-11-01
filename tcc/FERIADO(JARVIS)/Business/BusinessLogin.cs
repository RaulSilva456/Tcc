using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class BusinessLogin
    {
        Database.databaseLogin db = new Database.databaseLogin();
        public void Cadastrar(Mod.tb_login tabela)
        {
            if (tabela.nm_nome == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Usuario Vazio");
                }

            if (tabela.pes_senha == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo Senha Vazio");
                }
          

            db.Cadastrar(tabela);   
        }
    }
}
