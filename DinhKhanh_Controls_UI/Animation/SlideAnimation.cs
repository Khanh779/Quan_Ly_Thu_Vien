using DinhKhanh_Controls_UI.Enums;
using System.Drawing;
using System.Windows.Forms;

namespace DinhKhanh_Controls_UI.Animation
{
    public class SlideAnimation : AnimationManager
    {

        public SlideAnimation()
        {
            Increment = 0.07;

        }


        public Control Control1 { get; set; }
        public Control Control2 { get; set; }
        public Control ControlParent { get; set; }



        public new void StartNewAnimation(AnimationType animationType)
        {
            base.StartNewAnimation(animationType);
        }


        void DoSlide()
        {
            // Tạo graphics và bitmap cho hoạt ảnh
            var _slideGraphics = Graphics.FromHwnd(ControlParent != null ? ControlParent.Handle : Control2.Handle);
            var _slideBitmap = new Bitmap(Control1.Width + Control2.Width, Control1.Height);
            _slideBitmap.MakeTransparent();

            // Vẽ các control vào bitmap dựa trên hướng
            //if (moveBack)
            //{
            //    Control2.DrawToBitmap(_slideBitmap, new Rectangle(0, 0, Control2.Width, Control2.Height));
            //    Control1.DrawToBitmap(_slideBitmap, new Rectangle(Control2.Width, 0, Control1.Width, Control1.Height));
            //}
            //else
            //{
            //    Control1.DrawToBitmap(_slideBitmap, new Rectangle(0, 0, Control1.Width, Control1.Height));
            //    Control2.DrawToBitmap(_slideBitmap, new Rectangle(Control1.Width, 0, Control2.Width, Control2.Height));
            //}

            foreach (Control c in Control2.Controls)
            {
                c.Hide();
            }


            // Cập nhật hàm vẽ khi hoạt ảnh diễn ra
            AnimationProgress += (alpha) =>
            {

                // Vẽ bitmap với độ alpha cho hiệu ứng mờ
                if (_slideGraphics != null && _slideBitmap != null)
                    _slideGraphics.DrawImage(_slideBitmap, new PointF(0, Control2.Height - (float)GetProgress() * Control2.Height));
                Control2.Invalidate();

            };

            // Hàm hoàn thành sau khi hoạt ảnh kết thúc
            Complete += () =>
            {
                foreach (Control c in Control2.Controls)
                {
                    c.Show(); // Hiện lại các control trong control2
                }
                Control2.Invalidate();

                _slideGraphics.Dispose();
                _slideGraphics = null;

                _slideBitmap.Dispose();
                _slideBitmap = null;
            };



        }

        private void AnimationManager_AnimationProgress(object obj)
        {
            if (ControlParent != null)
            {
                ControlParent.Invalidate();
            }
            Control2.Invalidate();
        }
    }
}
