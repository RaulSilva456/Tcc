using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class DatabaseMostruario
    {
        Mod.tccEntities10 md = new Mod.tccEntities10();
        public void deletar(Mod.tb_mostruario tabela)
        {
            tabela = md.tb_mostruario.First(x => x.id_produto_mostruario == tabela.id_produto_mostruario);
            md.tb_mostruario.Remove(tabela);
            md.SaveChanges();
        }
        public void inserir(Mod.tb_mostruario tabela)
        {
            md.tb_mostruario.Add(tabela);

            md.SaveChanges();
        }
        public List<Mod.tb_mostruario> lista()
        {
            return md.tb_mostruario.ToList();
        }
    }
}
