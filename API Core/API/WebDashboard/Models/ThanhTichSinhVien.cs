namespace WebDashboard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhTichSinhVien")]
    public partial class ThanhTichSinhVien
    {
        [Key]
        public int maso { get; set; }

        [StringLength(20)]
        public string mssv { get; set; }

        [StringLength(250)]
        public string tenthanhtich { get; set; }

        public string mota { get; set; }

        [StringLength(20)]
        public string nguoitao { get; set; }

        public DateTime? ngaytao { get; set; }

        [StringLength(20)]
        public string nguoicapnhat { get; set; }

        public DateTime? ngaycapnhat { get; set; }

        public int? solancapnhat { get; set; }

        [StringLength(2)]
        public string trangthai { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
