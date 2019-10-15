using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class Consultas_Em_Geral
    {
        public List<Mod.tb_funcionarios>consultarFuncionarios()
        {
            Mod.tccEntities1 mod = new Mod.tccEntities1();

            List<Mod.tb_funcionarios> tabela = mod.tb_funcionarios.ToList();
            return tabela;
        }
    }
}
