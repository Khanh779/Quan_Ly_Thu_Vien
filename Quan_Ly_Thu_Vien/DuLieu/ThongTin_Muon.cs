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
        public Dictionary<string, ThongTin_Sach> DanhSach_SachMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }

        public ThongTin_Muon()
        {

        }

        public ThongTin_Muon(DateTime ngayMuon, DateTime ngayTra)
        {
            NgayMuon = ngayMuon;
            NgayTra = ngayTra;
        }
      
    }
}
