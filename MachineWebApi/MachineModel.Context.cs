﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MachineWebApi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FleetMachinesEntities1 : DbContext
    {
        public FleetMachinesEntities1()
            : base("name=FleetMachinesEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }
        public virtual DbSet<FleetOwnerInfo> FleetOwnerInfoes { get; set; }
        public virtual DbSet<Machine_Data> Machine_Data { get; set; }
        public virtual DbSet<MachineInformation> MachineInformations { get; set; }
    }
}