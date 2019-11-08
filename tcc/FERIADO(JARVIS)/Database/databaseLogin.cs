using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class databaseLogin
    {
        Mod.db_a4fd25_pppEntities1 md = new Mod.db_a4fd25_pppEntities1();

        public void Cadastrar(Mod.tb_loginp tabela)
        {






            md.tb_loginp.Add(tabela);
            md.SaveChanges();
        }
        public void alterar(Mod.tb_loginp tabela)
        {
            Mod.tb_loginp altearar = md.tb_loginp.FirstOrDefault(x => x.nm_nome == tabela.nm_nome);
            altearar.pes_senha = tabela.pes_senha;
            md.SaveChanges();


        }
       
        public void remover(Mod.tb_codigop tb)
        {
           var deleteCommand = md.Database.Connection.CreateCommand();
            deleteCommand.CommandText = "DELETE FROM tb_codigop";
            md.Database.Connection.Open();

            deleteCommand.ExecuteNonQuery();

            md.Database.Connection.Close();

        }
        public void icd(Mod.tb_codigop tabela )
        {
            md.tb_codigop.Add(tabela);
            md.SaveChanges();
        }
    }
}
