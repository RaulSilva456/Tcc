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
    
    public partial class tb_fornecedores
    {
        public int id_fornecedores { get; set; }
        public string nm_produto { get; set; }
        public string nm_fornecedor { get; set; }
        public string end_endereço { get; set; }
        public string tl_telefone { get; set; }
        public string fr_cep { get; set; }
        public string fr_cnpj { get; set; }
        public Nullable<decimal> vl_valor_produto { get; set; }
        public Nullable<System.DateTime> dt_entrada_do_produto { get; set; }
    }
}
