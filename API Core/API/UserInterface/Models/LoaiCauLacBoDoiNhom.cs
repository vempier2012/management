using System;
using System.Collections.Generic;

namespace UserInterface.Models
{
    public partial class LoaiCauLacBoDoiNhom
    {
        public LoaiCauLacBoDoiNhom()
        {
            CauLacBoDoiNhom = new HashSet<CauLacBoDoiNhom>();
        }

        public string MaloaiclbDoinhom { get; set; }
        public string TenloaiclbDoinhom { get; set; }
        public string Mota { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoicapnhat { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Solancapnhat { get; set; }
        public string Trangthai { get; set; }

        public ICollection<CauLacBoDoiNhom> CauLacBoDoiNhom { get; set; }
    }
}
