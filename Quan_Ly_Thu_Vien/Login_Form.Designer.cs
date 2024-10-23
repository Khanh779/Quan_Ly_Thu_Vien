namespace Quan_Ly_Thu_Vien
{
    partial class Login_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_UserName = new DinhKhanh_Controls_UI.TextControls.DKTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Password = new DinhKhanh_Controls_UI.TextControls.DKTextBox();
            this.btn_Login = new DinhKhanh_Controls_UI.Buttons.DKButton();
            this.btn_Close = new DinhKhanh_Controls_UI.Buttons.DKButton();
            this.dkCheckBox1 = new HeCopUI_Framework.Controls.Button.DKCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txt_UserName
            // 
            this.txt_UserName.AcceptReturn = false;
            this.txt_UserName.AcceptTab = false;
            this.txt_UserName.BorderColor = System.Drawing.Color.Gray;
            this.txt_UserName.BorderWidth = 1;
            this.txt_UserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(73)))), ((int)(((byte)(58)))));
            this.txt_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(73)))), ((int)(((byte)(58)))));
            this.txt_UserName.HideSelection = true;
            this.txt_UserName.Image = null;
            this.txt_UserName.ImageAlignRight = false;
            this.txt_UserName.ImageSize = new System.Drawing.Size(20, 20);
            this.txt_UserName.ImageVisible = false;
            this.txt_UserName.Lines = new string[0];
            this.txt_UserName.Location = new System.Drawing.Point(148, 123);
            this.txt_UserName.MaxLength = 32767;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.PasswordChar = '\0';
            this.txt_UserName.ReadOnly = false;
            this.txt_UserName.ShortCutKeysEnabled = true;
            this.txt_UserName.Size = new System.Drawing.Size(187, 24);
            this.txt_UserName.TabIndex = 4;
            this.txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_UserName.TextRenderHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_UserName.UnderlineStyle = true;
            this.txt_UserName.UseAnimation = true;
            this.txt_UserName.WartermarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Watermark = "Nhập tên người dùng";
            this.txt_UserName.WatermarkForeColor = System.Drawing.Color.Gray;
            this.txt_UserName.WordWrap = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên người dùng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Password
            // 
            this.txt_Password.AcceptReturn = false;
            this.txt_Password.AcceptTab = false;
            this.txt_Password.BorderColor = System.Drawing.Color.Gray;
            this.txt_Password.BorderWidth = 1;
            this.txt_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(73)))), ((int)(((byte)(58)))));
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(73)))), ((int)(((byte)(58)))));
            this.txt_Password.HideSelection = true;
            this.txt_Password.Image = null;
            this.txt_Password.ImageAlignRight = false;
            this.txt_Password.ImageSize = new System.Drawing.Size(20, 20);
            this.txt_Password.ImageVisible = false;
            this.txt_Password.Lines = new string[0];
            this.txt_Password.Location = new System.Drawing.Point(148, 160);
            this.txt_Password.MaxLength = 32767;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.ReadOnly = false;
            this.txt_Password.ShortCutKeysEnabled = true;
            this.txt_Password.Size = new System.Drawing.Size(187, 24);
            this.txt_Password.TabIndex = 6;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Password.TextRenderHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_Password.UnderlineStyle = true;
            this.txt_Password.UseAnimation = true;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.WartermarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Watermark = "Nhập mật khẩu";
            this.txt_Password.WatermarkForeColor = System.Drawing.Color.Gray;
            this.txt_Password.WordWrap = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Login.AnimationMode = DinhKhanh_Controls_UI.Enums.AnimationMode.ColorTransition;
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
            this.btn_Login.Location = new System.Drawing.Point(148, 233);
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
            this.btn_Login.TabIndex = 51;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.TextHoverColor = System.Drawing.Color.White;
            this.btn_Login.TextNormalColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Login.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Login.TextPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Login.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_Login.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Login_MouseClick);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.AnimationMode = DinhKhanh_Controls_UI.Enums.AnimationMode.ColorTransition;
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
            this.btn_Close.Location = new System.Drawing.Point(244, 233);
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
            this.btn_Close.TabIndex = 52;
            this.btn_Close.Text = "Đóng";
            this.btn_Close.TextHoverColor = System.Drawing.Color.White;
            this.btn_Close.TextNormalColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Close.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Close.TextPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Close.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Close_MouseClick);
            // 
            // dkCheckBox1
            // 
            this.dkCheckBox1.BorderBox = System.Drawing.Color.Transparent;
            this.dkCheckBox1.CheckBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.dkCheckBox1.CheckBoxColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.dkCheckBox1.CheckBoxGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dkCheckBox1.CheckColor = System.Drawing.Color.White;
            this.dkCheckBox1.Checked = false;
            this.dkCheckBox1.CheckedBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.dkCheckBox1.CheckedBoxColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(133)))), ((int)(((byte)(108)))));
            this.dkCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dkCheckBox1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.dkCheckBox1.DisabledCheckBoxColor = System.Drawing.Color.Gray;
            this.dkCheckBox1.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.dkCheckBox1.EnabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.dkCheckBox1.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.dkCheckBox1.Location = new System.Drawing.Point(12, 195);
            this.dkCheckBox1.Name = "dkCheckBox1";
            this.dkCheckBox1.RippleAlpha = 60;
            this.dkCheckBox1.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.dkCheckBox1.Size = new System.Drawing.Size(128, 28);
            this.dkCheckBox1.TabIndex = 53;
            this.dkCheckBox1.Text = "Hiện mật khẩu";
            this.dkCheckBox1.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.dkCheckBox1.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.dkCheckBox1.UnCheckedBoxColor = System.Drawing.Color.DimGray;
            this.dkCheckBox1.CheckedChanged += new System.EventHandler(this.dkCheckBox1_CheckedChanged);
            // 
            // Login_Form
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(73)))), ((int)(((byte)(58)))));
            this.BorderSize = 1;
            this.ClientSize = new System.Drawing.Size(357, 279);
            this.Controls.Add(this.dkCheckBox1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconControlBoxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(138)))));
            this.IconControlBoxNormalColor = System.Drawing.Color.WhiteSmoke;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.Opacity = 0.8D;
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Quản lý thư viện";
            this.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(73)))), ((int)(((byte)(58)))));
            this.TitleForeColor = System.Drawing.Color.White;
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txt_UserName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_Password, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btn_Login, 0);
            this.Controls.SetChildIndex(this.btn_Close, 0);
            this.Controls.SetChildIndex(this.dkCheckBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DinhKhanh_Controls_UI.TextControls.DKTextBox txt_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DinhKhanh_Controls_UI.TextControls.DKTextBox txt_Password;
        private DinhKhanh_Controls_UI.Buttons.DKButton btn_Login;
        private DinhKhanh_Controls_UI.Buttons.DKButton btn_Close;
        private HeCopUI_Framework.Controls.Button.DKCheckBox dkCheckBox1;
    }
}