﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class DatabasePedidoCliente
    {
        Mod.db_a4fd25_pppEntities1 md = new Mod.db_a4fd25_pppEntities1();
        

       public void inseri(Mod.tb_pedido_clientep tabela )
        {
            md.tb_pedido_clientep.Add(tabela);
            md.SaveChanges();
        }
        public void deletar(Mod.tb_pedido_clientep tabela)
        {
            tabela = md.tb_pedido_clientep.First(x => x.id_pedido == tabela.id_pedido);
            md.tb_pedido_clientep.Remove(tabela);
            md.SaveChanges();

        }
        public void alterar(Mod.tb_pedido_clientep tabela)
        {
            Mod.tb_pedido_clientep altera = md.tb_pedido_clientep.FirstOrDefault(x => x.id_pedido == tabela.id_pedido);
            altera.nm_produto_cliente = tabela.nm_produto_cliente;
            altera.qtd_quantidade = tabela.qtd_quantidade;
            altera.nm_produto_cliente = tabela.nm_produto_cliente;
            md.SaveChanges();
        }
        public List<Mod.tb_pedido_clientep>listar()
        {

            return md.tb_pedido_clientep.ToList();


        }
            
    }
}
