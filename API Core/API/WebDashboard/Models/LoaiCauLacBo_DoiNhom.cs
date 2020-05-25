namespace WebDashboard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LoaiCauLacBo_DoiNhom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiCauLacBo_DoiNhom()
        {
            CauLacBo_DoiNhom = new HashSet<CauLacBo_DoiNhom>();
        }

        [Key]
        [StringLength(20)]
        public string maloaiclb_doinhom { get; set; }

        [StringLength(120)]
        public string tenloaiclb_doinhom { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CauLacBo_DoiNhom> CauLacBo_DoiNhom { get; set; }
    }
}
