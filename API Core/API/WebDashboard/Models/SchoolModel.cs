namespace WebDashboard.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SchoolModel : DbContext
    {
        public SchoolModel()
            : base("name=SchoolModel")
        {
        }

        public virtual DbSet<CauLacBo_DoiNhom> CauLacBo_DoiNhom { get; set; }
        public virtual DbSet<ChucVu_CanBo> ChucVu_CanBo { get; set; }
        public virtual DbSet<DanhMucChucVu> DanhMucChucVus { get; set; }
        public virtual DbSet<DanhSachDangKySuKien> DanhSachDangKySuKiens { get; set; }
        public virtual DbSet<DanhSachDiemDanhSuKien> DanhSachDiemDanhSuKiens { get; set; }
        public virtual DbSet<DonVi> DonVis { get; set; }
        public virtual DbSet<LoaiCauLacBo_DoiNhom> LoaiCauLacBo_DoiNhom { get; set; }
        public virtual DbSet<LoaiSuKien_HoatDong> LoaiSuKien_HoatDong { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<Nganh> Nganhs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<SuKien_HoatDong> SuKien_HoatDong { get; set; }
        public virtual DbSet<TaiKhoanSinhVien> TaiKhoanSinhViens { get; set; }
        public virtual DbSet<ThanhTichSinhVien> ThanhTichSinhViens { get; set; }
        public virtual DbSet<ThanhVienCLB> ThanhVienCLBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CauLacBo_DoiNhom>()
                .Property(e => e.maclb_doinhom)
                .IsUnicode(false);

            modelBuilder.Entity<CauLacBo_DoiNhom>()
                .Property(e => e.maloaiclb_doinhom)
                .IsUnicode(false);

            modelBuilder.Entity<CauLacBo_DoiNhom>()
                .Property(e => e.madonvi)
                .IsUnicode(false);

            modelBuilder.Entity<CauLacBo_DoiNhom>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<CauLacBo_DoiNhom>()
                .Property(e => e.dienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<CauLacBo_DoiNhom>()
                .Property(e => e.fanpage)
                .IsUnicode(false);

            modelBuilder.Entity<CauLacBo_DoiNhom>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<CauLacBo_DoiNhom>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<CauLacBo_DoiNhom>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<CauLacBo_DoiNhom>()
                .HasMany(e => e.ThanhVienCLBs)
                .WithRequired(e => e.CauLacBo_DoiNhom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChucVu_CanBo>()
                .Property(e => e.machucvu)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu_CanBo>()
                .Property(e => e.mssv)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu_CanBo>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu_CanBo>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu_CanBo>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<DanhMucChucVu>()
                .Property(e => e.machucvu)
                .IsUnicode(false);

            modelBuilder.Entity<DanhMucChucVu>()
                .Property(e => e.phanloaichucvu)
                .IsUnicode(false);

            modelBuilder.Entity<DanhMucChucVu>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<DanhMucChucVu>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<DanhMucChucVu>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<DanhMucChucVu>()
                .HasMany(e => e.ChucVu_CanBo)
                .WithRequired(e => e.DanhMucChucVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DanhSachDangKySuKien>()
                .Property(e => e.masukien)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachDangKySuKien>()
                .Property(e => e.mssv)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachDangKySuKien>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachDangKySuKien>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachDangKySuKien>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachDiemDanhSuKien>()
                .Property(e => e.masukien)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachDiemDanhSuKien>()
                .Property(e => e.mssv)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachDiemDanhSuKien>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachDiemDanhSuKien>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachDiemDanhSuKien>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<DonVi>()
                .Property(e => e.madonvi)
                .IsUnicode(false);

            modelBuilder.Entity<DonVi>()
                .Property(e => e.email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonVi>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<DonVi>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<DonVi>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiCauLacBo_DoiNhom>()
                .Property(e => e.maloaiclb_doinhom)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiCauLacBo_DoiNhom>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiCauLacBo_DoiNhom>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiCauLacBo_DoiNhom>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiSuKien_HoatDong>()
                .Property(e => e.maloaisukien)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiSuKien_HoatDong>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiSuKien_HoatDong>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiSuKien_HoatDong>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.malop)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.madonvi)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.manganh)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<Nganh>()
                .Property(e => e.manganh)
                .IsUnicode(false);

            modelBuilder.Entity<Nganh>()
                .Property(e => e.madonvi)
                .IsUnicode(false);

            modelBuilder.Entity<Nganh>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<Nganh>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<Nganh>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.mssv)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.gioitinh)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.cmnd)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.dienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.email_1)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.email_2)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.madonvi)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.manganh)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.malop)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.khoa)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.ChucVu_CanBo)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.DanhSachDangKySuKiens)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.DanhSachDiemDanhSuKiens)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .HasOptional(e => e.TaiKhoanSinhVien)
                .WithRequired(e => e.SinhVien);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.ThanhVienCLBs)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SuKien_HoatDong>()
                .Property(e => e.masukien)
                .IsUnicode(false);

            modelBuilder.Entity<SuKien_HoatDong>()
                .Property(e => e.maloaisukien)
                .IsUnicode(false);

            modelBuilder.Entity<SuKien_HoatDong>()
                .Property(e => e.tinhtrangduyet)
                .IsUnicode(false);

            modelBuilder.Entity<SuKien_HoatDong>()
                .Property(e => e.tinhtrangsukien)
                .IsUnicode(false);

            modelBuilder.Entity<SuKien_HoatDong>()
                .Property(e => e.danhgia)
                .IsUnicode(false);

            modelBuilder.Entity<SuKien_HoatDong>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<SuKien_HoatDong>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<SuKien_HoatDong>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<SuKien_HoatDong>()
                .HasMany(e => e.DanhSachDangKySuKiens)
                .WithRequired(e => e.SuKien_HoatDong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SuKien_HoatDong>()
                .HasMany(e => e.DanhSachDiemDanhSuKiens)
                .WithRequired(e => e.SuKien_HoatDong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoanSinhVien>()
                .Property(e => e.mssv)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanSinhVien>()
                .Property(e => e.matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanSinhVien>()
                .Property(e => e.xacnhanmatkhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanSinhVien>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanSinhVien>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanSinhVien>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhTichSinhVien>()
                .Property(e => e.mssv)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhTichSinhVien>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhTichSinhVien>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhTichSinhVien>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVienCLB>()
                .Property(e => e.maclb_doinhom)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVienCLB>()
                .Property(e => e.mssv)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVienCLB>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVienCLB>()
                .Property(e => e.nguoicapnhat)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVienCLB>()
                .Property(e => e.trangthai)
                .IsUnicode(false);
        }
    }
}
