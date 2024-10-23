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
        public List<ThongTin_Sach> DanhSach_SachMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
    }
}
