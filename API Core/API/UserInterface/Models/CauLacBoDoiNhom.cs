using System;
using System.Collections.Generic;

namespace UserInterface.Models
{
    public partial class CauLacBoDoiNhom
    {
        public CauLacBoDoiNhom()
        {
            ThanhVienClb = new HashSet<ThanhVienClb>();
        }

        public string MaclbDoinhom { get; set; }
        public string TenclbDoinhom { get; set; }
        public string MaloaiclbDoinhom { get; set; }
        public string Madonvi { get; set; }
        public DateTime? Ngaythanhlap { get; set; }
        public string Email { get; set; }
        public string Dienthoai { get; set; }
        public string Covan { get; set; }
        public string Fanpage { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoicapnhat { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Solancapnhat { get; set; }
        public string Trangthai { get; set; }

        public DonVi MadonviNavigation { get; set; }
        public LoaiCauLacBoDoiNhom MaloaiclbDoinhomNavigation { get; set; }
        public ICollection<ThanhVienClb> ThanhVienClb { get; set; }
    }
}
