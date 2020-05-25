﻿using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Lop
    {
        public Lop()
        {
            SinhVien = new HashSet<SinhVien>();
        }

        public string Malop { get; set; }
        public string Tenlop { get; set; }
        public string Madonvi { get; set; }
        public string Manganh { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoicapnhat { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Solancapnhat { get; set; }
        public string Trangthai { get; set; }

        public DonVi MadonviNavigation { get; set; }
        public Nganh ManganhNavigation { get; set; }
        public ICollection<SinhVien> SinhVien { get; set; }
    }
}
