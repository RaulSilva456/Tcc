using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class Business_Folha_de_Pagamento
    {
        Database.Database_FolhaDePagamento_ dt = new Database.Database_FolhaDePagamento_();
        public void inserir(Mod.tb_folhapagamento tabela)
        {
            dt.inserir(tabela);
        }
        public void remover(Mod.tb_folhapagamento tabela)
        {
            dt.remover(tabela);
        }
        public void alterar(Mod.tb_folhapagamento tabela)
        {
            dt.alterar(tabela);


        }
        public List<Mod.tb_folhapagamento> listar()
        {
          return  dt.listar();
        }

    }
}
