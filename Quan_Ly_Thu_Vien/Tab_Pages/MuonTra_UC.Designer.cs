namespace Quan_Ly_Thu_Vien.Tab_Pages
{
    partial class MuonTra_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuonTra_UC));
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CH_MaNM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_NgayMuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_NgayTra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tripDetailView = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Close = new DinhKhanh_Controls_UI.Buttons.DKButton();
            this.btn_Login = new DinhKhanh_Controls_UI.Buttons.DKButton();
            this.LB_NumBook = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý người mượn/ trả";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_MaNM,
            this.CH_HoTen,
            this.CH_Sdt,
            this.CH_Email,
            this.CH_DiaChi,
            this.CH_NgayMuon,
            this.CH_NgayTra});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(724, 414);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // CH_MaNM
            // 
            this.CH_MaNM.Text = "Mã người mượn";
            this.CH_MaNM.Width = 114;
            // 
            // CH_HoTen
            // 
            this.CH_HoTen.Text = "Họ và tên";
            this.CH_HoTen.Width = 134;
            // 
            // CH_Sdt
            // 
            this.CH_Sdt.Text = "Số điện thoại";
            this.CH_Sdt.Width = 111;
            // 
            // CH_Email
            // 
            this.CH_Email.Text = "Email";
            this.CH_Email.Width = 89;
            // 
            // CH_DiaChi
            // 
            this.CH_DiaChi.Text = "Địa chỉ";
            this.CH_DiaChi.Width = 78;
            // 
            // CH_NgayMuon
            // 
            this.CH_NgayMuon.Text = "Ngày mượn";
            this.CH_NgayMuon.Width = 94;
            // 
            // CH_NgayTra
            // 
            this.CH_NgayTra.Text = "Ngày trả";
            this.CH_NgayTra.Width = 88;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tripDetailView,
            this.chỉnhSửaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 52);
            // 
            // tripDetailView
            // 
            this.tripDetailView.BackColor = System.Drawing.Color.White;
            this.tripDetailView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tripDetailView.Image = ((System.Drawing.Image)(resources.GetObject("tripDetailView.Image")));
            this.tripDetailView.Name = "tripDetailView";
            this.tripDetailView.Size = new System.Drawing.Size(148, 24);
            this.tripDetailView.Text = "Xem chi tiết";
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.chỉnhSửaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chỉnhSửaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chỉnhSửaToolStripMenuItem.Image")));
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.AnimationMode = DinhKhanh_Controls_UI.Enums.AnimationMode.Ripple;
            this.btn_Close.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btn_Close.BorderThickness = 0;
            this.btn_Close.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Close.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Close.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.btn_Close.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(164)))), ((int)(((byte)(34)))));
            this.btn_Close.Image = null;
            this.btn_Close.ImageOffsetX = 0;
            this.btn_Close.ImageOffsetY = 0;
            this.btn_Close.ImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Close.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Close.Location = new System.Drawing.Point(652, 510);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.NormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(154)))), ((int)(((byte)(24)))));
            this.btn_Close.NormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Close.PressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(144)))), ((int)(((byte)(14)))));
            this.btn_Close.PressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(73)))), ((int)(((byte)(70)))));
            this.btn_Close.Radius = 5;
            this.btn_Close.ShadowAlpha = 120;
            this.btn_Close.ShadowColor = System.Drawing.Color.Black;
            this.btn_Close.ShadowPadding = new System.Windows.Forms.Padding(0);
            this.btn_Close.ShapeType = DinhKhanh_Controls_UI.Enums.ShapeType.RoundedRectangle;
            this.btn_Close.Size = new System.Drawing.Size(91, 32);
            this.btn_Close.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.btn_Close.TabIndex = 62;
            this.btn_Close.Text = "Xoá";
            this.btn_Close.TextHoverColor = System.Drawing.Color.White;
            this.btn_Close.TextNormalColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Close.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Close.TextPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Close.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Login.AnimationMode = DinhKhanh_Controls_UI.Enums.AnimationMode.Ripple;
            this.btn_Login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btn_Login.BorderThickness = 0;
            this.btn_Login.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Login.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Login.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btn_Login.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(73)))), ((int)(((byte)(58)))));
            this.btn_Login.Image = null;
            this.btn_Login.ImageOffsetX = 0;
            this.btn_Login.ImageOffsetY = 0;
            this.btn_Login.ImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Login.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Login.Location = new System.Drawing.Point(555, 510);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.NormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(73)))), ((int)(((byte)(58)))));
            this.btn_Login.NormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btn_Login.PressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(63)))), ((int)(((byte)(48)))));
            this.btn_Login.PressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(73)))), ((int)(((byte)(78)))));
            this.btn_Login.Radius = 5;
            this.btn_Login.ShadowAlpha = 120;
            this.btn_Login.ShadowColor = System.Drawing.Color.Black;
            this.btn_Login.ShadowPadding = new System.Windows.Forms.Padding(0);
            this.btn_Login.ShapeType = DinhKhanh_Controls_UI.Enums.ShapeType.RoundedRectangle;
            this.btn_Login.Size = new System.Drawing.Size(91, 32);
            this.btn_Login.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.btn_Login.TabIndex = 61;
            this.btn_Login.Text = "Thêm";
            this.btn_Login.TextHoverColor = System.Drawing.Color.White;
            this.btn_Login.TextNormalColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Login.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Login.TextPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Login.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // LB_NumBook
            // 
            this.LB_NumBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_NumBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NumBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(73)))), ((int)(((byte)(58)))));
            this.LB_NumBook.Location = new System.Drawing.Point(16, 510);
            this.LB_NumBook.Name = "LB_NumBook";
            this.LB_NumBook.Size = new System.Drawing.Size(178, 19);
            this.LB_NumBook.TabIndex = 60;
            this.LB_NumBook.Text = "Tổng số sách: 50";
            // 
            // MuonTra_UC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.LB_NumBook);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MuonTra_UC";
            this.Size = new System.Drawing.Size(766, 557);
            this.Load += new System.EventHandler(this.MuonTra_UC_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CH_MaNM;
        private System.Windows.Forms.ColumnHeader CH_HoTen;
        private System.Windows.Forms.ColumnHeader CH_Sdt;
        private System.Windows.Forms.ColumnHeader CH_Email;
        private System.Windows.Forms.ColumnHeader CH_DiaChi;
        private System.Windows.Forms.ColumnHeader CH_NgayMuon;
        private System.Windows.Forms.ColumnHeader CH_NgayTra;
        private DinhKhanh_Controls_UI.Buttons.DKButton btn_Close;
        private DinhKhanh_Controls_UI.Buttons.DKButton btn_Login;
        private System.Windows.Forms.Label LB_NumBook;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tripDetailView;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
    }
}
