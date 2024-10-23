using Quan_Ly_Thu_Vien.DuLieu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Thu_Vien
{
    [Serializable]
    public class TongHop_DuLieu
    {
        public  List<ThongTin_NguoiMuon> DanhSach_NguoiMuon = new List<ThongTin_NguoiMuon>();
        public  List<ThongTin_Sach> DanhSach_Sach = new List<ThongTin_Sach>();
    }
}
