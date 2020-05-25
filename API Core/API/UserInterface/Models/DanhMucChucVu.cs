using System;
using System.Collections.Generic;

namespace UserInterface.Models
{
    public partial class DanhMucChucVu
    {
        public DanhMucChucVu()
        {
            ChucVuCanBo = new HashSet<ChucVuCanBo>();
        }

        public string Machucvu { get; set; }
        public string Tenchucvu { get; set; }
        public string Phanloaichucvu { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoicapnhat { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Solancapnhat { get; set; }
        public string Trangthai { get; set; }

        public ICollection<ChucVuCanBo> ChucVuCanBo { get; set; }
    }
}
