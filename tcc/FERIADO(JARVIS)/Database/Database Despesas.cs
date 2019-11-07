using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class Database_Despesas
    {
        Mod.db_a4fcff_tccEntities md = new Mod.db_a4fcff_tccEntities();

        public void inserir(Mod.tb_despesa tabela)
        {
            md.tb_despesa.Add(tabela);
            md.SaveChanges();

        }
        public void alterar(Mod.tb_despesa tabela)
        {
            Mod.tb_despesa alterar = md.tb_despesa.First(t => t.id_despesa == tabela.id_despesa);
            alterar.tp_conta = tabela.tp_conta;
            alterar.dt_data_pagamento = tabela.dt_data_pagamento;
            alterar.vl_valor = tabela.vl_valor;
        
            md.SaveChanges();


        }
        public void deletar(Mod.tb_despesa tabelas)
        {

            tabelas = md.tb_despesa.First(x => x.id_despesa == tabelas.id_despesa);
            md.tb_despesa.Remove(tabelas);
            md.SaveChanges();

        }
        public List<Mod.tb_despesa> consultarDespesas()
        {


            return md.tb_despesa.ToList();
        }
    }
}
