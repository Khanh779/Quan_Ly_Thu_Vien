using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DinhKhanh_Controls_UI.Containers
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [Designer(typeof(ScrollableControlDesigner))]
    public class DKCollapsiblePanel : Control
    {
        public event EventHandler CollapsedChanged;

        public DKCollapsiblePanel()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.ContainerControl, true);
            this.DoubleBuffered = true;
            this.Padding = new Padding(10);


        }

        private int titleHeight = 30;
        [Category("Appearance")]
        [Description("Height of the title bar.")]
        public int TitleHeight
        {
            get { return titleHeight; }
            set
            {
                if (value >= 0)
                {
                    titleHeight = value;
                    Invalidate();
                }
            }
        }

        Padding containerPadding
            = new Padding(10);
        [Category("Appearance")]
        [Description("Padding of the container.")]
        public Padding ContainerPadding
        {
            get { return containerPadding; }
            set
            {
                containerPadding = value;
                Invalidate();
            }
        }


        private bool isCollapsed = false;
        [Category("Appearance")]
        [Description("Indicates whether the panel is collapsed.")]
        public bool IsCollapsed
        {
            get { return isCollapsed; }
            set
            {
                if (isCollapsed != value)
                {
                    isCollapsed = value;
                    CollapsedChanged?.Invoke(this, EventArgs.Empty);
                    Invalidate();

                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Parent.BackColor);

            // Vẽ bóng
            using (var shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(shadowBrush, new Rectangle(5, 5, Width, Height));
            }

            // Vẽ border
            e.Graphics.DrawRectangle(Pens.Gray, 0, 0, Width - 1, Height - 1);

            // Vẽ tiêu đề
            using (var titleBrush = new SolidBrush(Color.LightGray))
            {
                e.Graphics.FillRectangle(titleBrush, new Rectangle(0, 0, Width, TitleHeight));
            }

            // Vẽ mũi tên
            DrawArrow(e.Graphics);
        }

        private void DrawArrow(Graphics g)
        {
            Point[] arrowPoints = isCollapsed
                ? new Point[] { new Point(Width / 2, TitleHeight - 10), new Point(Width / 2 - 5, TitleHeight - 5), new Point(Width / 2 + 5, TitleHeight - 5) }
                : new Point[] { new Point(Width / 2, TitleHeight + 10), new Point(Width / 2 - 5, TitleHeight + 15), new Point(Width / 2 + 5, TitleHeight + 15) };

            g.FillPolygon(Brushes.Black, arrowPoints);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }


    }




}

