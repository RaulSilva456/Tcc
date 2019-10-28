using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_.Database
{
    class DatabaseFornecedores
    {
        Mod.tccEntities10 md = new Mod.tccEntities10();
        public void inserir(Mod.tb_fornecedores tabela)
        {
            md.tb_fornecedores.Add(tabela);
            md.SaveChanges();
        }
        public void deletar(Mod.tb_fornecedores tabela)
        {
          tabela =  md.tb_fornecedores.First(x => x.id_fornecedores == tabela.id_fornecedores);
            md.tb_fornecedores.Remove(tabela);
            md.SaveChanges();

        }
        public void alterar(Mod.tb_fornecedores tabela )
        {
            Mod.tb_fornecedores alterar = md.tb_fornecedores.FirstOrDefault(x => x.id_fornecedores == tabela.id_fornecedores);
            alterar.nm_fornecedor = tabela.nm_fornecedor;
            alterar.nm_produto = tabela.nm_produto;
            alterar.tl_telefone = tabela.tl_telefone;
            alterar.vl_valor_produto = tabela.vl_valor_produto;
            alterar.fr_cnpj = tabela.fr_cnpj;
            alterar.fr_cep = tabela.fr_cep;
            alterar.end_endereço = tabela.end_endereço;
            md.SaveChanges();

            



        }
        public List<Mod.tb_fornecedores>listar()
        {
            return  md.tb_fornecedores.ToList();
        }
    }
}
