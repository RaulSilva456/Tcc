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
    
    public partial class tb_funcionariosp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_funcionariosp()
        {
            this.tb_folhapagamentop = new HashSet<tb_folhapagamentop>();
        }
    
        public int id_funcionario { get; set; }
        public string nm_funcionario { get; set; }
        public Nullable<System.DateTime> dt_nasc { get; set; }
        public string fun_rg { get; set; }
        public string fun_cpf { get; set; }
        public string fun_endereço { get; set; }
        public Nullable<decimal> ad_fgts { get; set; }
        public Nullable<decimal> sl_salario { get; set; }
        public Nullable<System.DateTime> dt_data_de_contratacao { get; set; }
        public string fun_cargo { get; set; }
        public Nullable<System.DateTime> dt_pagamento_do_funcionario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_folhapagamentop> tb_folhapagamentop { get; set; }
    }
}
