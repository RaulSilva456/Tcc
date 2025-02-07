﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class Database_FolhaDePagamento_
    {
        Mod.db_a4fd25_pppEntities1 md = new Mod.db_a4fd25_pppEntities1();
        public void inserir(Mod.tb_folhapagamentop tabela)
        {
            md.tb_folhapagamentop.Add(tabela);
            md.SaveChanges();
        }
        public void remover(Mod.tb_folhapagamentop tabela)
        {
           tabela = md.tb_folhapagamentop.First(x => x.id_folha_pagamento == tabela.id_folha_pagamento);
            md.tb_folhapagamentop.Remove(tabela);
            md.SaveChanges();
        }
        public void alterar (Mod.tb_folhapagamentop tabela)
        {
         Mod.tb_folhapagamentop   altera = md.tb_folhapagamentop.First(x => x.id_folha_pagamento == tabela.id_folha_pagamento);
            altera.ad_gratificação = tabela.ad_gratificação;
            altera.ds_faltas = tabela.ds_faltas;
            altera.ds_inss = tabela.ds_inss;
            altera.dt_pagamento = tabela.dt_pagamento;
            altera.hora_extra = tabela.hora_extra;
            altera.imposto_renda = tabela.imposto_renda;
            altera.sl_salario_bruto = tabela.sl_salario_bruto;
            altera.sl_salario_liquido = tabela.sl_salario_liquido;
            altera.vl_alimentação = tabela.vl_alimentação;
            altera.vl_transporte = tabela.vl_transporte;
            altera.nm_funcionario = tabela.nm_funcionario;
            md.SaveChanges();


        }
        public List<Mod.tb_folhapagamentop>listar()
        {
            return md.tb_folhapagamentop.ToList();
        }











    }
}
