using DinhKhanh_Controls_UI.Buttons;
using Quan_Ly_Thu_Vien.DuLieu;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Quan_Ly_Thu_Vien
{
    public class ThucHien_XuLy
    {

        public static TongHop_DuLieu TongHopDuLieu = new TongHop_DuLieu();

        public static string DuongDan_MacDinh = "Quan_Ly_ThongTin_NguoiMuon.dk";



        // Tạo các đối tượng mẫu mặc định

        #region Khu vực tạo dữ liệu mẫu lần đầu nếu ko có file dữ liệu

        static ThongTin_Sach NhapThongTinSach(string maSach, string tenSach, string tenTacGia, ThongTin_LoaiSach loaiSach, ThongTin_NhaXuatBan nhaXB, int namXB, Bitmap hinhAnh = null)
        {
            ThongTin_Sach thongTin_Sach = new ThongTin_Sach();
            thongTin_Sach.MaSach = maSach;
            thongTin_Sach.TenSach = tenSach;
            thongTin_Sach.TenTacGia = tenTacGia;
            thongTin_Sach.LoaiSach = loaiSach;
            thongTin_Sach.NhaXuatBan = nhaXB;
            thongTin_Sach.NamXuatBan = namXB;
            thongTin_Sach.HinhAnh = hinhAnh;
            return thongTin_Sach;

        }

        static ThongTin_NguoiMuon NhapThongTin_NguoiMuon(string maNguoiMuon, string hoTen, string diaChi, string soDienThoai, string email, ThongTin_Muon thongTinMuon)
        {
            ThongTin_NguoiMuon thongTin_NguoiMuon = new ThongTin_NguoiMuon();
            thongTin_NguoiMuon.MaNguoiMuon = maNguoiMuon;
            thongTin_NguoiMuon.HoTen = hoTen;
            thongTin_NguoiMuon.DiaChi = diaChi;
            thongTin_NguoiMuon.SoDienThoai = soDienThoai;
            thongTin_NguoiMuon.Email = email;
            thongTin_NguoiMuon.ThongTin_Muon = thongTinMuon;
            return thongTin_NguoiMuon;
        }


        static void TaoViDu()
        {
           
            for (int i = 0; i < 30; i++)
            {
                var b = new ThongTin_LoaiSach();
                b.TenLoai = Loai_Sach.Ton_Giao;
                var a = NhapThongTinSach("MS" + i, "Sách " + i, "Tác giả " + i, b, new ThongTin_NhaXuatBan() { MaNhaXuatBan = "NXB" + i, TenNhaXuatBan = "Nhà xuất bản " + i, DiaChi = "Địa chỉ " + i, SoDienThoai = "Số điện thoại " + i, Email = "Email " + i }, 2000 + i);

                TongHopDuLieu.DanhSach_Sach.Add(a.MaSach, a);
            }

            for (int i = 0; i < 30; i++)
            {
                var c = NhapThongTin_NguoiMuon("NM" + i, "Người mượn " + i, "Địa chỉ " + i, "Số điện thoại " + i, "Email " + i, new ThongTin_Muon()
                {
                    NgayMuon = DateTime.Now,
                    NgayTra = DateTime.Now.AddDays(7),
                    //DanhSach_SachMuon = thongTS
                });
                //thongNM.Add(c.MaNguoiMuon, c);

                if (i % 2 == 0)
                {
                    TongHopDuLieu.DanhSach_NguoiMuon.Add(c.MaNguoiMuon, c);
                }
            }



        }



        #endregion

        public static DKButton ButtonGradient()
        {
            DKButton button = new DKButton();

            button.NormalColor1 = System.Drawing.Color.FromArgb(255, 255, 236);
            button.NormalColor2 = System.Drawing.Color.White;

            button.HoverColor1 = System.Drawing.Color.White;
            button.HoverColor2 = System.Drawing.Color.FromArgb(255, 255, 236);

            button.PressColor1 = System.Drawing.Color.FromArgb(245, 245, 226);
            button.PressColor2 = System.Drawing.Color.WhiteSmoke;

            button.AnimationMode = DinhKhanh_Controls_UI.Enums.AnimationMode.ColorTransition;

            button.TextNormalColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button.TextHoverColor = System.Drawing.Color.FromArgb(74, 74, 74);
            button.TextPressColor = System.Drawing.Color.FromArgb(54, 54, 54);

            button.Radius = 5;
            button.ShadowPadding = new System.Windows.Forms.Padding(5);
            button.ShadowAlpha = 255;
            button.BorderColor = System.Drawing.Color.Silver;
            button.BorderThickness = 1;

            button.ImageOffsetY = 10;
            button.TextPadding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            button.ImageSize = new System.Drawing.Size(70, 90);
            button.ImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            button.Size = new Size(178, 198);

            button.Cursor = System.Windows.Forms.Cursors.Hand;
            button.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;

            return button;
        }

        public static bool ReadBinaryFile()
        {
            try
            {

                FileStream fs = new FileStream(DuongDan_MacDinh, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                TongHopDuLieu = (TongHop_DuLieu)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch
            {
                TaoViDu();
                return false;
            }
        }

        public static bool WriteBinaryFile()
        {
            try
            {
                FileStream fs = new FileStream(DuongDan_MacDinh, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, TongHopDuLieu);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
