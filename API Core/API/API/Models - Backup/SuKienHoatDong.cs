using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SuKienHoatDong
    {
        public SuKienHoatDong()
        {
            DanhSachDangKySuKien = new HashSet<DanhSachDangKySuKien>();
            DanhSachDiemDanhSuKien = new HashSet<DanhSachDiemDanhSuKien>();
        }

        public string Masukien { get; set; }
        public string Tensukien { get; set; }
        public string Maloaisukien { get; set; }
        public DateTime? Thoigiandangky { get; set; }
        public DateTime? Thoigianketthucdangky { get; set; }
        public DateTime? Thoigiantochuc { get; set; }
        public DateTime? Thoigianketthuc { get; set; }
        public string Diadiem { get; set; }
        public string Nguoiquanly { get; set; }
        public string Tinhtrangduyet { get; set; }
        public string Tinhtrangsukien { get; set; }
        public string Danhgia { get; set; }
        public string BinhluanGopy { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoicapnhat { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Solancapnhat { get; set; }
        public string Trangthai { get; set; }

        public LoaiSuKienHoatDong MaloaisukienNavigation { get; set; }
        public ICollection<DanhSachDangKySuKien> DanhSachDangKySuKien { get; set; }
        public ICollection<DanhSachDiemDanhSuKien> DanhSachDiemDanhSuKien { get; set; }
    }
}
