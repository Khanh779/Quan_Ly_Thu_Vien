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


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Login_Form.Instance.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerShowAnimation.Start();

            PN_Tabs.Controls.Add(BookManager_UC.Instance);
        }
    }
}
