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
    
    public partial class chuyen_nhan_khau
    {
        public int id { get; set; }
        public int idNhanKhau { get; set; }
        public System.DateTime ngayChuyenDi { get; set; }
        public string noiChuyenDen { get; set; }
        public string ghiChu { get; set; }
    
        public virtual nhan_khau nhan_khau { get; set; }
    }
}
