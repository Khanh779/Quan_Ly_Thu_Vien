using DinhKhanh_Controls_UI.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DinhKhanh_Controls_UI.Buttons
{
    public partial class DKControlBoxForm : Control
    {
        bool isHovered = false;
        public DKControlBoxForm()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);
        }

        ControlBoxStyle controlBoxStyle = ControlBoxStyle.Close;
        public ControlBoxStyle ControlBoxStyle
        {
            get => controlBoxStyle;
            set
            {
                controlBoxStyle = value;
                Invalidate();
            }
        }

        int iconSize = 10;
        public int IconSize
        {
            get => iconSize;
            set
            {
                iconSize = value;
                Invalidate();
            }
        }

        Color iconNormalColor = Color.Gray;
        public Color IconNormalColor
        {
            get => iconNormalColor;
            set
            {
                iconNormalColor = value;
                Invalidate();
            }
        }

        Color iconHoverColor = Color.Red;
        public Color IconHoverColor
        {
            get => iconHoverColor;
            set
            {
                iconHoverColor = value;
                Invalidate();
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (controlBoxStyle == ControlBoxStyle.Close)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            }

            DrawControlBoxButton(e.Graphics, controlBoxStyle, Width / 2 - iconSize / 2, Height / 2 - iconSize / 2);
        }



        private void DrawControlBoxButton(Graphics g, ControlBoxStyle style, float x, float y)
        {
            using (Pen pen = new Pen(isHovered ? iconHoverColor : iconNormalColor, 1))
            {
                int size = iconSize;

                switch (style)
                {
                    case ControlBoxStyle.Minimize:
                        g.DrawLine(pen, x, y + size / 2, x + size, y + size / 2);
                        break;

                    case ControlBoxStyle.Maximize_Restore:
                        if (form != null)
                        {
                            switch (form.WindowState)
                            {
                                case FormWindowState.Normal:
                                    g.DrawRectangle(pen, x, y, size, size);
                                    break;
                                case FormWindowState.Maximized:
                                    g.DrawRectangle(pen, x, y, size, size);
                                    g.DrawLine(pen, x + size / 4, y + size / 2, x + 3 * size / 4, y + size / 2);
                                    break;
                            }
                        }
                        else
                            g.DrawRectangle(pen, x, y, size, size);
                        break;

                    case ControlBoxStyle.Close:
                        g.DrawLine(pen, x, y, x + size, y + size);
                        g.DrawLine(pen, x + size, y, x, y + size);
                        break;
                }
            }
        }

        Form form;
        public Form Form
        {
            get => form;
            set
            {
                form = value;
            }
        }


        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button == MouseButtons.Left)
            {
                if (form != null)
                {
                    switch (controlBoxStyle)
                    {
                        case ControlBoxStyle.Minimize:
                            form.WindowState = FormWindowState.Minimized;
                            break;

                        case ControlBoxStyle.Maximize_Restore:
                            if (form.WindowState == FormWindowState.Normal)
                            {
                                form.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                                form.WindowState = FormWindowState.Maximized;
                            }
                            else
                            {
                                form.MaximumSize = new Size(0, 0);
                                form.WindowState = FormWindowState.Normal;
                            }
                            break;

                        case ControlBoxStyle.Close:
                            form.Close();
                            break;
                    }

                }
            }
        }
    }
}
