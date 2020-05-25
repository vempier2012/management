using System;
using System.Collections.Generic;

namespace UserInterface.Models
{
    public partial class SinhVien
    {
        public SinhVien()
        {
            ChucVuCanBo = new HashSet<ChucVuCanBo>();
            DanhSachDangKySuKien = new HashSet<DanhSachDangKySuKien>();
            DanhSachDiemDanhSuKien = new HashSet<DanhSachDiemDanhSuKien>();
            ThanhTichSinhVien = new HashSet<ThanhTichSinhVien>();
            ThanhVienClb = new HashSet<ThanhVienClb>();
        }

        public string Mssv { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string Noisinh { get; set; }
        public string Quequan { get; set; }
        public string Gioitinh { get; set; }
        public string Cmnd { get; set; }
        public string Dienthoai { get; set; }
        public string Diachi { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Madonvi { get; set; }
        public string Manganh { get; set; }
        public string Malop { get; set; }
        public string Khoa { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoicapnhat { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Solancapnhat { get; set; }
        public string Trangthai { get; set; }

        public DonVi MadonviNavigation { get; set; }
        public Lop MalopNavigation { get; set; }
        public Nganh ManganhNavigation { get; set; }
        public TaiKhoanSinhVien TaiKhoanSinhVien { get; set; }
        public ICollection<ChucVuCanBo> ChucVuCanBo { get; set; }
        public ICollection<DanhSachDangKySuKien> DanhSachDangKySuKien { get; set; }
        public ICollection<DanhSachDiemDanhSuKien> DanhSachDiemDanhSuKien { get; set; }
        public ICollection<ThanhTichSinhVien> ThanhTichSinhVien { get; set; }
        public ICollection<ThanhVienClb> ThanhVienClb { get; set; }
    }
}
