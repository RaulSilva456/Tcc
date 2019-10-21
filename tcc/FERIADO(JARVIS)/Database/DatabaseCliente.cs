using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class DatabaseCliente
    {
        Mod.tccEntities5 md = new Mod.tccEntities5();

        public void inserir(Mod.tb_clientes tabela)
        {
            md.tb_clientes.Add(tabela);
            md.SaveChanges();

        }
        public void remover(Mod.tb_clientes tabela)
        {
            tabela = md.tb_clientes.First(x => x.id_clientes == tabela.id_clientes);
            md.tb_clientes.Remove(tabela);
            md.SaveChanges();
        }
        public void alterar(Mod.tb_clientes tabela)
        {
            Mod.tb_clientes alterar = md.tb_clientes.FirstOrDefault(x => x.id_clientes == tabela.id_clientes);
            alterar.nm_nome = tabela.nm_nome;
            alterar.pes_email = tabela.pes_email;
            alterar.tel_telefone = tabela.tel_telefone;
            alterar.end_endereco = tabela.end_endereco;
            alterar.doc_rg = tabela.doc_rg;
            alterar.doc_cep = tabela.doc_cep;
            md.SaveChanges();


        }
        public List<Mod.tb_clientes> listar()
        {

            return  md.tb_clientes.ToList();
        }

    }
}
