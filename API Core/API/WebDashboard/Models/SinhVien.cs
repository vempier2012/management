namespace WebDashboard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            ChucVu_CanBo = new HashSet<ChucVu_CanBo>();
            DanhSachDangKySuKiens = new HashSet<DanhSachDangKySuKien>();
            DanhSachDiemDanhSuKiens = new HashSet<DanhSachDiemDanhSuKien>();
            ThanhTichSinhViens = new HashSet<ThanhTichSinhVien>();
            ThanhVienCLBs = new HashSet<ThanhVienCLB>();
        }

        [Key]
        [StringLength(20)]
        public string mssv { get; set; }

        [StringLength(200)]
        public string ho { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        [StringLength(50)]
        public string noisinh { get; set; }

        [StringLength(100)]
        public string quequan { get; set; }

        [StringLength(1)]
        public string gioitinh { get; set; }

        [StringLength(20)]
        public string cmnd { get; set; }

        [StringLength(12)]
        public string dienthoai { get; set; }

        [StringLength(150)]
        public string diachi { get; set; }

        [StringLength(50)]
        public string email_1 { get; set; }

        [StringLength(50)]
        public string email_2 { get; set; }

        [StringLength(20)]
        public string madonvi { get; set; }

        [StringLength(20)]
        public string manganh { get; set; }

        [StringLength(20)]
        public string malop { get; set; }

        [StringLength(20)]
        public string khoa { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhSachDangKySuKien> DanhSachDangKySuKiens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhSachDiemDanhSuKien> DanhSachDiemDanhSuKiens { get; set; }

        public virtual DonVi DonVi { get; set; }

        public virtual Lop Lop { get; set; }

        public virtual Nganh Nganh { get; set; }

        public virtual TaiKhoanSinhVien TaiKhoanSinhVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhTichSinhVien> ThanhTichSinhViens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhVienCLB> ThanhVienCLBs { get; set; }
    }
}
