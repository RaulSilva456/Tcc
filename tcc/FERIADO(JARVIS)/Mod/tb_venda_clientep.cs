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
    
    public partial class tb_venda_clientep
    {
        public int id_venda { get; set; }
        public Nullable<decimal> vl_venda { get; set; }
        public string nm_produto { get; set; }
        public string nm_cliente_venda { get; set; }
        public Nullable<System.DateTime> dt_venda_produto { get; set; }
        public Nullable<int> id_produto { get; set; }
        public Nullable<int> id_cliente { get; set; }
    
        public virtual tb_clientep tb_clientep { get; set; }
        public virtual tb_produtop tb_produtop { get; set; }
    }
}
