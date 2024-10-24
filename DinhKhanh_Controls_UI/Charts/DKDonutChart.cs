using DinhKhanh_Controls_UI.Animation;
using DinhKhanh_Controls_UI.Enums;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DinhKhanh_Controls_UI.Charts
{
    public class DKDonutChart : Control
    {
        public DKDonutChart()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            animationManager = new AnimationManager
            {

                Increment = 0.07
            };

            animationManager.AnimationProgress += sender => Invalidate();

            if (useAnimation)
                animationManager.StartNewAnimation(AnimationType.In);
        }

        bool useAnimation = true;
        public bool UseAnimation
        {
            get { return useAnimation; }
            set
            {
                useAnimation = value;
                Invalidate();
            }
        }

        List<ChartItem> items { get; set; } = new List<ChartItem>();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<ChartItem> Items
        {
            get { return items; }
            set
            {
                items = value;
                if (useAnimation)
                    animationManager.StartNewAnimation(AnimationType.In);
                Invalidate();
            }
        }

        int arcWidth = 5;
        public int ArcWidth
        {
            get { return arcWidth; }
            set
            {
                arcWidth = value;
                Invalidate();
            }
        }

        int chartSize = 100;
        public int ChartSize
        {
            get { return chartSize; }
            set
            {
                chartSize = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            StringFormat n = new StringFormat();
            n.Alignment = StringAlignment.Center;
            n.LineAlignment = StringAlignment.Center;
            n.Trimming = StringTrimming.EllipsisCharacter;
            if (Items == null || Items.Count == 0)
            {
                e.Graphics.FillRectangle(Brushes.White, 0, 0, this.Width, this.Height);
                e.Graphics.DrawString("Không có dữ liệu ;))\nTự thêm bằng code", new Font("Arial", 12), Brushes.Black, new RectangleF(0, 0, Width, Height), n);
                return;
            }


            // Vẽ biểu đồ donut
            var chartBitmap = TaoBieuDo_BangBitmap();   // Thực ra là vẽ bitmap ;)))
            int centerX = this.Width / 2;  // Nằm giữa control
            int centerY = this.Height / 2 - chartSize / 2;  // Nằm giữa chiều dọc

            // Vẽ biểu đồ phía bên trái
            e.Graphics.DrawImage(chartBitmap, centerX - (legendVisible ? chartSize - 20 : chartSize / 2), centerY);

            if (legendVisible)
                // Vẽ chú thích phía bên phải
                DrawLegend(e.Graphics, centerX + 20, centerY);

            chartBitmap?.Dispose();

        }

        bool legendVisible = true;
        public bool LegendVisible
        {
            get { return legendVisible; }
            set
            {
                legendVisible = value;
                Invalidate();
            }
        }

        AnimationManager animationManager;

        public void ReloadData()
        {
            if (useAnimation)
                animationManager.StartNewAnimation(AnimationType.In);
        }

        public Bitmap TaoBieuDo_BangBitmap()
        {
            // Create a bitmap with control size
            Bitmap bmp = new Bitmap(chartSize, this.chartSize);
            bmp.MakeTransparent();
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                if (Items == null || Items.Count == 0)
                    return bmp;

                float total = Items.Sum(x => (float)x.Value);
                float startAngle = -90 + (float)animationManager.GetProgress() * 90;
                float sweepAngle = 0;

                Rectangle rect = new Rectangle(0, 0, chartSize - 1, chartSize - 1);
                rect.Inflate(-arcWidth, -arcWidth);
                for (int i = 0; i < Items.Count; i++)
                {
                    sweepAngle = (float)(Items[i].Value / total) * 360 * (float)(useAnimation ? animationManager.GetProgress() : 1);
                    using (SolidBrush brush = new SolidBrush(Items[i].Color))
                    using (var pen = new Pen(Items[i].Color, ArcWidth)
                    {
                        Alignment = System.Drawing.Drawing2D.PenAlignment.Inset,
                        EndCap = System.Drawing.Drawing2D.LineCap.Round,
                        StartCap = System.Drawing.Drawing2D.LineCap.Round
                    })
                    {
                        g.DrawArc(pen, rect, startAngle, sweepAngle);
                    }
                    startAngle += sweepAngle;
                }
            }

            return bmp;
        }

        // Hàm này để vẽ các chú thích á
        private void DrawLegend(Graphics g, int xStart, int yStart)
        {
            int legendHeight = 20; // Chiều cao của mỗi mục chú thích
            int spacing = 10;      // Khoảng cách giữa các mục chú thích

            for (int i = 0; i < Items.Count; i++)
            {
                var item = Items[i];

                using (SolidBrush brush = new SolidBrush(item.Color))
                {
                    g.FillRectangle(brush, xStart, yStart + (legendHeight + spacing) * i, 15, 15);
                }

                using (Font font = new Font("Arial", 10))
                {
                    g.DrawString($"{item.Name}: {item.Value}", font, Brushes.Black, xStart + 20, yStart + (legendHeight + spacing) * i);
                }
            }
        }
    }


}
