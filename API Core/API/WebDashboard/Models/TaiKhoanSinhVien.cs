namespace WebDashboard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoanSinhVien")]
    public partial class TaiKhoanSinhVien
    {
        [Key]
        [StringLength(20)]
        public string mssv { get; set; }

        [StringLength(30)]
        public string matkhau { get; set; }

        [StringLength(30)]
        public string xacnhanmatkhau { get; set; }

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
