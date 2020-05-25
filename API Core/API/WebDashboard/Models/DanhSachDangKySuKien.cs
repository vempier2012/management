namespace WebDashboard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhSachDangKySuKien")]
    public partial class DanhSachDangKySuKien
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string masukien { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string mssv { get; set; }

        public DateTime? thoigiandangky { get; set; }

        [StringLength(20)]
        public string nguoitao { get; set; }

        public DateTime? ngaytao { get; set; }

        [StringLength(20)]
        public string nguoicapnhat { get; set; }

        public DateTime? ngaycapnhat { get; set; }

        public int? solancapnhat { get; set; }

        [StringLength(2)]
        public string trangthai { get; set; }

        public virtual SuKien_HoatDong SuKien_HoatDong { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
