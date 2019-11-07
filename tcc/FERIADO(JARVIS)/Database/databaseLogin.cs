using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class databaseLogin
    {
        Mod.db_a4fcff_tccEntities md = new Mod.db_a4fcff_tccEntities();

        public void Cadastrar(Mod.tb_login tabela)
        {






            md.tb_login.Add(tabela);
            md.SaveChanges();
        }
        public void alterar(Mod.tb_login tabela)
        {
            Mod.tb_login altearar = md.tb_login.FirstOrDefault(x => x.nm_nome == tabela.nm_nome);
            altearar.pes_senha = tabela.pes_senha;
            md.SaveChanges();


        }
       
        public void remover(Mod.tb_codigo tb)
        {
           var deleteCommand = md.Database.Connection.CreateCommand();
            deleteCommand.CommandText = "DELETE FROM tb_codigo";
            md.Database.Connection.Open();

            deleteCommand.ExecuteNonQuery();

            md.Database.Connection.Close();

        }
        public void icd(Mod.tb_codigo tabela )
        {
            md.tb_codigo.Add(tabela);
            md.SaveChanges();
        }
    }
}
