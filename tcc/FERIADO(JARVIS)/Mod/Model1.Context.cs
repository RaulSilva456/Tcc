﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tccEntities10 : DbContext
    {
        public tccEntities10()
            : base("name=tccEntities10")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_clientes> tb_clientes { get; set; }
        public virtual DbSet<tb_despesas> tb_despesas { get; set; }
        public virtual DbSet<tb_estoque> tb_estoque { get; set; }
        public virtual DbSet<tb_folhapagamento> tb_folhapagamento { get; set; }
        public virtual DbSet<tb_fornecedores> tb_fornecedores { get; set; }
        public virtual DbSet<tb_funcionarios> tb_funcionarios { get; set; }
        public virtual DbSet<tb_login> tb_login { get; set; }
        public virtual DbSet<tb_pedido_cliente> tb_pedido_cliente { get; set; }
        public virtual DbSet<tb_produto> tb_produto { get; set; }
        public virtual DbSet<tb_venda_cliente> tb_venda_cliente { get; set; }
    }
}
