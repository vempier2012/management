using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UserInterface.Models
{
    public partial class TestDatabaseContext : DbContext
    {
        public TestDatabaseContext()
        {
        }

        public TestDatabaseContext(DbContextOptions<TestDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CauLacBoDoiNhom> CauLacBoDoiNhom { get; set; }
        public virtual DbSet<ChucVuCanBo> ChucVuCanBo { get; set; }
        public virtual DbSet<DanhMucChucVu> DanhMucChucVu { get; set; }
        public virtual DbSet<DanhSachDangKySuKien> DanhSachDangKySuKien { get; set; }
        public virtual DbSet<DanhSachDiemDanhSuKien> DanhSachDiemDanhSuKien { get; set; }
        public virtual DbSet<DonVi> DonVi { get; set; }
        public virtual DbSet<LoaiCauLacBoDoiNhom> LoaiCauLacBoDoiNhom { get; set; }
        public virtual DbSet<LoaiSuKienHoatDong> LoaiSuKienHoatDong { get; set; }
        public virtual DbSet<Lop> Lop { get; set; }
        public virtual DbSet<Nganh> Nganh { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }
        public virtual DbSet<SuKienHoatDong> SuKienHoatDong { get; set; }
        public virtual DbSet<TaiKhoanSinhVien> TaiKhoanSinhVien { get; set; }
        public virtual DbSet<ThanhTichSinhVien> ThanhTichSinhVien { get; set; }
        public virtual DbSet<ThanhVienClb> ThanhVienClb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=PC201506009;Database=TestDatabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CauLacBoDoiNhom>(entity =>
            {
                entity.HasKey(e => e.MaclbDoinhom);

                entity.ToTable("CauLacBo_DoiNhom");

                entity.Property(e => e.MaclbDoinhom)
                    .HasColumnName("maclb_doinhom")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Covan)
                    .HasColumnName("covan")
                    .HasMaxLength(200);

                entity.Property(e => e.Dienthoai)
                    .HasColumnName("dienthoai")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fanpage)
                    .HasColumnName("fanpage")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasColumnName("madonvi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaloaiclbDoinhom)
                    .HasColumnName("maloaiclb_doinhom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaythanhlap)
                    .HasColumnName("ngaythanhlap")
                    .HasColumnType("date");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.TenclbDoinhom).HasColumnName("tenclb_doinhom");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.CauLacBoDoiNhom)
                    .HasForeignKey(d => d.Madonvi)
                    .HasConstraintName("FK__CauLacBo___madon__571DF1D5");

                entity.HasOne(d => d.MaloaiclbDoinhomNavigation)
                    .WithMany(p => p.CauLacBoDoiNhom)
                    .HasForeignKey(d => d.MaloaiclbDoinhom)
                    .HasConstraintName("FK__CauLacBo___maloa__5629CD9C");
            });

            modelBuilder.Entity<ChucVuCanBo>(entity =>
            {
                entity.HasKey(e => new { e.Machucvu, e.Mssv });

                entity.ToTable("ChucVu_CanBo");

                entity.Property(e => e.Machucvu)
                    .HasColumnName("machucvu")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mssv)
                    .HasColumnName("mssv")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.MachucvuNavigation)
                    .WithMany(p => p.ChucVuCanBo)
                    .HasForeignKey(d => d.Machucvu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChucVu_Ca__machu__5FB337D6");

                entity.HasOne(d => d.MssvNavigation)
                    .WithMany(p => p.ChucVuCanBo)
                    .HasForeignKey(d => d.Mssv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChucVu_Can__mssv__60A75C0F");
            });

            modelBuilder.Entity<DanhMucChucVu>(entity =>
            {
                entity.HasKey(e => e.Machucvu);

                entity.Property(e => e.Machucvu)
                    .HasColumnName("machucvu")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phanloaichucvu)
                    .HasColumnName("phanloaichucvu")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.Tenchucvu)
                    .HasColumnName("tenchucvu")
                    .HasMaxLength(200);

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DanhSachDangKySuKien>(entity =>
            {
                entity.HasKey(e => new { e.Masukien, e.Mssv });

                entity.Property(e => e.Masukien)
                    .HasColumnName("masukien")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mssv)
                    .HasColumnName("mssv")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.Thoigiandangky)
                    .HasColumnName("thoigiandangky")
                    .HasColumnType("datetime");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.MasukienNavigation)
                    .WithMany(p => p.DanhSachDangKySuKien)
                    .HasForeignKey(d => d.Masukien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DanhSachD__masuk__4CA06362");

                entity.HasOne(d => d.MssvNavigation)
                    .WithMany(p => p.DanhSachDangKySuKien)
                    .HasForeignKey(d => d.Mssv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DanhSachDa__mssv__4D94879B");
            });

            modelBuilder.Entity<DanhSachDiemDanhSuKien>(entity =>
            {
                entity.HasKey(e => new { e.Masukien, e.Mssv });

                entity.Property(e => e.Masukien)
                    .HasColumnName("masukien")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mssv)
                    .HasColumnName("mssv")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Giora)
                    .HasColumnName("giora")
                    .HasColumnType("datetime");

                entity.Property(e => e.Giovao)
                    .HasColumnName("giovao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.MasukienNavigation)
                    .WithMany(p => p.DanhSachDiemDanhSuKien)
                    .HasForeignKey(d => d.Masukien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DanhSachD__masuk__5070F446");

                entity.HasOne(d => d.MssvNavigation)
                    .WithMany(p => p.DanhSachDiemDanhSuKien)
                    .HasForeignKey(d => d.Mssv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DanhSachDi__mssv__5165187F");
            });

            modelBuilder.Entity<DonVi>(entity =>
            {
                entity.HasKey(e => e.Madonvi);

                entity.Property(e => e.Madonvi)
                    .HasColumnName("madonvi")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.Tendonvi)
                    .HasColumnName("tendonvi")
                    .HasMaxLength(150);

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoaiCauLacBoDoiNhom>(entity =>
            {
                entity.HasKey(e => e.MaloaiclbDoinhom);

                entity.ToTable("LoaiCauLacBo_DoiNhom");

                entity.Property(e => e.MaloaiclbDoinhom)
                    .HasColumnName("maloaiclb_doinhom")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Mota).HasColumnName("mota");

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.TenloaiclbDoinhom)
                    .HasColumnName("tenloaiclb_doinhom")
                    .HasMaxLength(120);

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoaiSuKienHoatDong>(entity =>
            {
                entity.HasKey(e => e.Maloaisukien);

                entity.ToTable("LoaiSuKien_HoatDong");

                entity.Property(e => e.Maloaisukien)
                    .HasColumnName("maloaisukien")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Mota).HasColumnName("mota");

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.Tenloaisukien)
                    .HasColumnName("tenloaisukien")
                    .HasMaxLength(120);

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lop>(entity =>
            {
                entity.HasKey(e => e.Malop);

                entity.Property(e => e.Malop)
                    .HasColumnName("malop")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Madonvi)
                    .HasColumnName("madonvi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganh)
                    .HasColumnName("manganh")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.Tenlop)
                    .HasColumnName("tenlop")
                    .HasMaxLength(50);

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Lop)
                    .HasForeignKey(d => d.Madonvi)
                    .HasConstraintName("FK__Lop__madonvi__3C69FB99");

                entity.HasOne(d => d.ManganhNavigation)
                    .WithMany(p => p.Lop)
                    .HasForeignKey(d => d.Manganh)
                    .HasConstraintName("FK__Lop__manganh__3D5E1FD2");
            });

            modelBuilder.Entity<Nganh>(entity =>
            {
                entity.HasKey(e => e.Manganh);

                entity.Property(e => e.Manganh)
                    .HasColumnName("manganh")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Madonvi)
                    .HasColumnName("madonvi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.Tennganh)
                    .HasColumnName("tennganh")
                    .HasMaxLength(150);

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.Nganh)
                    .HasForeignKey(d => d.Madonvi)
                    .HasConstraintName("FK__Nganh__madonvi__398D8EEE");
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.Mssv);

                entity.Property(e => e.Mssv)
                    .HasColumnName("mssv")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cmnd)
                    .HasColumnName("cmnd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diachi)
                    .HasColumnName("diachi")
                    .HasMaxLength(150);

                entity.Property(e => e.Dienthoai)
                    .HasColumnName("dienthoai")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Email1)
                    .HasColumnName("email_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gioitinh)
                    .HasColumnName("gioitinh")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ho)
                    .HasColumnName("ho")
                    .HasMaxLength(200);

                entity.Property(e => e.Khoa)
                    .HasColumnName("khoa")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Madonvi)
                    .HasColumnName("madonvi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Malop)
                    .HasColumnName("malop")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manganh)
                    .HasColumnName("manganh")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("ngaysinh")
                    .HasColumnType("date");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Noisinh)
                    .HasColumnName("noisinh")
                    .HasMaxLength(50);

                entity.Property(e => e.Quequan)
                    .HasColumnName("quequan")
                    .HasMaxLength(100);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.Ten)
                    .HasColumnName("ten")
                    .HasMaxLength(50);

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.MadonviNavigation)
                    .WithMany(p => p.SinhVien)
                    .HasForeignKey(d => d.Madonvi)
                    .HasConstraintName("FK__SinhVien__madonv__403A8C7D");

                entity.HasOne(d => d.MalopNavigation)
                    .WithMany(p => p.SinhVien)
                    .HasForeignKey(d => d.Malop)
                    .HasConstraintName("FK__SinhVien__malop__4222D4EF");

                entity.HasOne(d => d.ManganhNavigation)
                    .WithMany(p => p.SinhVien)
                    .HasForeignKey(d => d.Manganh)
                    .HasConstraintName("FK__SinhVien__mangan__412EB0B6");
            });

            modelBuilder.Entity<SuKienHoatDong>(entity =>
            {
                entity.HasKey(e => e.Masukien);

                entity.ToTable("SuKien_HoatDong");

                entity.Property(e => e.Masukien)
                    .HasColumnName("masukien")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BinhluanGopy).HasColumnName("binhluan_gopy");

                entity.Property(e => e.Danhgia)
                    .HasColumnName("danhgia")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Diadiem)
                    .HasColumnName("diadiem")
                    .HasMaxLength(250);

                entity.Property(e => e.Maloaisukien)
                    .HasColumnName("maloaisukien")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoiquanly)
                    .HasColumnName("nguoiquanly")
                    .HasMaxLength(200);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.Tensukien).HasColumnName("tensukien");

                entity.Property(e => e.Thoigiandangky)
                    .HasColumnName("thoigiandangky")
                    .HasColumnType("datetime");

                entity.Property(e => e.Thoigianketthuc)
                    .HasColumnName("thoigianketthuc")
                    .HasColumnType("date");

                entity.Property(e => e.Thoigianketthucdangky)
                    .HasColumnName("thoigianketthucdangky")
                    .HasColumnType("datetime");

                entity.Property(e => e.Thoigiantochuc)
                    .HasColumnName("thoigiantochuc")
                    .HasColumnType("date");

                entity.Property(e => e.Tinhtrangduyet)
                    .HasColumnName("tinhtrangduyet")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Tinhtrangsukien)
                    .HasColumnName("tinhtrangsukien")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaloaisukienNavigation)
                    .WithMany(p => p.SuKienHoatDong)
                    .HasForeignKey(d => d.Maloaisukien)
                    .HasConstraintName("FK__SuKien_Ho__maloa__49C3F6B7");
            });

            modelBuilder.Entity<TaiKhoanSinhVien>(entity =>
            {
                entity.HasKey(e => e.Mssv);

                entity.Property(e => e.Mssv)
                    .HasColumnName("mssv")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Matkhau)
                    .HasColumnName("matkhau")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Xacnhanmatkhau)
                    .HasColumnName("xacnhanmatkhau")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.MssvNavigation)
                    .WithOne(p => p.TaiKhoanSinhVien)
                    .HasForeignKey<TaiKhoanSinhVien>(d => d.Mssv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TaiKhoanSi__mssv__44FF419A");
            });

            modelBuilder.Entity<ThanhTichSinhVien>(entity =>
            {
                entity.HasKey(e => e.Maso);

                entity.Property(e => e.Maso).HasColumnName("maso");

                entity.Property(e => e.Mota).HasColumnName("mota");

                entity.Property(e => e.Mssv)
                    .HasColumnName("mssv")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.Tenthanhtich)
                    .HasColumnName("tenthanhtich")
                    .HasMaxLength(250);

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.MssvNavigation)
                    .WithMany(p => p.ThanhTichSinhVien)
                    .HasForeignKey(d => d.Mssv)
                    .HasConstraintName("FK__ThanhTichS__mssv__6FE99F9F");
            });

            modelBuilder.Entity<ThanhVienClb>(entity =>
            {
                entity.HasKey(e => new { e.MaclbDoinhom, e.Mssv });

                entity.ToTable("ThanhVienCLB");

                entity.Property(e => e.MaclbDoinhom)
                    .HasColumnName("maclb_doinhom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mssv)
                    .HasColumnName("mssv")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Chucvu)
                    .HasColumnName("chucvu")
                    .HasMaxLength(50);

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("ngaytao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaythamgia)
                    .HasColumnName("ngaythamgia")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("nguoitao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Solancapnhat).HasColumnName("solancapnhat");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaclbDoinhomNavigation)
                    .WithMany(p => p.ThanhVienClb)
                    .HasForeignKey(d => d.MaclbDoinhom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThanhVien__maclb__59FA5E80");

                entity.HasOne(d => d.MssvNavigation)
                    .WithMany(p => p.ThanhVienClb)
                    .HasForeignKey(d => d.Mssv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThanhVienC__mssv__5AEE82B9");
            });
        }
    }
}
