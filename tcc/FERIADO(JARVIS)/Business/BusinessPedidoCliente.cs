using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class BusinessPedidoCliente
    {
        Database.DatabasePedidoCliente db = new Database.DatabasePedidoCliente();

        public void inseri(Mod.tb_pedido_cliente tabela)
        {
           if(tabela.nm_nome == string.Empty)
                try
                {
                    throw new Exception();

                }
                catch (Exception)
                {

                    throw new ArgumentException("Campo nome do produto vazio.");
                }

            db.inseri(tabela);
        }
        public void deletar(Mod.tb_pedido_cliente tabela)
        {
            

            db.deletar(tabela);

        }
        public void alterar(Mod.tb_pedido_cliente tabela)
        {
            db.alterar(tabela);
        }
        public List<Mod.tb_pedido_cliente> listar()
        {
            return db.listar();
            


        }
    }
}
