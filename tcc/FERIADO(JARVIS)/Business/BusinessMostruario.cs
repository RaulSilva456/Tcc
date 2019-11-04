using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Business
{
    class BusinessMostruario
    {

        Database.DatabaseMostruario db = new Database.DatabaseMostruario();
        public void deletar(Mod.tb_mostruario tabela)
        {
            db.deletar(tabela);
        }
        public void inserir(Mod.tb_mostruario tabela)
        {
            db.inserir(tabela);
           
        }
        public List<Mod.tb_mostruario> lista()
        {
            return db.lista();
        }
    }
}
