using DinhKhanh_Controls_UI.Forms;
using Quan_Ly_Thu_Vien.Tab_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Thu_Vien
{
    public partial class Form1 : TemplateForm
    {

        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new Form1();
                }
                _obj.BringToFront();
                return _obj;
            }
        }

        public Form1()
        {
            InitializeComponent();
            _obj = this;

            Opacity = 0;
            timerShowAnimation = new Timer();
            timerShowAnimation.Interval = 10;
            timerShowAnimation.Tick += TimerShowAnimation_Tick; ;
        }

        private void TimerShowAnimation_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                timerShowAnimation.Stop();
            }
            Opacity += 0.02;
        }

        Timer timerShowAnimation;


        private void Form1_Load(object sender, EventArgs e)
        {
            timerShowAnimation.Start();

            ThucHien_XuLy.ReadBinaryFile();

            PN_Tabs.Controls.Add(BookManager_UC.Instance);
            BookManager_UC.Instance.Dock = DockStyle.Fill;
        }

        private void btn_Nav0_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!PN_Tabs.Controls.Contains(BookManager_UC.Instance))
                {
                    PN_Tabs.Controls.Clear();
                    PN_Tabs.Controls.Add(BookManager_UC.Instance);
                    BookManager_UC.Instance.Dock = DockStyle.Fill;
                    BookManager_UC.Instance.BringToFront();
                }
            }

        }

        private void dkButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!PN_Tabs.Controls.Contains(MuonTra_UC.Instance))
                {
                    PN_Tabs.Controls.Clear();
                    PN_Tabs.Controls.Add(MuonTra_UC.Instance);
                    MuonTra_UC.Instance.Dock = DockStyle.Fill;
                    MuonTra_UC.Instance.BringToFront();
                }
            }
        }

        private void dkButton2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            ThucHien_XuLy.WriteBinaryFile();
            Login_Form.Instance.Show();
        }
    }
}
