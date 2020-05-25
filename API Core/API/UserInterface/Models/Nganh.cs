using System;
using System.Collections.Generic;

namespace UserInterface.Models
{
    public partial class Nganh
    {
        public Nganh()
        {
            Lop = new HashSet<Lop>();
            SinhVien = new HashSet<SinhVien>();
        }

        public string Manganh { get; set; }
        public string Tennganh { get; set; }
        public string Madonvi { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoicapnhat { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Solancapnhat { get; set; }
        public string Trangthai { get; set; }

        public DonVi MadonviNavigation { get; set; }
        public ICollection<Lop> Lop { get; set; }
        public ICollection<SinhVien> SinhVien { get; set; }
    }
}
