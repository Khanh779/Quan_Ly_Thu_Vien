using DinhKhanh_Controls_UI.Buttons;
using Quan_Ly_Thu_Vien.DuLieu;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
        static void TaoViDu()
        {
            ThongTin_Sach thongTin_Sach0 = new ThongTin_Sach();
            thongTin_Sach0.MaSach = "0";
            thongTin_Sach0.TenSach = "Sách 0";
            thongTin_Sach0.LoaiSach = new ThongTin_LoaiSach() { TenLoai = Loai_Sach.Ngon_Ngu };
            thongTin_Sach0.TenTacGia = "Tác giả 0";

            ThongTin_Sach thongTin_Sach1 = new ThongTin_Sach();
            thongTin_Sach1.MaSach = "1";
            thongTin_Sach1.TenSach = "Sách 1";
            thongTin_Sach1.LoaiSach = new ThongTin_LoaiSach() { TenLoai = Loai_Sach.Ngon_Ngu };
            thongTin_Sach1.TenTacGia = "Tác giả 1";

            ThongTin_Sach thongTin_Sach2 = new ThongTin_Sach();
            thongTin_Sach2.MaSach = "2";
            thongTin_Sach2.TenSach = "Sách 2";
            thongTin_Sach2.LoaiSach = new ThongTin_LoaiSach() { TenLoai = Loai_Sach.Nghe_Thuat_Va_Giai_Tri };
            thongTin_Sach2.TenTacGia = "Tác giả 2";

            ThongTin_Sach thongTin_Sach3 = new ThongTin_Sach();
            thongTin_Sach3.MaSach = "3";
            thongTin_Sach3.TenSach = "Sách 3";
            thongTin_Sach3.LoaiSach = new ThongTin_LoaiSach() { TenLoai = Loai_Sach.Van_Hoc };
            thongTin_Sach3.TenTacGia = "Tác giả 3";

            TongHopDuLieu.DanhSach_Sach.Add(thongTin_Sach0);
            TongHopDuLieu.DanhSach_Sach.Add(thongTin_Sach1);
            TongHopDuLieu.DanhSach_Sach.Add(thongTin_Sach2);
            TongHopDuLieu.DanhSach_Sach.Add(thongTin_Sach3);




            ThongTin_NguoiMuon nguoiMuon = new ThongTin_NguoiMuon();
            nguoiMuon.MaNguoiMuon = "1";
            nguoiMuon.HoTen = "Nguyễn Văn A";
            nguoiMuon.DiaChi = "Hà Nội";
            nguoiMuon.SoDienThoai = "0123456789";
            nguoiMuon.Email = "NguyenVanA@dk.com";

            ThongTin_Muon thongTinMuon = new ThongTin_Muon();
            thongTinMuon.NgayMuon = DateTime.Now;
            thongTinMuon.NgayTra = DateTime.Now.AddDays(7);

            var dsm = new List<ThongTin_Sach>();
            dsm.Add(new ThongTin_Sach { MaSach = "1", TenSach = "Sách 1", LoaiSach = new ThongTin_LoaiSach() { TenLoai = Loai_Sach.Ngon_Ngu }, TenTacGia = "Tác giả 1" });
            dsm.Add(new ThongTin_Sach { MaSach = "2", TenSach = "Sách 2", LoaiSach = new ThongTin_LoaiSach() { TenLoai = Loai_Sach.Nghe_Thuat_Va_Giai_Tri }, TenTacGia = "Tác giả 2" });
            dsm.Add(new ThongTin_Sach { MaSach = "3", TenSach = "Sách 3", LoaiSach = new ThongTin_LoaiSach() { TenLoai = Loai_Sach.Van_Hoc }, TenTacGia = "Tác giả 3" });
            thongTinMuon.DanhSach_SachMuon = dsm;

            nguoiMuon.ThongTin_Muon = thongTinMuon;


            ThongTin_NguoiMuon nguoiMuon2 = new ThongTin_NguoiMuon();
            nguoiMuon2.MaNguoiMuon = "2";
            nguoiMuon2.HoTen = "Nguyễn Văn B";
            nguoiMuon2.DiaChi = "Hà Nội";
            nguoiMuon2.SoDienThoai = "0123456789";
            nguoiMuon2.Email = "";

            ThongTin_Muon thongTinMuon2 = new ThongTin_Muon();
            thongTinMuon2.NgayMuon = DateTime.Now;
            thongTinMuon2.NgayTra = DateTime.Now.AddDays(7);

            var dsm2 = new List<ThongTin_Sach>();
            dsm2.Add(new ThongTin_Sach
            {
                MaSach = "4",
                TenSach = "Sách 4",
                LoaiSach = new ThongTin_LoaiSach() { TenLoai = Loai_Sach.Ngon_Ngu },
                TenTacGia = "Tác giả 3"
            });
            dsm2.Add(new ThongTin_Sach
            {
                MaSach = "5",
                TenSach = "Sách 5",
                LoaiSach = new ThongTin_LoaiSach() { TenLoai = Loai_Sach.Nghe_Thuat_Va_Giai_Tri },
                TenTacGia = "Tác giả 4"
            });
            dsm2.Add(new ThongTin_Sach
            {
                MaSach = "6",
                TenSach = "Sách 6",
                LoaiSach = new ThongTin_LoaiSach() { TenLoai = Loai_Sach.Van_Hoc },
                TenTacGia = "Tác giả 5"
            });

            thongTinMuon2.DanhSach_SachMuon = dsm2;

            nguoiMuon2.ThongTin_Muon = thongTinMuon2;

            TongHopDuLieu.DanhSach_NguoiMuon.Add(nguoiMuon);
            TongHopDuLieu.DanhSach_NguoiMuon.Add(nguoiMuon2);

        }

        #endregion

        public static DKButton ButtonGradient()
        {
            DKButton button = new DKButton();
            button.Text = "Button";
            button.Size = new System.Drawing.Size(178, 198);

            button.NormalColor1 = System.Drawing.Color.FromArgb(255, 255, 236);
            button.NormalColor2 = System.Drawing.Color.White;

            button.HoverColor1 = System.Drawing.Color.White;
            button.HoverColor2 = System.Drawing.Color.FromArgb(255, 255, 236);

            button.PressColor1 = System.Drawing.Color.FromArgb(245, 245, 226);
            button.PressColor2 = System.Drawing.Color.WhiteSmoke;

            button.AnimationMode = DinhKhanh_Controls_UI.Enums.AnimationMode.ColorTransition;

            button.TextNormalColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button.TextHoverColor = System.Drawing.Color.FromArgb(74, 74, 74);

            button.Radius = 5;
            button.ShadowPadding = new System.Windows.Forms.Padding(5);
            button.ShadowAlpha = 255;
            button.BorderColor = System.Drawing.Color.Silver;
            button.BorderThickness = 1;

            button.ImageOffsetY = 6;
            button.TextPadding=new System.Windows.Forms.Padding(0,8,0,0);
            button.ImageSize= new System.Drawing.Size(70, 90);
            button.ImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;

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
