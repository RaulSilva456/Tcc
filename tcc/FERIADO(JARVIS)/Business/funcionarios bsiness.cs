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
            
            data.inserirFuncionario(Tabela);
        }
        public void deleta(   Mod.tb_funcionarios tabela)
        {
            data.deleta(tabela);
            

        }
        public void alterar(Mod.tb_funcionarios tabela)
        {
            Database.Database_Funcionarios db = new Database.Database_Funcionarios();
            db.alterar(tabela);
        }
    }
}
