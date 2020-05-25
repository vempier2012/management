using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TaiKhoanSinhVien
    {
        public string Mssv { get; set; }
        public string Matkhau { get; set; }
        public string Xacnhanmatkhau { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoicapnhat { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Solancapnhat { get; set; }
        public string Trangthai { get; set; }

        public SinhVien MssvNavigation { get; set; }
    }
}
