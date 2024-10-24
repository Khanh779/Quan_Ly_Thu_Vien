using System;
using System.Drawing;
using System.Windows.Forms;

namespace DinhKhanh_Controls_UI.Forms
{
    public partial class TemplateForm : Form
    {


        public TemplateForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            base.FormBorderStyle = FormBorderStyle.None;
            LB_TitleForm.Text = this.Text;
            PB_Icon.Image = this.Icon.ToBitmap();
        }

        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                LB_TitleForm.Text = value;
                Invalidate();
            }
        }

        public new virtual Icon Icon
        {
            get => base.Icon;
            set
            {
                base.Icon = value;
                PB_Icon.Image = value.ToBitmap();
                Invalidate();
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (Created)
            {
                // Nếu Size của Form có chiều cao nhỏ hơn Panel TiTle và Width nhỏ hơn 100 thì không cho resize
                if (this.Size.Height < PN_Title.Height || this.Size.Width < 100)
                {
                    this.Size = new Size(100, PN_Title.Height);
                }
            }
        }

        Color iconControlBoxHover = Color.FromArgb(168, 213, 186);
        public Color IconControlBoxHoverColor
        {
            get { return iconControlBoxHover; }
            set
            {
                iconControlBoxHover = value;
                dkControlBoxForm1.IconHoverColor = value;
                dkControlBoxForm2.IconHoverColor = value;
                dkControlBoxForm3.IconHoverColor = value;
                Invalidate();
            }
        }

        Color iconControlBoxNormalColor = Color.Black;
        public Color IconControlBoxNormalColor
        {
            get
            {
                return iconControlBoxNormalColor;
            }
            set
            {
                iconControlBoxNormalColor = value;
                dkControlBoxForm1.IconNormalColor = value;
                dkControlBoxForm2.IconNormalColor = value;
                dkControlBoxForm3.IconNormalColor = value;
                Invalidate();
            }
        }

        public new bool MaximizeBox
        {
            get => base.MaximizeBox;
            set
            {
                base.MaximizeBox = value;
                dkControlBoxForm2.Visible = value;
                Invalidate();
            }
        }

        public new bool MinimizeBox
        {
            get => base.MinimizeBox;
            set
            {
                base.MinimizeBox = value;
                dkControlBoxForm3.Visible = value;
                Invalidate();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LB_TitleForm.Text = this.Text;
            PB_Icon.Image = this.Icon.ToBitmap();

        }

        Color titleBarColor = Color.Transparent;
        public Color TitleBarColor
        {
            get { return titleBarColor; }
            set
            {
                titleBarColor = value;
                PN_Title.BackColor = value;
                Invalidate();
            }
        }

        Color titleForeColor= Color.Black;
        public Color TitleForeColor
        {
            get { return titleForeColor; }
            set
            {
                titleForeColor = value;
                LB_TitleForm.ForeColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, borderColor, borderSize, ButtonBorderStyle.Solid, borderColor, borderSize, ButtonBorderStyle.Solid, borderColor, borderSize, ButtonBorderStyle.Solid, borderColor, borderSize, ButtonBorderStyle.Solid);
        }

        Color borderColor = Color.FromArgb(168, 213, 186);
        int borderSize = 2;

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                resize = new ReSize(borderSize + 1);
                Padding = new Padding(value);
                Invalidate();
            }
        }

        bool allowResize = true;
        public bool AllowResize
        {
            get { return allowResize; }
            set
            {
                allowResize = value;
                Invalidate();
            }
        }

        ReSize resize = new ReSize();
        protected override void WndProc(ref Message m)
        {
            int x = (int)(m.LParam.ToInt64() & 0xFFFF);               //get x mouse position
            int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);   //get y mouse position  you can gave (x,y) it from "MouseEventArgs" too
            Point pt = PointToClient(new Point(x, y));

            if (m.Msg == 0x84)
            {
                if (allowResize)
                    switch (resize.getMosuePosition(pt, this))
                    {
                        case "l": m.Result = (IntPtr)10; return;  // the Mouse on Left Form
                        case "r": m.Result = (IntPtr)11; return;  // the Mouse on Right Form
                        case "a": m.Result = (IntPtr)12; return;
                        case "la": m.Result = (IntPtr)13; return;
                        case "ra": m.Result = (IntPtr)14; return;
                        case "u": m.Result = (IntPtr)15; return;
                        case "lu": m.Result = (IntPtr)16; return;
                        case "ru": m.Result = (IntPtr)17; return; // the Mouse on Right_Under Form
                        case "": m.Result = pt.Y < 32 /*mouse on title Bar*/ ? (IntPtr)2 : (IntPtr)1; return;

                    }
            }

            base.WndProc(ref m);
        }
    }

    class ReSize
    {

        private bool Above, Right, Under, Left, Right_above, Right_under, Left_under, Left_above;


        int Thickness = 6;  //Thickness of border  u can cheang it
        int Area = 8;     //Thickness of Angle border 


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="thickness">set thickness of form border</param>
        public ReSize(int thickness)
        {
            Thickness = thickness;
        }

        /// <summary>
        /// Constructor set thickness of form border=1
        /// </summary>
        public ReSize()
        {
            Thickness = 10;
        }

        //Get Mouse Position
        public string getMosuePosition(Point mouse, Form form)
        {
            bool above_underArea = mouse.X > Area && mouse.X < form.ClientRectangle.Width - Area; /* |\AngleArea(Left_Above)\(=======above_underArea========)/AngleArea(Right_Above)/| */ //Area===>(==)
            bool right_left_Area = mouse.Y > Area && mouse.Y < form.ClientRectangle.Height - Area;

            bool _Above = mouse.Y <= Thickness;  //Mouse in Above All Area
            bool _Right = mouse.X >= form.ClientRectangle.Width - Thickness;
            bool _Under = mouse.Y >= form.ClientRectangle.Height - Thickness;
            bool _Left = mouse.X <= Thickness;

            Above = _Above && (above_underArea); if (Above) return "a";   /*Mouse in Above All Area WithOut Angle Area */
            Right = _Right && (right_left_Area); if (Right) return "r";
            Under = _Under && (above_underArea); if (Under) return "u";
            Left = _Left && (right_left_Area); if (Left) return "l";


            Right_above =/*Right*/ (_Right && (!right_left_Area)) && /*Above*/ (_Above && (!above_underArea)); if (Right_above) return "ra";     /*if Mouse  Right_above */
            Right_under =/* Right*/((_Right) && (!right_left_Area)) && /*Under*/(_Under && (!above_underArea)); if (Right_under) return "ru";     //if Mouse  Right_under 
            Left_under = /*Left*/((_Left) && (!right_left_Area)) && /*Under*/ (_Under && (!above_underArea)); if (Left_under) return "lu";      //if Mouse  Left_under
            Left_above = /*Left*/((_Left) && (!right_left_Area)) && /*Above*/(_Above && (!above_underArea)); if (Left_above) return "la";      //if Mouse  Left_above

            return "";

        }


    }
}
