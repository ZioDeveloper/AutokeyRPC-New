﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutokeyRPC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AutokeyEntities : DbContext
    {
        public AutokeyEntities()
            : base("name=AutokeyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<RPC_Cantieri> RPC_Cantieri { get; set; }
        public virtual DbSet<AUK_cantieri> AUK_cantieri { get; set; }
        public virtual DbSet<RPC_Cantieri_vw> RPC_Cantieri_vw { get; set; }
        public virtual DbSet<AUK_tecnici> AUK_tecnici { get; set; }
        public virtual DbSet<RPC_Lotti> RPC_Lotti { get; set; }
        public virtual DbSet<RPC_Telai> RPC_Telai { get; set; }
        public virtual DbSet<PKT_Operatori> PKT_Operatori { get; set; }
    }
}