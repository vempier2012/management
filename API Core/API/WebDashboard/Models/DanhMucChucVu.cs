namespace WebDashboard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMucChucVu")]
    public partial class DanhMucChucVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMucChucVu()
        {
            ChucVu_CanBo = new HashSet<ChucVu_CanBo>();
        }

        [Key]
        [StringLength(20)]
        public string machucvu { get; set; }

        [StringLength(200)]
        public string tenchucvu { get; set; }

        [StringLength(10)]
        public string phanloaichucvu { get; set; }

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
        public virtual ICollection<ChucVu_CanBo> ChucVu_CanBo { get; set; }
    }
}
