//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FERIADO_JARVIS_.Mod
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_estoquep
    {
        public int id_produto { get; set; }
        public Nullable<int> id_fornecedor { get; set; }
        public string nm_produto { get; set; }
        public Nullable<decimal> qtd_quantidade_do_produto { get; set; }
        public string pro_vencido { get; set; }
        public Nullable<decimal> pr_preco { get; set; }
        public Nullable<System.DateTime> dt_saida_do_produto { get; set; }
    
        public virtual tb_fornecedorp tb_fornecedorp { get; set; }
    }
}
