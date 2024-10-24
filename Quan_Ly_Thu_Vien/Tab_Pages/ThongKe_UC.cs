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
    public partial class ThongKe_UC : UserControl
    {

        static ThongKe_UC _obj;
        public static ThongKe_UC Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new ThongKe_UC();
                }
                return _obj;
            }
        }

        public ThongKe_UC()
        {
            InitializeComponent();
            _obj = this;
        }

        private void ThongKe_UC_Load(object sender, EventArgs e)
        {

        }
    }
}
