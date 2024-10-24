using DinhKhanh_Controls_UI.Animation;
using DinhKhanh_Controls_UI.Charts;
using DinhKhanh_Controls_UI.Enums;
using DinhKhanh_Controls_UI.Helper;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace DinhKhanh_Controls_UI.Progresses
{
    public partial class DKStackBarChart : Control
    {
        public DKStackBarChart()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            animationManager = new AnimationManager
            {
                Increment = 0.05
            };
            animationManager.AnimationProgress += sender => Invalidate();

            if (!DesignMode)
                animationManager.StartNewAnimation(AnimationType.In);
        }

        public List<ChartItem> Items = new List<ChartItem>();

        AnimationManager animationManager;

        private int radius = 5;
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate(); // Redraw when radius is changed
            }
        }

        int itemRadius = 5;
        public int ItemRadius
        {
            get { return itemRadius; }
            set
            {
                itemRadius = value;
                Invalidate(); // Redraw when item radius is changed
            }
        }

        private int borderThickness = 0;
        public int BorderThickness
        {
            get { return borderThickness; }
            set
            {
                borderThickness = value;
                Invalidate(); // Redraw when border thickness is changed
            }
        }

        private Color borderColor = Color.Gray;
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate(); // Redraw when border color is changed
            }
        }

        public void ReloadData()
        {
            animationManager.StartNewAnimation(AnimationType.In);
        }

        bool useTransparent = false;
        public bool UseTransparent
        {
            get { return useTransparent; }
            set
            {
                useTransparent = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            if (useTransparent)
                GraphicsHelper.MakeTransparent(this, e.Graphics);

            if (Items == null || Items.Count == 0)
            {
                e.Graphics.FillRectangle(Brushes.White, ClientRectangle);
                e.Graphics.DrawString("Ko có dữ liệu ;))", Font, Brushes.Black, ClientRectangle, new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                e.Graphics.DrawRectangle(Pens.Black, 0, 0, Width, Height);
                return;
            }

            using (Bitmap bitmap = new Bitmap(Width - 2, Height))
            using (Graphics g = Graphics.FromImage(bitmap))
            using (GraphicsPath gp = GraphicsHelper.GetRoundPath(new Rectangle(0, 0, Width, Height), radius))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                float total = (float)Items.Sum(x => x.Value); // Tôi tính tổng các giá trị trong Items ấy
                if (total == 0) return;

                float startX = 0f;

                for (int i = 0; i < Items.Count; i++)
                {
                    var item = Items[i]; // Lấy item tại vị trí i
                    float itemWidth = (float)(item.Value / total) * (Width - 2 + radius * 2); // Tính toán chiều rộng của mỗi item
                    itemWidth *= (float)animationManager.GetProgress(); // Tính toán chiều rộng của mỗi item dựa vào animation

                    RectangleF rect = new RectangleF(startX, 0, itemWidth - 2, Height);

                    // Vẽ từng item
                    using (SolidBrush brush = new SolidBrush(item.Color))
                    using (GraphicsPath gpv = GraphicsHelper.GetRoundPath(rect, itemRadius, borderThickness))
                    {
                        g.FillPath(brush, gpv);
                    }

                    startX += itemWidth - radius; // Cập nhật lại vị trí bắt đầu của item tiếp theo
                }

                if (borderThickness > 0)
                {
                    using (GraphicsPath bgp = GraphicsHelper.GetRoundPath(new Rectangle(0, 0, Width - 2, Height), radius, borderThickness))
                    using (Pen pen = new Pen(borderColor, borderThickness))
                        g.DrawPath(pen, bgp);
                }

                using (TextureBrush brush = new TextureBrush(bitmap))
                {
                    brush.WrapMode = WrapMode.Clamp;
                    e.Graphics.FillPath(brush, gp);
                }
            }


        }
    }
}
