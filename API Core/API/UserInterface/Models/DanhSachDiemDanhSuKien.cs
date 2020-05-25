using System;
using System.Collections.Generic;

namespace UserInterface.Models
{
    public partial class DanhSachDiemDanhSuKien
    {
        public string Masukien { get; set; }
        public string Mssv { get; set; }
        public DateTime? Giovao { get; set; }
        public DateTime? Giora { get; set; }
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
