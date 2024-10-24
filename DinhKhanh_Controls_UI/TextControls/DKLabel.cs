using DinhKhanh_Controls_UI.Helper;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace DinhKhanh_Controls_UI.TextControls
{

    public partial class DKLabel : Control
    {
        public DKLabel()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        TextRenderingHint textRendering = TextRenderingHint.ClearTypeGridFit;
        public TextRenderingHint TextRendering
        {
            get { return textRendering; }
            set
            {
                textRendering = value;
                Invalidate();
            }
        }

        Color foreColor1 = Color.Black;
        public Color ForeColor1
        {
            get { return foreColor1; }
            set
            {
                foreColor1 = value;
                Invalidate();
            }
        }

        Color foreColor2 = Color.Black;
        public Color ForeColor2
        {
            get { return foreColor2; }
            set
            {
                foreColor2 = value;
                Invalidate();
            }
        }

        LinearGradientMode gradientMode = LinearGradientMode.BackwardDiagonal;
        public LinearGradientMode GradientMode
        {
            get { return gradientMode; }
            set
            {
                gradientMode = value;
                Invalidate();
            }
        }

        ContentAlignment contentAlignment = ContentAlignment.MiddleCenter;
        public ContentAlignment ContentAlignment
        {
            get { return contentAlignment; }
            set
            {
                contentAlignment = value;
                Invalidate();
            }
        }

        StringTrimming stringTrimming = StringTrimming.Character;
        public StringTrimming StringTrimming
        {
            get { return stringTrimming; }
            set
            {
                stringTrimming = value;
                Invalidate();
            }
        }

        bool useTransparent = true;
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
            e.Graphics.TextRenderingHint = textRendering;

            if (useTransparent)
            {
                GraphicsHelper.MakeTransparent(this, e.Graphics);
            }

            StringFormat sf = new StringFormat();
            TextHelper.SetStringAlign(sf, contentAlignment);
            using (var a = new LinearGradientBrush(ClientRectangle, foreColor1, ForeColor2, gradientMode))
            {
                e.Graphics.DrawString(Text, Font, a, ClientRectangle, sf);
            }

        }
    }
}
