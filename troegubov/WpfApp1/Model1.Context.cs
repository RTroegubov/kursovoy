﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class inetprovider_kpEntities : DbContext
    {
        public inetprovider_kpEntities()
            : base("name=inetprovider_kpEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<CallCenter> CallCenter { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Naryad> Naryad { get; set; }
        public virtual DbSet<NaryadService> NaryadService { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderService> OrderService { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonPayment> PersonPayment { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<ProviderOrder> ProviderOrder { get; set; }
        public virtual DbSet<ProviderOrderProduct> ProviderOrderProduct { get; set; }
        public virtual DbSet<Rate> Rate { get; set; }
        public virtual DbSet<RegistrService> RegistrService { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceDiscount> ServiceDiscount { get; set; }
        public virtual DbSet<StatusType> StatusType { get; set; }
        public virtual DbSet<Storage> Storage { get; set; }
        public virtual DbSet<SysPaym> SysPaym { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }
    }
}
