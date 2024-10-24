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
    public partial class MuonTra_UC : UserControl
    {

        static MuonTra_UC _obj;
        public static MuonTra_UC Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new MuonTra_UC();
                }
                return _obj;
            }
        }

        public MuonTra_UC()
        {
            InitializeComponent();
            _obj = this;
        }

        private void MuonTra_UC_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var item in ThucHien_XuLy.TongHopDuLieu.DanhSach_NguoiMuon.Values)
            {
                ListViewItem lvi = new ListViewItem(item.MaNguoiMuon.ToString());
                lvi.SubItems.Add(item.HoTen.ToString());
                lvi.SubItems.Add(item.SoDienThoai.ToString());
                lvi.SubItems.Add(item.Email.ToString());
                lvi.SubItems.Add(item.DiaChi.ToString());
                lvi.SubItems.Add(item.ThongTin_Muon.NgayMuon.ToString());
                lvi.SubItems.Add(item.ThongTin_Muon.NgayTra.ToString());
                listView1.Items.Add(lvi);
            }
        }
    }
}
