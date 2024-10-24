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

namespace Quan_Ly_Thu_Vien.Forms
{
    public partial class Add_Book_Form : TemplateForm
    {
        public Add_Book_Form()
        {
            InitializeComponent();

            Text = Application.ProductName + " - Thêm Sách";

            PB_Product.Paint += PB_Product_Paint;
        }

        private void PB_Product_Paint(object sender, PaintEventArgs e)
        {
            // Vẽ viền cho PictureBox
            ControlPaint.DrawBorder(e.Graphics, PB_Product.ClientRectangle, Color.FromArgb(181, 113, 98), ButtonBorderStyle.Dotted);
        }

        private void btn_Close_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                Close();
            }    
        }
    }
}
