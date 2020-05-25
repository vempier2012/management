using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class DonVi
    {
        public DonVi()
        {
            CauLacBoDoiNhom = new HashSet<CauLacBoDoiNhom>();
            Lop = new HashSet<Lop>();
            Nganh = new HashSet<Nganh>();
            SinhVien = new HashSet<SinhVien>();
        }

        public string Madonvi { get; set; }
        public string Tendonvi { get; set; }
        public string Email { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoicapnhat { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Solancapnhat { get; set; }
        public string Trangthai { get; set; }

        public ICollection<CauLacBoDoiNhom> CauLacBoDoiNhom { get; set; }
        public ICollection<Lop> Lop { get; set; }
        public ICollection<Nganh> Nganh { get; set; }
        public ICollection<SinhVien> SinhVien { get; set; }
    }
}
