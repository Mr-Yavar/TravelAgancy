﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Travel_Agancy.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class travelAgencyEntities : DbContext
    {
        public travelAgencyEntities()
            : base("name=travelAgencyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bus> buses { get; set; }
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<driver> drivers { get; set; }
        public virtual DbSet<providing_travel> providing_travel { get; set; }
        public virtual DbSet<reservation> reservations { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<travel> travels { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
