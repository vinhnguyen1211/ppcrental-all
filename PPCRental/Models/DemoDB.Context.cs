﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPCRental.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ppcrental3119Entities : DbContext
    {
        public ppcrental3119Entities()
            : base("name=ppcrental3119Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DISTRICT> DISTRICTs { get; set; }
        public virtual DbSet<FEATURE> FEATUREs { get; set; }
        public virtual DbSet<PROJECT_STATUS> PROJECT_STATUS { get; set; }
        public virtual DbSet<PROPERTY> PROPERTies { get; set; }
        public virtual DbSet<PROPERTY_FEATURE> PROPERTY_FEATURE { get; set; }
        public virtual DbSet<PROPERTY_TYPE> PROPERTY_TYPE { get; set; }
        public virtual DbSet<ROLE> ROLEs { get; set; }
        public virtual DbSet<security_questions> security_questions { get; set; }
        public virtual DbSet<STREET> STREETs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
        public virtual DbSet<WARD> WARDs { get; set; }
        public virtual DbSet<UserManagement> UserManagements { get; set; }
        public virtual DbSet<View_project_from_index> View_project_from_index { get; set; }
        public virtual DbSet<View_District_Street> View_District_Street { get; set; }
        public virtual DbSet<View_District_Ward> View_District_Ward { get; set; }
    }
}
