using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Thu_Vien.DuLieu
{
    [Serializable]
    public class ThongTin_NhaXuatBan
    {
        public string MaNhaXuatBan { get; set; }
        public string TenNhaXuatBan { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
    }
}
