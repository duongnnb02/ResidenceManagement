﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nhom5
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class nmcnpm_teamAKAMEntities : DbContext
    {
        public nmcnpm_teamAKAMEntities()
            : base("name=nmcnpm_teamAKAMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<chi_tiet_dip_dac_biet> chi_tiet_dip_dac_biet { get; set; }
        public virtual DbSet<chi_tiet_dip_hoc_sinh_gioi> chi_tiet_dip_hoc_sinh_gioi { get; set; }
        public virtual DbSet<chuyen_ho_khau> chuyen_ho_khau { get; set; }
        public virtual DbSet<chuyen_nhan_khau> chuyen_nhan_khau { get; set; }
        public virtual DbSet<dip_dac_biet> dip_dac_biet { get; set; }
        public virtual DbSet<dip_hoc_sinh_gioi> dip_hoc_sinh_gioi { get; set; }
        public virtual DbSet<ho_khau> ho_khau { get; set; }
        public virtual DbSet<ho_khau_nhan_khau> ho_khau_nhan_khau { get; set; }
        public virtual DbSet<khai_tu> khai_tu { get; set; }
        public virtual DbSet<nguoi_dung> nguoi_dung { get; set; }
        public virtual DbSet<nhan_khau> nhan_khau { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tam_tru> tam_tru { get; set; }
        public virtual DbSet<tam_vang> tam_vang { get; set; }
    }
}
