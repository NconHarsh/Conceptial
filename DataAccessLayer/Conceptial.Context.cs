﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ConceptialEntities : DbContext
    {
        public ConceptialEntities()
            : base("name=ConceptialEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Additional_Weight_Table> Additional_Weight_Table { get; set; }
        public virtual DbSet<Ammunition_Components_Table> Ammunition_Components_Table { get; set; }
        public virtual DbSet<Crew_And_Effects_Components_Table> Crew_And_Effects_Components_Table { get; set; }
        public virtual DbSet<Hydrostatic_Particulars_Table> Hydrostatic_Particulars_Table { get; set; }
        public virtual DbSet<Light_Ship_Weight_Table> Light_Ship_Weight_Table { get; set; }
        public virtual DbSet<Provision_Store_Components_Table> Provision_Store_Components_Table { get; set; }
        public virtual DbSet<Role_Tbl> Role_Tbl { get; set; }
        public virtual DbSet<Ship_Table> Ship_Table { get; set; }
        public virtual DbSet<Tank_Sounding_Table> Tank_Sounding_Table { get; set; }
        public virtual DbSet<Tank_Status> Tank_Status { get; set; }
        public virtual DbSet<User_Role_Tbl> User_Role_Tbl { get; set; }
        public virtual DbSet<User_Tbl> User_Tbl { get; set; }
    }
}
