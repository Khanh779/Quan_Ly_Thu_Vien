using System.ComponentModel;
using System.Windows.Forms;

namespace DinhKhanh_Controls_UI.Buttons
{
    public class DKDragForm : Component
    {
        public DKDragForm()
        {
        }

        private Control control;
        public Control Control
        {
            get => control;
            set
            {
                control = value;
                // Kiểm tra xem có khác null ko? Nếu control = null (tương đương ko có control nào được gán vô ) thì ko thêm các sự kiện dưới
                if (control != null)
                {
                    control.MouseDown += Control_MouseDown;
                    control.MouseMove += Control_MouseMove;
                    control.MouseUp += Control_MouseUp;
                }
            }
        }

        private Form form;
        public Form Form
        {
            get => form;
            set
            {
                form = value;
            }
        }

        // Các sự kiện này xuất phát từ control mà đã gán, bao gồm khi trỏ chuột di chuyển, thả chuột, nhấn - giữ chuột
        // Tuy nhiên ở đây nếu ko có điều kiện Left thì nó sẽ lấy tất cả nút chuột, nên cần phải kiểm tra xem nút chuột nào được nhấn
        // Nếu là chuột trái thì mới thực hiện các sự kiện ấy ông

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && e.Button == MouseButtons.Left && form != null)   // Kiểm tra xem nếu là chuột trái và form !=null (tương đương có form đã được gán) thì thực hiện
            {
                form.Location = new System.Drawing.Point(e.X + form.Location.X - x, e.Y + form.Location.Y - y);
            }
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && form != null)
            {
                isMouseDown = true;
                x = e.X;
                y = e.Y;
            }
        }

        private bool isMouseDown = false;
        private int x, y;
    }
}
