using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class consultas
    {
        public List<Mod.tb_funcionarios> consultarFuncionarios()
        {
            Database.Consultas_Em_Geral bs = new Database.Consultas_Em_Geral();
            List<Mod.tb_funcionarios> tabela = bs.consultarFuncionarios();
            return tabela;
        }
    }
}
