using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class funcionarios_bsiness
    {
        public void inserirFuncionario(Mod.tb_funcionarios Tabela)
        {
            Database.Database_Funcionarios data = new Database.Database_Funcionarios();
            data.inserirFuncionario(Tabela);
        }
        public void deleta(int id)
        {
            Database.Database_Funcionarios bs = new Database.Database_Funcionarios();
            bs.deleta(id);

        }
        public void alterar(Mod.tb_funcionarios tabela)
        {
            Database.Database_Funcionarios db = new Database.Database_Funcionarios();
            db.alterar(tabela);
        }
    }
}
