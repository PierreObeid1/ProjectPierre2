//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Filter_Records_Between_Two_Dates.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Sample1Entities26 : DbContext
    {
        public Sample1Entities26()
            : base("name=Sample1Entities26")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Business_Card> Business_Card { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Dates_samaya> Dates_samaya { get; set; }
        public virtual DbSet<Departments_samaya> Departments_samaya { get; set; }
        public virtual DbSet<Genders_samaya> Genders_samaya { get; set; }
        public virtual DbSet<Hijab_Cap> Hijab_Cap { get; set; }
        public virtual DbSet<Medical_Insurance_Card> Medical_Insurance_Card { get; set; }
        public virtual DbSet<Positions_samaya> Positions_samaya { get; set; }
        public virtual DbSet<Safety_Shoes> Safety_Shoes { get; set; }
        public virtual DbSet<Shirts_samaya> Shirts_samaya { get; set; }
        public virtual DbSet<T_shirt_samaya> T_shirt_samaya { get; set; }
        public virtual DbSet<User2> User2 { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
