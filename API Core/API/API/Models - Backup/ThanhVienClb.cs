using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ThanhVienClb
    {
        public string MaclbDoinhom { get; set; }
        public string Mssv { get; set; }
        public DateTime? Ngaythamgia { get; set; }
        public string Chucvu { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoicapnhat { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Solancapnhat { get; set; }
        public string Trangthai { get; set; }

        public CauLacBoDoiNhom MaclbDoinhomNavigation { get; set; }
        public SinhVien MssvNavigation { get; set; }
    }
}
