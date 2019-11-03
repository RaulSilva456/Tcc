using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class Database_Funcionarios
    {Mod.tccEntities10 mod = new Mod.tccEntities10();
        public void inserirFuncionario(Mod.tb_funcionarios tabela)
        {
        
            mod.tb_funcionarios.Add(tabela);
            mod.SaveChanges();
        }
        public void deleta(Mod.tb_funcionarios tabelas)
        {
            
            tabelas = mod.tb_funcionarios.First(x => x.id_funcionario == tabelas.id_funcionario);
            mod.tb_funcionarios.Remove(tabelas);
            mod.SaveChanges();

        }
        public void alterar(Mod.tb_funcionarios tabela)
        {
            Mod.tb_funcionarios alterar = mod.tb_funcionarios.First(t => t.id_funcionario == tabela.id_funcionario);
            alterar.nm_funcionario = tabela.nm_funcionario;
            alterar.sl_salario = tabela.sl_salario;
            alterar.fun_rg = tabela.fun_rg;
            alterar.fun_endereço = tabela.fun_endereço;
            alterar.fun_cpf = tabela.fun_cpf;
            alterar.dt_data_de_contratacao = tabela.dt_data_de_contratacao;
            alterar.ad_fgts = tabela.ad_fgts;
            alterar.fun_cargo = tabela.fun_cargo;
            alterar.dt_pagamento_do_funcionario = tabela.dt_pagamento_do_funcionario;
          
            mod.SaveChanges();


        }
        public List<Mod.tb_funcionarios> consultarFuncionarios()
        {
            

         return   mod.tb_funcionarios.ToList();
            
        }
    }
}
