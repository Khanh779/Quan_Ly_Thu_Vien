using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Thu_Vien.DuLieu
{
    [Serializable]
    public class ThongTin_LoaiSach
    {
        public int MaLoai
        {
            get { return (int)TenLoai; }
        }
        public Loai_Sach TenLoai { get; set; }

    }

    public enum Loai_Sach
    {
        Khac,

        Khoa_Hoc_Cong_Nghe,
        Khoa_Hoc_Tu_Nhien,
        Khoa_Hoc_Xa_Hoi,
        Ton_Giao,
        Ngon_Ngu,
        Lich_Su_Va_Dia_Ly,
        Nghe_Thuat_Va_Giai_Tri,
        Van_Hoc,
        Triet_Hoc_Va_Tam_Ly_Hoc,
        Y_Hoc
    }
}
