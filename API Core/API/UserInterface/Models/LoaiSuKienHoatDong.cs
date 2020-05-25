using System;
using System.Collections.Generic;

namespace UserInterface.Models
{
    public partial class LoaiSuKienHoatDong
    {
        public LoaiSuKienHoatDong()
        {
            SuKienHoatDong = new HashSet<SuKienHoatDong>();
        }

        public string Maloaisukien { get; set; }
        public string Tenloaisukien { get; set; }
        public string Mota { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoicapnhat { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Solancapnhat { get; set; }
        public string Trangthai { get; set; }

        public ICollection<SuKienHoatDong> SuKienHoatDong { get; set; }
    }
}
