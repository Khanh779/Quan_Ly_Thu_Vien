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

        public ThongTin_Sach()
        {

        }

        public ThongTin_Sach(string maSach, string tenSach, string tenTacGia, ThongTin_LoaiSach loaiSach, ThongTin_NhaXuatBan nhaXB, int namXB, Bitmap hinhAnh = null)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TenTacGia = tenTacGia;
            LoaiSach = loaiSach;
            NhaXuatBan = nhaXB;
            NamXuatBan = namXB;
            HinhAnh = hinhAnh;
        }
    }


}
