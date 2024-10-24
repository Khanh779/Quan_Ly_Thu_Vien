using DinhKhanh_Controls_UI.Forms;
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
    public partial class Login_Form : TemplateForm
    {

        static Login_Form _obj;
        public static Login_Form Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new Login_Form();
                }
                _obj.BringToFront();
                return _obj;
            }
        }

        public Login_Form()
        {
            InitializeComponent();
            _obj = this;
            // Set the title of the form

            Text= Application.ProductName + " - Đăng nhập";

        }



        private void dkCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = !dkCheckBox1.Checked;
        }

        private void btn_Login_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (txt_UserName.Text == "admin" && txt_Password.Text == "admin")
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1.Instance.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Close_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
         
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng ko?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }


}
