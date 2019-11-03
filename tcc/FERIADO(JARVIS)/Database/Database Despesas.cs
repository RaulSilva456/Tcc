using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class Database_Despesas
    {
        Mod.tccEntities10 md = new Mod.tccEntities10();

        public void inserir(Mod.tb_despesas tabela)
        {
            md.tb_despesas.Add(tabela);
            md.SaveChanges();

        }
        public void alterar(Mod.tb_despesas tabela)
        {
            Mod.tb_despesas alterar = md.tb_despesas.First(t => t.id_despesas == tabela.id_despesas);
            alterar.tp_conta = tabela.tp_conta;
            alterar.dt_data_pagamento = tabela.dt_data_pagamento;
            alterar.vl_valor = tabela.vl_valor;
        
            md.SaveChanges();


        }
        public void deletar(Mod.tb_despesas tabelas)
        {

            tabelas = md.tb_despesas.First(x => x.id_despesas == tabelas.id_despesas);
            md.tb_despesas.Remove(tabelas);
            md.SaveChanges();

        }
        public List<Mod.tb_despesas> consultarDespesas()
        {


            return md.tb_despesas.ToList();
        }
    }
}
