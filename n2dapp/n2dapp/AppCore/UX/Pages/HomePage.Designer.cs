
namespace N2D.AppCore.UX.Pages
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.tlpLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCol3 = new System.Windows.Forms.Panel();
            this.pbxFlash = new System.Windows.Forms.PictureBox();
            this.pnlCol2 = new System.Windows.Forms.Panel();
            this.pbxUsb = new System.Windows.Forms.PictureBox();
            this.pnlCol1 = new System.Windows.Forms.Panel();
            this.lnkSelWeb = new System.Windows.Forms.LinkLabel();
            this.lblDiv = new System.Windows.Forms.Label();
            this.lnkSelFs = new System.Windows.Forms.LinkLabel();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.Line1 = new System.Windows.Forms.Panel();
            this.Line2 = new System.Windows.Forms.Panel();
            this.eBtnFlash = new N2D.AppCore.UX.ExtendedButton();
            this.eBtnSelect = new N2D.AppCore.UX.ExtendedButton();
            this.tlpLayout.SuspendLayout();
            this.pnlCol3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlash)).BeginInit();
            this.pnlCol2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsb)).BeginInit();
            this.pnlCol1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpLayout
            // 
            this.tlpLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpLayout.ColumnCount = 3;
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLayout.Controls.Add(this.pnlCol3, 2, 0);
            this.tlpLayout.Controls.Add(this.pnlCol2, 1, 0);
            this.tlpLayout.Controls.Add(this.pnlCol1, 0, 0);
            this.tlpLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpLayout.Location = new System.Drawing.Point(30, 0);
            this.tlpLayout.Name = "tlpLayout";
            this.tlpLayout.RowCount = 1;
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLayout.Size = new System.Drawing.Size(588, 323);
            this.tlpLayout.TabIndex = 0;
            // 
            // pnlCol3
            // 
            this.pnlCol3.Controls.Add(this.eBtnFlash);
            this.pnlCol3.Controls.Add(this.pbxFlash);
            this.pnlCol3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCol3.Location = new System.Drawing.Point(395, 3);
            this.pnlCol3.Name = "pnlCol3";
            this.pnlCol3.Padding = new System.Windows.Forms.Padding(30, 75, 30, 135);
            this.pnlCol3.Size = new System.Drawing.Size(190, 317);
            this.pnlCol3.TabIndex = 4;
            // 
            // pbxFlash
            // 
            this.pbxFlash.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxFlash.Image = global::N2D.Properties.Resources.bolt_gray;
            this.pbxFlash.Location = new System.Drawing.Point(30, 75);
            this.pbxFlash.Name = "pbxFlash";
            this.pbxFlash.Size = new System.Drawing.Size(130, 50);
            this.pbxFlash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxFlash.TabIndex = 0;
            this.pbxFlash.TabStop = false;
            // 
            // pnlCol2
            // 
            this.pnlCol2.Controls.Add(this.eBtnSelect);
            this.pnlCol2.Controls.Add(this.pbxUsb);
            this.pnlCol2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCol2.Location = new System.Drawing.Point(199, 3);
            this.pnlCol2.Name = "pnlCol2";
            this.pnlCol2.Padding = new System.Windows.Forms.Padding(30, 75, 30, 135);
            this.pnlCol2.Size = new System.Drawing.Size(190, 317);
            this.pnlCol2.TabIndex = 3;
            // 
            // pbxUsb
            // 
            this.pbxUsb.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxUsb.Image = global::N2D.Properties.Resources.usb_gray;
            this.pbxUsb.Location = new System.Drawing.Point(30, 75);
            this.pbxUsb.Name = "pbxUsb";
            this.pbxUsb.Size = new System.Drawing.Size(130, 50);
            this.pbxUsb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxUsb.TabIndex = 0;
            this.pbxUsb.TabStop = false;
            // 
            // pnlCol1
            // 
            this.pnlCol1.Controls.Add(this.lnkSelWeb);
            this.pnlCol1.Controls.Add(this.lblDiv);
            this.pnlCol1.Controls.Add(this.lnkSelFs);
            this.pnlCol1.Controls.Add(this.pbxAdd);
            this.pnlCol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCol1.Location = new System.Drawing.Point(3, 3);
            this.pnlCol1.Name = "pnlCol1";
            this.pnlCol1.Padding = new System.Windows.Forms.Padding(0, 75, 0, 75);
            this.pnlCol1.Size = new System.Drawing.Size(190, 317);
            this.pnlCol1.TabIndex = 0;
            // 
            // lnkSelWeb
            // 
            this.lnkSelWeb.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.lnkSelWeb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkSelWeb.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkSelWeb.LinkColor = System.Drawing.Color.Silver;
            this.lnkSelWeb.Location = new System.Drawing.Point(0, 185);
            this.lnkSelWeb.Name = "lnkSelWeb";
            this.lnkSelWeb.Size = new System.Drawing.Size(190, 20);
            this.lnkSelWeb.TabIndex = 3;
            this.lnkSelWeb.TabStop = true;
            this.lnkSelWeb.Text = "Pick from a list";
            this.lnkSelWeb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkSelWeb.VisitedLinkColor = System.Drawing.Color.Silver;
            this.lnkSelWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelWeb_LinkClicked);
            // 
            // lblDiv
            // 
            this.lblDiv.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiv.Location = new System.Drawing.Point(0, 160);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(190, 25);
            this.lblDiv.TabIndex = 2;
            this.lblDiv.Text = "or";
            this.lblDiv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkSelFs
            // 
            this.lnkSelFs.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.lnkSelFs.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkSelFs.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkSelFs.LinkColor = System.Drawing.Color.Silver;
            this.lnkSelFs.Location = new System.Drawing.Point(0, 125);
            this.lnkSelFs.Name = "lnkSelFs";
            this.lnkSelFs.Size = new System.Drawing.Size(190, 35);
            this.lnkSelFs.TabIndex = 1;
            this.lnkSelFs.TabStop = true;
            this.lnkSelFs.Text = "Choose a file";
            this.lnkSelFs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkSelFs.VisitedLinkColor = System.Drawing.Color.Silver;
            this.lnkSelFs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelFs_LinkClicked);
            // 
            // pbxAdd
            // 
            this.pbxAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxAdd.Image = global::N2D.Properties.Resources.add_white;
            this.pbxAdd.Location = new System.Drawing.Point(0, 75);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(190, 50);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxAdd.TabIndex = 0;
            this.pbxAdd.TabStop = false;
            // 
            // Line1
            // 
            this.Line1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Line1.Location = new System.Drawing.Point(175, 100);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(105, 2);
            this.Line1.TabIndex = 1;
            // 
            // Line2
            // 
            this.Line2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Line2.Location = new System.Drawing.Point(370, 100);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(105, 2);
            this.Line2.TabIndex = 2;
            // 
            // eBtnFlash
            // 
            this.eBtnFlash.Angle = 0;
            this.eBtnFlash.BackColor = System.Drawing.Color.Transparent;
            this.eBtnFlash.Background = System.Drawing.Color.DodgerBlue;
            this.eBtnFlash.BackgroundOnClick = System.Drawing.Color.DeepSkyBlue;
            this.eBtnFlash.BackgroundOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.eBtnFlash.Border = 1;
            this.eBtnFlash.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.eBtnFlash.BorderColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.eBtnFlash.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.eBtnFlash.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnFlash.ColorOneClick = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnFlash.ColorOneHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnFlash.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnFlash.ColorTwoClick = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnFlash.ColorTwoHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnFlash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.eBtnFlash.Enabled = false;
            this.eBtnFlash.Gradient = true;
            this.eBtnFlash.Location = new System.Drawing.Point(30, 142);
            this.eBtnFlash.Name = "eBtnFlash";
            this.eBtnFlash.Picture = null;
            this.eBtnFlash.PictureOffset = new System.Drawing.Point(0, 0);
            this.eBtnFlash.Radius = 15;
            this.eBtnFlash.RoundEdges = true;
            this.eBtnFlash.Size = new System.Drawing.Size(130, 40);
            this.eBtnFlash.SmoothText = false;
            this.eBtnFlash.TabIndex = 3;
            this.eBtnFlash.Text = "Flash!";
            this.eBtnFlash.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(102)))), ((int)(((byte)(108)))));
            this.eBtnFlash.TextColorOnClick = System.Drawing.Color.White;
            this.eBtnFlash.TextColorOnHover = System.Drawing.Color.White;
            this.eBtnFlash.TextOffset = new System.Drawing.Point(0, 0);
            this.eBtnFlash.Click += new System.EventHandler(this.eBtnFlash_Click);
            // 
            // eBtnSelect
            // 
            this.eBtnSelect.Angle = 0;
            this.eBtnSelect.BackColor = System.Drawing.Color.Transparent;
            this.eBtnSelect.Background = System.Drawing.Color.DodgerBlue;
            this.eBtnSelect.BackgroundOnClick = System.Drawing.Color.DeepSkyBlue;
            this.eBtnSelect.BackgroundOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.eBtnSelect.Border = 1;
            this.eBtnSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.eBtnSelect.BorderColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.eBtnSelect.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.eBtnSelect.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnSelect.ColorOneClick = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnSelect.ColorOneHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnSelect.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnSelect.ColorTwoClick = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnSelect.ColorTwoHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.eBtnSelect.Enabled = false;
            this.eBtnSelect.Gradient = true;
            this.eBtnSelect.Location = new System.Drawing.Point(30, 142);
            this.eBtnSelect.Name = "eBtnSelect";
            this.eBtnSelect.Picture = null;
            this.eBtnSelect.PictureOffset = new System.Drawing.Point(0, 0);
            this.eBtnSelect.Radius = 15;
            this.eBtnSelect.RoundEdges = true;
            this.eBtnSelect.Size = new System.Drawing.Size(130, 40);
            this.eBtnSelect.SmoothText = false;
            this.eBtnSelect.TabIndex = 2;
            this.eBtnSelect.Text = "Select device";
            this.eBtnSelect.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.eBtnSelect.TextColorOnClick = System.Drawing.Color.White;
            this.eBtnSelect.TextColorOnHover = System.Drawing.Color.White;
            this.eBtnSelect.TextOffset = new System.Drawing.Point(0, 0);
            this.eBtnSelect.Click += new System.EventHandler(this.eBtnSelect_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(648, 323);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.tlpLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.tlpLayout.ResumeLayout(false);
            this.pnlCol3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlash)).EndInit();
            this.pnlCol2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsb)).EndInit();
            this.pnlCol1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLayout;
        private System.Windows.Forms.Panel pnlCol1;
        private System.Windows.Forms.Panel pnlCol3;
        private System.Windows.Forms.Panel pnlCol2;
        private System.Windows.Forms.LinkLabel lnkSelFs;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.Panel Line1;
        private System.Windows.Forms.Panel Line2;
        public System.Windows.Forms.PictureBox pbxAdd;
        public System.Windows.Forms.PictureBox pbxFlash;
        public System.Windows.Forms.PictureBox pbxUsb;
        public ExtendedButton eBtnSelect;
        public ExtendedButton eBtnFlash;
        public System.Windows.Forms.LinkLabel lnkSelWeb;
    }
}