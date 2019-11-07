using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class DatabaseCliente
    {
        Mod.db_a4fcff_tccEntities md = new Mod.db_a4fcff_tccEntities();

        public void inserir(Mod.tb_cliente tabela)
        {
            md.tb_cliente.Add(tabela);
            md.SaveChanges();

        }
        public void remover(Mod.tb_cliente tabela)
        {
            
            tabela = md.tb_cliente.First(x => x.id_cliente == tabela.id_cliente);
            md.tb_cliente.Remove(tabela);
            md.SaveChanges();
        }
        public void alterar(Mod.tb_cliente tabela)
        {
            Mod.tb_cliente alterar = md.tb_cliente.FirstOrDefault(x => x.id_cliente == tabela.id_cliente);
            alterar.nm_nome = tabela.nm_nome;
            alterar.pes_email = tabela.pes_email;
            alterar.tel_telefone = tabela.tel_telefone;
            alterar.end_endereco = tabela.end_endereco;
            alterar.doc_rg = tabela.doc_rg;
            alterar.doc_cep = tabela.doc_cep;
            
            md.SaveChanges();


        }
        public List<Mod.tb_cliente> listar()
        {

            return  md.tb_cliente.ToList();
        }

    }
}
