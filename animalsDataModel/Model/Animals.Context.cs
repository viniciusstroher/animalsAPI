﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace animalsDataModel.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SaveAPetEntities : DbContext
    {
        public SaveAPetEntities()
            : base("name=SaveAPetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<EstadoAnimal> EstadoAnimal { get; set; }
        public DbSet<RegistroAnimal> RegistroAnimal { get; set; }
        public DbSet<SituacaoAnimal> SituacaoAnimal { get; set; }
        public DbSet<TipoAnimal> TipoAnimal { get; set; }
    }
}