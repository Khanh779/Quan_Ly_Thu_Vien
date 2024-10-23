using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Thu_Vien.DuLieu
{
    [Serializable]
    public class ThongTin_Muon
    {
        public ThongTin_NguoiMuon NguoiMuon { get; set; }
        public ThongTin_Sach SachMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
    }
}
