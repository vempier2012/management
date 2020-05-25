namespace WebDashboard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SuKien_HoatDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SuKien_HoatDong()
        {
            DanhSachDangKySuKiens = new HashSet<DanhSachDangKySuKien>();
            DanhSachDiemDanhSuKiens = new HashSet<DanhSachDiemDanhSuKien>();
        }

        [Key]
        [StringLength(20)]
        public string masukien { get; set; }

        public string tensukien { get; set; }

        [StringLength(20)]
        public string maloaisukien { get; set; }

        public DateTime? thoigiandangky { get; set; }

        public DateTime? thoigianketthucdangky { get; set; }

        [Column(TypeName = "date")]
        public DateTime? thoigiantochuc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? thoigianketthuc { get; set; }

        [StringLength(250)]
        public string diadiem { get; set; }

        [StringLength(200)]
        public string nguoiquanly { get; set; }

        [StringLength(5)]
        public string tinhtrangduyet { get; set; }

        [StringLength(20)]
        public string tinhtrangsukien { get; set; }

        [StringLength(5)]
        public string danhgia { get; set; }

        public string binhluan_gopy { get; set; }

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
        public virtual ICollection<DanhSachDangKySuKien> DanhSachDangKySuKiens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhSachDiemDanhSuKien> DanhSachDiemDanhSuKiens { get; set; }

        public virtual LoaiSuKien_HoatDong LoaiSuKien_HoatDong { get; set; }
    }
}
