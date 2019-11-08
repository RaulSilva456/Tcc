using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class Database_Despesas
    {
        Mod.db_a4fd25_pppEntities1 md = new Mod.db_a4fd25_pppEntities1();

        public void inserir(Mod.tb_despesap tabela)
        {
            md.tb_despesap.Add(tabela);
            md.SaveChanges();

        }
        public void alterar(Mod.tb_despesap tabela)
        {
            Mod.tb_despesap alterar = md.tb_despesap.First(t => t.id_despesas == tabela.id_despesas);
            alterar.tp_conta = tabela.tp_conta;
            alterar.dt_data_pagamento = tabela.dt_data_pagamento;
            alterar.vl_valor = tabela.vl_valor;
        
            md.SaveChanges();


        }
        public void deletar(Mod.tb_despesap tabelas)
        {

            tabelas = md.tb_despesap.First(x => x.id_despesas == tabelas.id_despesas);
            md.tb_despesap.Remove(tabelas);
            md.SaveChanges();

        }
        public List<Mod.tb_despesap> consultarDespesas()
        {


            return md.tb_despesap.ToList();
        }
    }
}
