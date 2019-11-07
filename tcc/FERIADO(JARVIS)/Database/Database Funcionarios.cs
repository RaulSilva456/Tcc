using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class Database_Funcionarios
    {Mod.db_a4fcff_tccEntities mod = new Mod.db_a4fcff_tccEntities();
        public void inserirFuncionario(Mod.tb_funcionario tabela)
        {
        
            mod.tb_funcionario.Add(tabela);
            mod.SaveChanges();
        }
        public void deleta(Mod.tb_funcionario tabelas)
        {
            
            tabelas = mod.tb_funcionario.First(x => x.id_funcionario == tabelas.id_funcionario);
            mod.tb_funcionario.Remove(tabelas);
            mod.SaveChanges();

        }
        public void alterar(Mod.tb_funcionario tabela)
        {
            Mod.tb_funcionario alterar = mod.tb_funcionario.First(t => t.id_funcionario == tabela.id_funcionario);
            alterar.nm_funcionario = tabela.nm_funcionario;
            alterar.sl_salario = tabela.sl_salario;
            alterar.fc_rg = tabela.fc_rg;
            alterar.fc_endereço = tabela.fc_endereço;
            alterar.fc_cpf = tabela.fc_cpf;
            alterar.dt_data_de_contratacao = tabela.dt_data_de_contratacao;
            alterar.sl_salario_familia = tabela.sl_salario_familia;
            alterar.nm_dependentes = tabela.nm_dependentes;
            alterar.dt_pagamento = tabela.dt_pagamento;
            alterar.fc_cargo = tabela.fc_cargo;
            alterar.fc_telefone = tabela.fc_telefone;
            alterar.nm_responsavel = tabela.nm_responsavel;
            alterar.dp_idade = tabela.dp_idade;
            alterar.dt_nasc = tabela.dt_nasc;
            
          
            mod.SaveChanges();


        }
        public List<Mod.tb_funcionario> consultarFuncionarios()
        {
            

         return   mod.tb_funcionario.ToList();
            
        }
    }
}
