using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Thu_Vien.DuLieu
{
    [Serializable]
    public class ThongTin_Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TenTacGia { get; set; }
        public ThongTin_LoaiSach LoaiSach { get; set; }
        public ThongTin_NhaXuatBan NhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }

        public Bitmap HinhAnh { get; set; }
    }


}
