using System;
using System.Collections.Generic;

namespace UserInterface.Models
{
    public partial class ChucVuCanBo
    {
        public string Machucvu { get; set; }
        public string Mssv { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoicapnhat { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Solancapnhat { get; set; }
        public string Trangthai { get; set; }

        public DanhMucChucVu MachucvuNavigation { get; set; }
        public SinhVien MssvNavigation { get; set; }
    }
}
