using Quan_Ly_Thu_Vien.DuLieu;
using Quan_Ly_Thu_Vien.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Thu_Vien.Tab_Pages
{
    public partial class BookManager_UC : UserControl
    {
        static BookManager_UC _obj;
        public static BookManager_UC Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new BookManager_UC();
                }
                return _obj;
            }
        }


        public BookManager_UC()
        {
            InitializeComponent();
            _obj = this;
        }

        HashSet<ThongTin_Sach> danhSachTamHash;

        private void BookManager_UC_Load(object sender, EventArgs e)
        {
            FLP_BookList.Controls.Clear();
            danhSachTamHash = ThucHien_XuLy.TongHopDuLieu.DanhSach_Sach.Values.ToHashSet();
            foreach (var item in danhSachTamHash)
            {
                var a = ThucHien_XuLy.ButtonGradient();
                a.Image = item.HinhAnh == null ? Properties.Resources.icons8_read_100 : item.HinhAnh;
                a.Font = new Font("Segoe UI", 12);
                a.Text = item.TenSach + "\n(" + item.MaSach + ")";
                a.Tag = item;
                FLP_BookList.Controls.Add(a);
            }
            LB_NumBook.Text = "Tổng số sách: " + FLP_BookList.Controls.Count;
        }

        private void btn_Add_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                new Add_Book_Form().ShowDialog();
            }
        }

        private void txt_FindBook_TextChanged(object sender, EventArgs e)
        {

            FLP_BookList.Controls.Clear();

            if (txt_FindBook.Text != string.Empty)
            {
                string searchText = txt_FindBook.Text.ToLower();
                HashSet<ThongTin_Sach> filteredBooks = new HashSet<ThongTin_Sach>();

                // Duyệt qua tất cả sách và thêm vào HashSet nếu thoả mãn điều kiện
                foreach (var item in danhSachTamHash)
                    if (item.TenSach.ToLower().Contains(searchText) || item.MaSach.ToLower().Contains(searchText))
                        filteredBooks.Add(item);

                foreach (var item in filteredBooks)
                {
                    var a = ThucHien_XuLy.ButtonGradient();
                    a.Image = item.HinhAnh == null ? Properties.Resources.icons8_read_100 : item.HinhAnh;
                    a.Font = new Font("Segoe UI", 12);
                    a.Text = item.TenSach + "\n(" + item.MaSach + ")";
                    a.Tag = item;
                    FLP_BookList.Controls.Add(a);
                }
            }
            else
            {
                foreach (var item in danhSachTamHash)
                {
                    var a = ThucHien_XuLy.ButtonGradient();
                    a.Image = item.HinhAnh == null ? Properties.Resources.icons8_read_100 : item.HinhAnh;
                    a.Font = new Font("Segoe UI", 12);
                    a.Text = item.TenSach + "\n(" + item.MaSach + ")";
                    a.Tag = item;
                    FLP_BookList.Controls.Add(a);
                }
            }

            LB_NumBook.Text = "Tổng số sách: " + FLP_BookList.Controls.Count + (txt_FindBook.Text != string.Empty ? " (" + txt_FindBook.Text + ")" : "");
        }

    }
}
