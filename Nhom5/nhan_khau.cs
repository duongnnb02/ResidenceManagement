//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class nhan_khau
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhan_khau()
        {
            this.chi_tiet_dip_dac_biet = new HashSet<chi_tiet_dip_dac_biet>();
            this.chi_tiet_dip_hoc_sinh_gioi = new HashSet<chi_tiet_dip_hoc_sinh_gioi>();
            this.chuyen_nhan_khau = new HashSet<chuyen_nhan_khau>();
            this.ho_khau = new HashSet<ho_khau>();
            this.ho_khau_nhan_khau = new HashSet<ho_khau_nhan_khau>();
            this.khai_tu = new HashSet<khai_tu>();
            this.tam_tru = new HashSet<tam_tru>();
            this.tam_vang = new HashSet<tam_vang>();
        }
    
        public int idNhanKhau { get; set; }
        public string hoTen { get; set; }
        public string biDanh { get; set; }
        public System.DateTime ngaySinh { get; set; }
        public string noiSinh { get; set; }
        public string gioiTinh { get; set; }
        public string nguyenQuan { get; set; }
        public string danToc { get; set; }
        public string tonGiao { get; set; }
        public string quocTich { get; set; }
        public string ngheNghiep { get; set; }
        public string noiLamViec { get; set; }
        public string cmnd { get; set; }
        public Nullable<System.DateTime> ngayCap { get; set; }
        public Nullable<System.DateTime> chuyenDenNgay { get; set; }
        public string noiThuongTruTruoc { get; set; }
        public string trangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_dip_dac_biet> chi_tiet_dip_dac_biet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_dip_hoc_sinh_gioi> chi_tiet_dip_hoc_sinh_gioi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chuyen_nhan_khau> chuyen_nhan_khau { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ho_khau> ho_khau { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ho_khau_nhan_khau> ho_khau_nhan_khau { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<khai_tu> khai_tu { get; set; }
        public virtual khai_tu khai_tu1 { get; set; }
        public virtual khai_tu khai_tu2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tam_tru> tam_tru { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tam_vang> tam_vang { get; set; }
    }
}
