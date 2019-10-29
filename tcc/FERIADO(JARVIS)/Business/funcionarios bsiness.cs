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
            if (Tabela.nm_funcionario == string.Empty)

                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    throw new ArgumentException("Naoaoo");
                }
        





        data.inserirFuncionario(Tabela);
        }
        public void deleta(   Mod.tb_funcionarios tabela)
        {
            data.deleta(tabela);
            

        }
        public void alterar(Mod.tb_funcionarios tabela)
        {
           
            data.alterar(tabela);
        }
        public List<Mod.tb_funcionarios> consultarFuncionarios()
        {
          
            List<Mod.tb_funcionarios> tabela = data.consultarFuncionarios();
            return tabela;
        }
    }
}
