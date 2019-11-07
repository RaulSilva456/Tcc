using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class DatabaseFornecedores
    {
        Mod.db_a4fcff_tccEntities md = new Mod.db_a4fcff_tccEntities();
        public void inserir(Mod.tb_fornecedor tabela)
        {
            md.tb_fornecedor.Add(tabela);
            md.SaveChanges();
        }
        public void deletar(Mod.tb_fornecedor tabela)
        {
          tabela =  md.tb_fornecedor.First(x => x.id_fornecedor == tabela.id_fornecedor);
            md.tb_fornecedor.Remove(tabela);
            md.SaveChanges();

        }
        public void alterar(Mod.tb_fornecedor tabela )
        {
            Mod.tb_fornecedor alterar = md.tb_fornecedor.FirstOrDefault(x => x.id_fornecedor == tabela.id_fornecedor);
            alterar.nm_fornecedor = tabela.nm_fornecedor;
            alterar.nm_produto = tabela.nm_produto;
            alterar.tl_telefone = tabela.tl_telefone;
            alterar.vl_valor_produto = tabela.vl_valor_produto;
            alterar.fr_cnpj = tabela.fr_cnpj;
            alterar.fr_cep = tabela.fr_cep;
            alterar.end_endereço = tabela.end_endereço;
            alterar.dt_entrada_do_produto = tabela.dt_entrada_do_produto;
            md.SaveChanges();

            



        }
        public List<Mod.tb_fornecedor>listar()
        {
            return  md.tb_fornecedor.ToList();
        }
    }
}
