﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionEstacionesBD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class estaciones_bdEntities : DbContext
    {
        public estaciones_bdEntities()
            : base("name=estaciones_bdEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<Estacion> Estacion { get; set; }
        public virtual DbSet<PuntoCarga> PuntoCarga { get; set; }
        public virtual DbSet<Region> Region { get; set; }
    }
}
