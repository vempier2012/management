namespace WebDashboard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhVienCLB")]
    public partial class ThanhVienCLB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string maclb_doinhom { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string mssv { get; set; }

        public DateTime? ngaythamgia { get; set; }

        [StringLength(50)]
        public string chucvu { get; set; }

        [StringLength(20)]
        public string nguoitao { get; set; }

        public DateTime? ngaytao { get; set; }

        [StringLength(20)]
        public string nguoicapnhat { get; set; }

        public DateTime? ngaycapnhat { get; set; }

        public int? solancapnhat { get; set; }

        [StringLength(2)]
        public string trangthai { get; set; }

        public virtual CauLacBo_DoiNhom CauLacBo_DoiNhom { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
