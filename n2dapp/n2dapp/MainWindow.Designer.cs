namespace N2D
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pnlTitlebar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tBtnMin = new N2D.AppCore.UX.TitlebarButton();
            this.tBtnSz = new N2D.AppCore.UX.TitlebarButton();
            this.tBtnQuit = new N2D.AppCore.UX.TitlebarButton();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblSelectedImage = new System.Windows.Forms.Label();
            this.lnkAdv = new System.Windows.Forms.LinkLabel();
            this.lnkWiki = new System.Windows.Forms.LinkLabel();
            this.lnkRepair = new System.Windows.Forms.LinkLabel();
            this.lnkDrv = new System.Windows.Forms.LinkLabel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlStatusStrip = new System.Windows.Forms.Panel();
            this.progressStrip = new N2D.AppCore.UX.ProgressStrip();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pnlTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitlebar
            // 
            this.pnlTitlebar.BackColor = System.Drawing.Color.Black;
            this.pnlTitlebar.Controls.Add(this.lblTitle);
            this.pnlTitlebar.Controls.Add(this.tBtnMin);
            this.pnlTitlebar.Controls.Add(this.tBtnSz);
            this.pnlTitlebar.Controls.Add(this.tBtnQuit);
            this.pnlTitlebar.Controls.Add(this.pbxIcon);
            this.pnlTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitlebar.ForeColor = System.Drawing.Color.White;
            this.pnlTitlebar.Location = new System.Drawing.Point(1, 1);
            this.pnlTitlebar.Name = "pnlTitlebar";
            this.pnlTitlebar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pnlTitlebar.Size = new System.Drawing.Size(648, 25);
            this.pnlTitlebar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(20, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(1, 0, 0, 2);
            this.lblTitle.Size = new System.Drawing.Size(493, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "N2D Espressif Flash Utility";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // tBtnMin
            // 
            this.tBtnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.tBtnMin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tBtnMin.FlatAppearance.BorderSize = 0;
            this.tBtnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tBtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tBtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tBtnMin.Image = global::N2D.Properties.Resources.command_minimize_white;
            this.tBtnMin.Location = new System.Drawing.Point(513, 0);
            this.tBtnMin.Name = "tBtnMin";
            this.tBtnMin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.tBtnMin.Size = new System.Drawing.Size(45, 25);
            this.tBtnMin.TabIndex = 4;
            this.tBtnMin.UseVisualStyleBackColor = true;
            this.tBtnMin.Click += new System.EventHandler(this.tBtnMin_Click);
            // 
            // tBtnSz
            // 
            this.tBtnSz.Dock = System.Windows.Forms.DockStyle.Right;
            this.tBtnSz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tBtnSz.FlatAppearance.BorderSize = 0;
            this.tBtnSz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tBtnSz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tBtnSz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tBtnSz.Image = global::N2D.Properties.Resources.command_maximize_white;
            this.tBtnSz.Location = new System.Drawing.Point(558, 0);
            this.tBtnSz.Name = "tBtnSz";
            this.tBtnSz.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.tBtnSz.Size = new System.Drawing.Size(45, 25);
            this.tBtnSz.TabIndex = 3;
            this.tBtnSz.UseVisualStyleBackColor = true;
            this.tBtnSz.Click += new System.EventHandler(this.tBtnSz_Click);
            // 
            // tBtnQuit
            // 
            this.tBtnQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.tBtnQuit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tBtnQuit.FlatAppearance.BorderSize = 0;
            this.tBtnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.tBtnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tBtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tBtnQuit.Image = global::N2D.Properties.Resources.command_exit_white;
            this.tBtnQuit.Location = new System.Drawing.Point(603, 0);
            this.tBtnQuit.Name = "tBtnQuit";
            this.tBtnQuit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.tBtnQuit.Size = new System.Drawing.Size(45, 25);
            this.tBtnQuit.TabIndex = 0;
            this.tBtnQuit.UseVisualStyleBackColor = true;
            this.tBtnQuit.Click += new System.EventHandler(this.tBtnQuit_Click);
            // 
            // pbxIcon
            // 
            this.pbxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxIcon.Image = global::N2D.Properties.Resources.n2d_logo;
            this.pbxIcon.Location = new System.Drawing.Point(2, 0);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(18, 25);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIcon.TabIndex = 1;
            this.pbxIcon.TabStop = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.pnlFooter.Controls.Add(this.lblSelectedImage);
            this.pnlFooter.Controls.Add(this.lnkAdv);
            this.pnlFooter.Controls.Add(this.lnkWiki);
            this.pnlFooter.Controls.Add(this.lnkRepair);
            this.pnlFooter.Controls.Add(this.lnkDrv);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(1, 349);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(648, 50);
            this.pnlFooter.TabIndex = 1;
            // 
            // lblSelectedImage
            // 
            this.lblSelectedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedImage.ForeColor = System.Drawing.Color.Silver;
            this.lblSelectedImage.Location = new System.Drawing.Point(235, 0);
            this.lblSelectedImage.Name = "lblSelectedImage";
            this.lblSelectedImage.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblSelectedImage.Size = new System.Drawing.Size(338, 50);
            this.lblSelectedImage.TabIndex = 8;
            this.lblSelectedImage.Text = "Selected file: N/A";
            this.lblSelectedImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkAdv
            // 
            this.lnkAdv.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.lnkAdv.Dock = System.Windows.Forms.DockStyle.Right;
            this.lnkAdv.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkAdv.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.lnkAdv.Location = new System.Drawing.Point(573, 0);
            this.lnkAdv.Name = "lnkAdv";
            this.lnkAdv.Size = new System.Drawing.Size(75, 50);
            this.lnkAdv.TabIndex = 7;
            this.lnkAdv.TabStop = true;
            this.lnkAdv.Text = "Advanced";
            this.lnkAdv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkAdv.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.lnkAdv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdv_LinkClicked);
            // 
            // lnkWiki
            // 
            this.lnkWiki.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.lnkWiki.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnkWiki.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkWiki.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.lnkWiki.Location = new System.Drawing.Point(160, 0);
            this.lnkWiki.Name = "lnkWiki";
            this.lnkWiki.Size = new System.Drawing.Size(75, 50);
            this.lnkWiki.TabIndex = 6;
            this.lnkWiki.TabStop = true;
            this.lnkWiki.Text = "Online Wiki";
            this.lnkWiki.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkWiki.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.lnkWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWiki_LinkClicked);
            // 
            // lnkRepair
            // 
            this.lnkRepair.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.lnkRepair.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnkRepair.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkRepair.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.lnkRepair.Location = new System.Drawing.Point(80, 0);
            this.lnkRepair.Name = "lnkRepair";
            this.lnkRepair.Size = new System.Drawing.Size(80, 50);
            this.lnkRepair.TabIndex = 5;
            this.lnkRepair.TabStop = true;
            this.lnkRepair.Text = "Troubleshoot";
            this.lnkRepair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkRepair.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.lnkRepair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRepair_LinkClicked);
            // 
            // lnkDrv
            // 
            this.lnkDrv.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.lnkDrv.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnkDrv.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkDrv.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.lnkDrv.Location = new System.Drawing.Point(0, 0);
            this.lnkDrv.Name = "lnkDrv";
            this.lnkDrv.Size = new System.Drawing.Size(80, 50);
            this.lnkDrv.TabIndex = 4;
            this.lnkDrv.TabStop = true;
            this.lnkDrv.Text = "VCP Drivers";
            this.lnkDrv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDrv.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.lnkDrv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDrv_LinkClicked);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(1, 66);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(648, 283);
            this.pnlContent.TabIndex = 3;
            // 
            // pnlStatusStrip
            // 
            this.pnlStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.pnlStatusStrip.Controls.Add(this.progressStrip);
            this.pnlStatusStrip.Controls.Add(this.lbStatus);
            this.pnlStatusStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatusStrip.Location = new System.Drawing.Point(1, 26);
            this.pnlStatusStrip.Name = "pnlStatusStrip";
            this.pnlStatusStrip.Size = new System.Drawing.Size(648, 40);
            this.pnlStatusStrip.TabIndex = 10;
            this.pnlStatusStrip.Visible = false;
            // 
            // progressStrip
            // 
            this.progressStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressStrip.GlowColor = System.Drawing.Color.PaleTurquoise;
            this.progressStrip.Location = new System.Drawing.Point(0, 0);
            this.progressStrip.MarqueeSize = 150;
            this.progressStrip.MarqueeSpeed = 3;
            this.progressStrip.Mode = N2D.AppCore.UX.ProgressStrip.ControlMode.Regular;
            this.progressStrip.Name = "progressStrip";
            this.progressStrip.RegularSpeed = 3;
            this.progressStrip.Size = new System.Drawing.Size(648, 2);
            this.progressStrip.TabIndex = 12;
            this.progressStrip.Value = 0;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoEllipsis = true;
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lbStatus.ForeColor = System.Drawing.Color.Silver;
            this.lbStatus.Location = new System.Drawing.Point(0, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Padding = new System.Windows.Forms.Padding(0, 7, 10, 0);
            this.lbStatus.Size = new System.Drawing.Size(648, 40);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "There are no active tasks";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlStatusStrip);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTitlebar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.pnlTitlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlStatusStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitlebar;
        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.Label lblTitle;
        private AppCore.UX.TitlebarButton tBtnQuit;
        private AppCore.UX.TitlebarButton tBtnMin;
        private AppCore.UX.TitlebarButton tBtnSz;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.LinkLabel lnkDrv;
        private System.Windows.Forms.LinkLabel lnkWiki;
        private System.Windows.Forms.LinkLabel lnkRepair;
        public System.Windows.Forms.Label lblSelectedImage;
        public System.Windows.Forms.Panel pnlStatusStrip;
        public System.Windows.Forms.Label lbStatus;
        public AppCore.UX.ProgressStrip progressStrip;
        public System.Windows.Forms.Panel pnlContent;
        public System.Windows.Forms.LinkLabel lnkAdv;
    }
}

