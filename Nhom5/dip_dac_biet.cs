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
    
    public partial class dip_dac_biet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dip_dac_biet()
        {
            this.chi_tiet_dip_dac_biet = new HashSet<chi_tiet_dip_dac_biet>();
        }
    
        public int idDip { get; set; }
        public string ten { get; set; }
        public int nam { get; set; }
        public string moTa { get; set; }
        public string phanQua05 { get; set; }
        public string phanQua614 { get; set; }
        public string phanQua1517 { get; set; }
        public double tien05 { get; set; }
        public double tien614 { get; set; }
        public double tien1517 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_dip_dac_biet> chi_tiet_dip_dac_biet { get; set; }
    }
}
