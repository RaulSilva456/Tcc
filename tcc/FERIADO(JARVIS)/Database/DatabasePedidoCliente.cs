using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class DatabasePedidoCliente
    {
        Mod.tccEntities10 md = new Mod.tccEntities10();
        

       public void inseri(Mod.tb_pedido_cliente tabela )
        {
            md.tb_pedido_cliente.Add(tabela);
            md.SaveChanges();
        }
        public void deletar(Mod.tb_pedido_cliente tabela)
        {
            tabela = md.tb_pedido_cliente.First(x => x.id_pedido == tabela.id_pedido);
            md.tb_pedido_cliente.Remove(tabela);
            md.SaveChanges();

        }
        public void alterar(Mod.tb_pedido_cliente tabela)
        {
            Mod.tb_pedido_cliente altera = md.tb_pedido_cliente.FirstOrDefault(x => x.id_pedido == tabela.id_pedido);
            altera.nm_produto_cliente = tabela.nm_produto_cliente;
            altera.qtd_quantidade = tabela.qtd_quantidade;
            md.SaveChanges();
        }
        public List<Mod.tb_pedido_cliente>listar()
        {

            return md.tb_pedido_cliente.ToList();


        }
            
    }
}
