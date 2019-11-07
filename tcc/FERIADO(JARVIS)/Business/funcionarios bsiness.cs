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
        public void inserirFuncionario(Mod.tb_funcionario Tabela)
        {
            //validacoes

            










            data.inserirFuncionario(Tabela);
        }
        public void deleta(   Mod.tb_funcionario tabela)
        {
            data.deleta(tabela);
            

        }
        public void alterar(Mod.tb_funcionario Tabela)
        {
            // validacoes

            if (Tabela.nm_funcionario == string.Empty)

             

       







            data.alterar(Tabela);
        }
        public List<Mod.tb_funcionario> consultarFuncionarios()
        {
          
            List<Mod.tb_funcionario> tabela = data.consultarFuncionarios();
            return tabela;
        }
    }
}
