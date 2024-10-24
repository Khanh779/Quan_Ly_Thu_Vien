namespace DinhKhanh_Controls_UI.Forms
{
    partial class TemplateForm
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
            this.PN_Title = new System.Windows.Forms.Panel();
            this.PB_Icon = new System.Windows.Forms.PictureBox();
            this.LB_TitleForm = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dkControlBoxForm1 = new DinhKhanh_Controls_UI.Buttons.DKControlBoxForm();
            this.dkControlBoxForm2 = new DinhKhanh_Controls_UI.Buttons.DKControlBoxForm();
            this.dkControlBoxForm3 = new DinhKhanh_Controls_UI.Buttons.DKControlBoxForm();
            this.dkDragForm1 = new DinhKhanh_Controls_UI.Buttons.DKDragForm();
            this.dkDragForm2 = new DinhKhanh_Controls_UI.Buttons.DKDragForm();
            this.dkDragForm3 = new DinhKhanh_Controls_UI.Buttons.DKDragForm();
            this.PN_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PN_Title
            // 
            this.PN_Title.BackColor = System.Drawing.Color.Transparent;
            this.PN_Title.Controls.Add(this.PB_Icon);
            this.PN_Title.Controls.Add(this.LB_TitleForm);
            this.PN_Title.Controls.Add(this.flowLayoutPanel1);
            this.PN_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Title.Location = new System.Drawing.Point(0, 0);
            this.PN_Title.Name = "PN_Title";
            this.PN_Title.Size = new System.Drawing.Size(310, 36);
            this.PN_Title.TabIndex = 2;
            // 
            // PB_Icon
            // 
            this.PB_Icon.Location = new System.Drawing.Point(8, 8);
            this.PB_Icon.Name = "PB_Icon";
            this.PB_Icon.Size = new System.Drawing.Size(20, 20);
            this.PB_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Icon.TabIndex = 3;
            this.PB_Icon.TabStop = false;
            // 
            // LB_TitleForm
            // 
            this.LB_TitleForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_TitleForm.AutoEllipsis = true;
            this.LB_TitleForm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LB_TitleForm.Location = new System.Drawing.Point(32, 6);
            this.LB_TitleForm.Name = "LB_TitleForm";
            this.LB_TitleForm.Size = new System.Drawing.Size(157, 22);
            this.LB_TitleForm.TabIndex = 3;
            this.LB_TitleForm.Text = "LB_TitleForm";
            this.LB_TitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dkControlBoxForm1);
            this.flowLayoutPanel1.Controls.Add(this.dkControlBoxForm2);
            this.flowLayoutPanel1.Controls.Add(this.dkControlBoxForm3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(204, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 4, 5, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(106, 36);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dkControlBoxForm1
            // 
            this.dkControlBoxForm1.ControlBoxStyle = DinhKhanh_Controls_UI.Enums.ControlBoxStyle.Close;
            this.dkControlBoxForm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dkControlBoxForm1.Form = this;
            this.dkControlBoxForm1.IconHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.dkControlBoxForm1.IconNormalColor = System.Drawing.Color.Black;
            this.dkControlBoxForm1.IconSize = 10;
            this.dkControlBoxForm1.Location = new System.Drawing.Point(73, 7);
            this.dkControlBoxForm1.Name = "dkControlBoxForm1";
            this.dkControlBoxForm1.Size = new System.Drawing.Size(25, 25);
            this.dkControlBoxForm1.TabIndex = 1;
            this.dkControlBoxForm1.Text = "dkControlBoxForm1";
            // 
            // dkControlBoxForm2
            // 
            this.dkControlBoxForm2.ControlBoxStyle = DinhKhanh_Controls_UI.Enums.ControlBoxStyle.Maximize_Restore;
            this.dkControlBoxForm2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dkControlBoxForm2.Form = this;
            this.dkControlBoxForm2.IconHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.dkControlBoxForm2.IconNormalColor = System.Drawing.Color.Black;
            this.dkControlBoxForm2.IconSize = 10;
            this.dkControlBoxForm2.Location = new System.Drawing.Point(42, 7);
            this.dkControlBoxForm2.Name = "dkControlBoxForm2";
            this.dkControlBoxForm2.Size = new System.Drawing.Size(25, 25);
            this.dkControlBoxForm2.TabIndex = 2;
            this.dkControlBoxForm2.Text = "dkControlBoxForm2";
            // 
            // dkControlBoxForm3
            // 
            this.dkControlBoxForm3.ControlBoxStyle = DinhKhanh_Controls_UI.Enums.ControlBoxStyle.Minimize;
            this.dkControlBoxForm3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dkControlBoxForm3.Form = this;
            this.dkControlBoxForm3.IconHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.dkControlBoxForm3.IconNormalColor = System.Drawing.Color.Black;
            this.dkControlBoxForm3.IconSize = 10;
            this.dkControlBoxForm3.Location = new System.Drawing.Point(11, 7);
            this.dkControlBoxForm3.Name = "dkControlBoxForm3";
            this.dkControlBoxForm3.Size = new System.Drawing.Size(25, 25);
            this.dkControlBoxForm3.TabIndex = 3;
            this.dkControlBoxForm3.Text = "dkControlBoxForm3";
            // 
            // dkDragForm1
            // 
            this.dkDragForm1.Control = this.PN_Title;
            this.dkDragForm1.Form = this;
            // 
            // dkDragForm2
            // 
            this.dkDragForm2.Control = this.LB_TitleForm;
            this.dkDragForm2.Form = this;
            // 
            // dkDragForm3
            // 
            this.dkDragForm3.Control = this.PB_Icon;
            this.dkDragForm3.Form = this;
            // 
            // TemplateForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(310, 203);
            this.Controls.Add(this.PN_Title);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PN_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DinhKhanh_Controls_UI.Buttons.DKControlBoxForm dkControlBoxForm1;
        private System.Windows.Forms.Panel PN_Title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DinhKhanh_Controls_UI.Buttons.DKControlBoxForm dkControlBoxForm2;
        private DinhKhanh_Controls_UI.Buttons.DKControlBoxForm dkControlBoxForm3;
        private System.Windows.Forms.Label LB_TitleForm;
        private System.Windows.Forms.PictureBox PB_Icon;
        private DinhKhanh_Controls_UI.Buttons.DKDragForm dkDragForm1;
        private DinhKhanh_Controls_UI.Buttons.DKDragForm dkDragForm2;
        private DinhKhanh_Controls_UI.Buttons.DKDragForm dkDragForm3;
    }
}

