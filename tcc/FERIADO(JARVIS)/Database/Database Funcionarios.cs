using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class Database_Funcionarios
    {Mod.db_a4fd25_pppEntities1 mod = new Mod.db_a4fd25_pppEntities1();
        public void inserirFuncionario(Mod.tb_funcionariosp tabela)
        {
        
            mod.tb_funcionariosp.Add(tabela);
            mod.SaveChanges();
        }
        public void deleta(Mod.tb_funcionariosp tabelas)
        {
            
            tabelas = mod.tb_funcionariosp.First(x => x.id_funcionario == tabelas.id_funcionario);
            mod.tb_funcionariosp.Remove(tabelas);
            mod.SaveChanges();

        }
        public void alterar(Mod.tb_funcionariosp tabela)
        {
            Mod.tb_funcionariosp alterar = mod.tb_funcionariosp.First(t => t.id_funcionario == tabela.id_funcionario);
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
        public List<Mod.tb_funcionariosp> consultarFuncionarios()
        {
            

         return   mod.tb_funcionariosp.ToList();
            
        }
    }
}
