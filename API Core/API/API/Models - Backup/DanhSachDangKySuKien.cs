using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DanhSachDangKySuKien
    {
        public string Masukien { get; set; }
        public string Mssv { get; set; }
        public DateTime? Thoigiandangky { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoicapnhat { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Solancapnhat { get; set; }
        public string Trangthai { get; set; }

        public SuKienHoatDong MasukienNavigation { get; set; }
        public SinhVien MssvNavigation { get; set; }
    }
}
