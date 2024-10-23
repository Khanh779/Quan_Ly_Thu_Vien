using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Thu_Vien.DuLieu
{
    [Serializable]
    public class ThongTin_NguoiMuon
    {
        public string MaNguoiMuon { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }

        public ThongTin_Muon ThongTin_Muon { get; set; }
    }
}
