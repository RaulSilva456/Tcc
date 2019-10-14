using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class Database_Funcionarios
    {
        public void inserirFuncionario(Mod.tb_funcionarios tabela)
        {
            Mod.tccEntities mod = new Mod.tccEntities();
            mod.tb_funcionarios.Add(tabela);
            mod.SaveChanges();
        }
        public void deleta (int id)
        {
            Mod.tccEntities mod = new Mod.tccEntities();
            Mod.tb_funcionarios tabela = mod.tb_funcionarios.First(x => x.id_funcionario == id);
            mod.tb_funcionarios.Remove(tabela);
            mod.SaveChanges();

        }
    }
}
