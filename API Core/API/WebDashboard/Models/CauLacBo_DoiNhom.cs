namespace WebDashboard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CauLacBo_DoiNhom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CauLacBo_DoiNhom()
        {
            ThanhVienCLBs = new HashSet<ThanhVienCLB>();
        }

        [Key]
        [StringLength(20)]
        public string maclb_doinhom { get; set; }

        public string tenclb_doinhom { get; set; }

        [StringLength(20)]
        public string maloaiclb_doinhom { get; set; }

        [StringLength(20)]
        public string madonvi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaythanhlap { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(12)]
        public string dienthoai { get; set; }

        [StringLength(200)]
        public string covan { get; set; }

        [StringLength(200)]
        public string fanpage { get; set; }

        [StringLength(20)]
        public string nguoitao { get; set; }

        public DateTime? ngaytao { get; set; }

        [StringLength(20)]
        public string nguoicapnhat { get; set; }

        public DateTime? ngaycapnhat { get; set; }

        public int? solancapnhat { get; set; }

        [StringLength(2)]
        public string trangthai { get; set; }

        public virtual DonVi DonVi { get; set; }

        public virtual LoaiCauLacBo_DoiNhom LoaiCauLacBo_DoiNhom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhVienCLB> ThanhVienCLBs { get; set; }
    }
}
