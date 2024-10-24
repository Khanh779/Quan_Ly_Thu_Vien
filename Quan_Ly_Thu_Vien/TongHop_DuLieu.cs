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
        public  Dictionary<string, ThongTin_NguoiMuon> DanhSach_NguoiMuon = new Dictionary<string, ThongTin_NguoiMuon>();
        public  Dictionary<string,ThongTin_Sach> DanhSach_Sach = new Dictionary<string, ThongTin_Sach>();
    }
}
