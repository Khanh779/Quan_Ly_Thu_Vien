using DinhKhanh_Controls_UI.Helper;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DinhKhanh_Controls_UI.Panels
{
    public partial class DKPanel : Panel
    {

        int borderSize = 0;
        Color _panelColor1 = Color.White;
        Color _panelColor2 = Color.White;

        Color _borderColor = Color.Black;

        public Color PanelColor1
        {
            get { return _panelColor1; }
            set { _panelColor1 = value; Invalidate(); }
        }
        public Color PanelColor2
        {
            get { return _panelColor2; }
            set { _panelColor2 = value; Invalidate(); }
        }
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        public int BorderThickness
        {
            get { return borderSize; }
            set { borderSize = value; Invalidate(); }
        }

        int rad = 0;
        public int Radius
        {
            get { return rad; }
            set { rad = value; Invalidate(); }
        }

        LinearGradientMode _gradientMode = LinearGradientMode.Vertical;
        public LinearGradientMode LinearGradientMode
        {
            get { return _gradientMode; }
            set { _gradientMode = value; Invalidate(); }
        }

        Padding shadowPadding = new Padding(0);
        public Padding ShadowPadding
        {
            get { return shadowPadding; }
            set { shadowPadding = value; Invalidate(); }
        }

        Color shadowColor = Color.Black;
        public Color ShadowColor
        {
            get { return shadowColor; }
            set { shadowColor = value; Invalidate(); }
        }

        int shadowAlpha = 120;
        public int ShadowAlpha
        {
            get { return shadowAlpha; }
            set { shadowAlpha = value; Invalidate(); }
        }


        public DKPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            if (ShadowPadding.All != 0)
            {
                using (GraphicsPath sgp = GraphicsHelper.GetRoundPath(ClientRectangle, rad + BorderThickness))
                using (var shadowBitmap = GraphicsHelper.DrawBitmapShadow(ClientRectangle, Color.FromArgb(ShadowAlpha, shadowColor), rad))
                using (var shadowBrush = new TextureBrush(shadowBitmap))
                {
                    e.Graphics.FillPath(shadowBrush, sgp);
                }
            }

            var contentRectangle = new RectangleF(
                shadowPadding.Left,
                shadowPadding.Top,
                Width - shadowPadding.Horizontal, // Tính cả padding trái và phải
                Height - shadowPadding.Vertical    // Tính cả padding trên và dưới
            );

            // Điều chỉnh kích thước Bitmap
            using (Bitmap bitmap = new Bitmap((int)contentRectangle.Right, (int)contentRectangle.Bottom))
            {
                bitmap.MakeTransparent();

                using (GraphicsPath contentPath = GraphicsHelper.GetRoundPath(contentRectangle, rad))
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    // Fill card background with gradient
                    using (var backgroundBrush = new LinearGradientBrush(contentRectangle, PanelColor1, PanelColor2, _gradientMode))
                    {
                        g.FillPath(backgroundBrush, contentPath);
                    }

                    // Fill the bar depending on the alignment
                    //using (var barBrush = new LinearGradientBrush(contentRectangle, BarColor1, BarColor2, angle))
                    //{
                    //    var x = contentRectangle.Left;
                    //    var y = contentRectangle.Top + borderThickness;
                    //    var width = bitmap.Width;
                    //    var height = barThickness;

                    //    switch (contentAlignment)
                    //    {
                    //        case ContentLayoutAlign.Left:
                    //            x = contentRectangle.Left + borderThickness;
                    //            y = contentRectangle.Top;
                    //            width = barThickness;
                    //            height = bitmap.Height;
                    //            break;
                    //        case ContentLayoutAlign.Right:
                    //            x = bitmap.Width - barThickness;
                    //            y = contentRectangle.Top;
                    //            width = barThickness;
                    //            height = bitmap.Height;
                    //            break;
                    //        case ContentLayoutAlign.Bottom:
                    //            y = bitmap.Height - barThickness;
                    //            x = contentRectangle.Left;
                    //            width = bitmap.Width;
                    //            height = barThickness;
                    //            break;
                    //    }

                    //    g.FillRectangle(barBrush, x, y, width, height);
                    //}

                    // Draw border if borderThickness > 0
                    if (borderSize > 0)
                    {
                        using (GraphicsPath borderPath = GraphicsHelper.GetRoundPath(contentRectangle, rad, borderSize))
                        using (var borderPen = new Pen(_borderColor, borderSize))
                        {
                            g.DrawPath(borderPen, borderPath);
                        }
                    }

                    using (var fp = GraphicsHelper.GetRoundPath(new RectangleF(contentRectangle.X, contentRectangle.Y, contentRectangle.Width, contentRectangle.Height), rad))
                    {
                        // Draw the main content using texture brush
                        using (TextureBrush textureBrush = new TextureBrush(bitmap))
                        {
                            textureBrush.WrapMode = WrapMode.Clamp;
                            e.Graphics.FillPath(textureBrush, fp);
                        }

                    }

                }
            }
        }


    }
}
