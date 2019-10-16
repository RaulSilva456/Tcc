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
            Mod.tccEntities1 mod = new Mod.tccEntities1();
            mod.tb_funcionarios.Add(tabela);
            mod.SaveChanges();
        }
        public void deleta(Mod.tb_funcionarios tabelas)
        {
            Mod.tccEntities1 mod = new Mod.tccEntities1();
            Mod.tb_funcionarios tabela = mod.tb_funcionarios.First(x => x.id_funcionario == tabelas.id_funcionario);
            mod.tb_funcionarios.Remove(tabela);
            mod.SaveChanges();

        }
        public void alterar(Mod.tb_funcionarios tabela)
        {
            Mod.tccEntities1 MOD = new Mod.tccEntities1();
            Mod.tb_funcionarios alterar = MOD.tb_funcionarios.First(t => t.id_funcionario == tabela.id_funcionario);
            alterar.nm_funcionario = tabela.nm_funcionario;
            alterar.sl_salario = tabela.sl_salario;
            alterar.fun_rg = tabela.fun_rg;
            alterar.fun_endereço = tabela.fun_endereço;
            alterar.fun_cpf = tabela.fun_cpf;
            alterar.dt_data_de_contratacao = tabela.dt_data_de_contratacao;
            alterar.ad_fgts = tabela.ad_fgts;
            MOD.SaveChanges();


        }
    }
}
