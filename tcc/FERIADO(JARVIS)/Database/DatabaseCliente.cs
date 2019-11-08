using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class DatabaseCliente
    {
        Mod.db_a4fd25_pppEntities1 md = new Mod.db_a4fd25_pppEntities1();

        public void inserir(Mod.tb_clientep tabela)
        {
            md.tb_clientep.Add(tabela);
            md.SaveChanges();

        }
        public void remover(Mod.tb_clientep tabela)
        {
            tabela = md.tb_clientep.First(x => x.id_cliente == tabela.id_cliente);
            md.tb_clientep.Remove(tabela);
            md.SaveChanges();
        }
        public void alterar(Mod.tb_clientep tabela)
        {
            Mod.tb_clientep alterar = md.tb_clientep.FirstOrDefault(x => x.id_cliente == tabela.id_cliente);
            alterar.nm_nome = tabela.nm_nome;
            alterar.pes_email = tabela.pes_email;
            alterar.tel_telefone = tabela.tel_telefone;
            alterar.end_endereco = tabela.end_endereco;
            alterar.doc_rg = tabela.doc_rg;
            alterar.doc_cep = tabela.doc_cep;
            
            md.SaveChanges();


        }
        public List<Mod.tb_clientep> listar()
        {

            return  md.tb_clientep.ToList();
        }

    }
}
