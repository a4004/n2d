
namespace N2D.AppCore.UX.Pages
{
    partial class AdvSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvSettings));
            this.pnlDvSel = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.note2 = new System.Windows.Forms.Label();
            this.note1 = new System.Windows.Forms.Label();
            this.cbSpi = new System.Windows.Forms.ComboBox();
            this.lblspi = new System.Windows.Forms.Label();
            this.lblbd = new System.Windows.Forms.Label();
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.txtCli = new System.Windows.Forms.TextBox();
            this.lblcli = new System.Windows.Forms.Label();
            this.cbFs = new System.Windows.Forms.ComboBox();
            this.lblfs = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.eBtnCancel = new N2D.AppCore.UX.ExtendedButton();
            this.eBtnSelect = new N2D.AppCore.UX.ExtendedButton();
            this.pnlDvSel.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDvSel
            // 
            this.pnlDvSel.Controls.Add(this.pnlContainer);
            this.pnlDvSel.Controls.Add(this.lblHeader);
            this.pnlDvSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDvSel.Location = new System.Drawing.Point(20, 20);
            this.pnlDvSel.Name = "pnlDvSel";
            this.pnlDvSel.Size = new System.Drawing.Size(608, 214);
            this.pnlDvSel.TabIndex = 4;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.pnlContainer.Controls.Add(this.note2);
            this.pnlContainer.Controls.Add(this.note1);
            this.pnlContainer.Controls.Add(this.cbSpi);
            this.pnlContainer.Controls.Add(this.lblspi);
            this.pnlContainer.Controls.Add(this.lblbd);
            this.pnlContainer.Controls.Add(this.cbRate);
            this.pnlContainer.Controls.Add(this.txtCli);
            this.pnlContainer.Controls.Add(this.lblcli);
            this.pnlContainer.Controls.Add(this.cbFs);
            this.pnlContainer.Controls.Add(this.lblfs);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(0, 24);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlContainer.Size = new System.Drawing.Size(608, 190);
            this.pnlContainer.TabIndex = 1;
            // 
            // note2
            // 
            this.note2.AutoSize = true;
            this.note2.ForeColor = System.Drawing.Color.Red;
            this.note2.Location = new System.Drawing.Point(23, 74);
            this.note2.Name = "note2";
            this.note2.Size = new System.Drawing.Size(512, 15);
            this.note2.TabIndex = 13;
            this.note2.Text = "*changing the CLI arguments will disable N2D\'s ability to control esptool && over" +
    "rides all settings";
            // 
            // note1
            // 
            this.note1.AutoSize = true;
            this.note1.ForeColor = System.Drawing.Color.Gold;
            this.note1.Location = new System.Drawing.Point(23, 59);
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(403, 15);
            this.note1.TabIndex = 12;
            this.note1.Text = "*note changing the baudrate or SPI flash mode will override the flash speed";
            // 
            // cbSpi
            // 
            this.cbSpi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpi.FormattingEnabled = true;
            this.cbSpi.Items.AddRange(new object[] {
            "dout",
            "dio",
            "qout",
            "qio"});
            this.cbSpi.Location = new System.Drawing.Point(510, 17);
            this.cbSpi.Name = "cbSpi";
            this.cbSpi.Size = new System.Drawing.Size(76, 23);
            this.cbSpi.TabIndex = 11;
            this.cbSpi.SelectedIndexChanged += new System.EventHandler(this.cbSpi_SelectedIndexChanged);
            // 
            // lblspi
            // 
            this.lblspi.AutoSize = true;
            this.lblspi.Location = new System.Drawing.Point(444, 20);
            this.lblspi.Name = "lblspi";
            this.lblspi.Size = new System.Drawing.Size(60, 15);
            this.lblspi.TabIndex = 10;
            this.lblspi.Text = "SPI Mode:";
            // 
            // lblbd
            // 
            this.lblbd.AutoSize = true;
            this.lblbd.Location = new System.Drawing.Point(234, 20);
            this.lblbd.Name = "lblbd";
            this.lblbd.Size = new System.Drawing.Size(57, 15);
            this.lblbd.TabIndex = 9;
            this.lblbd.Text = "Baudrate:";
            // 
            // cbRate
            // 
            this.cbRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRate.FormattingEnabled = true;
            this.cbRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "56000",
            "115200",
            "128000",
            "256000"});
            this.cbRate.Location = new System.Drawing.Point(297, 17);
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(141, 23);
            this.cbRate.TabIndex = 8;
            this.cbRate.SelectedIndexChanged += new System.EventHandler(this.cbRate_SelectedIndexChanged);
            // 
            // txtCli
            // 
            this.txtCli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.txtCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCli.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCli.ForeColor = System.Drawing.Color.White;
            this.txtCli.Location = new System.Drawing.Point(163, 104);
            this.txtCli.Multiline = true;
            this.txtCli.Name = "txtCli";
            this.txtCli.Size = new System.Drawing.Size(423, 68);
            this.txtCli.TabIndex = 7;
            this.txtCli.TextChanged += new System.EventHandler(this.txtCli_TextChanged);
            // 
            // lblcli
            // 
            this.lblcli.AutoSize = true;
            this.lblcli.Location = new System.Drawing.Point(23, 104);
            this.lblcli.Name = "lblcli";
            this.lblcli.Size = new System.Drawing.Size(134, 15);
            this.lblcli.TabIndex = 6;
            this.lblcli.Text = "Custom CLI Arguments:";
            // 
            // cbFs
            // 
            this.cbFs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFs.FormattingEnabled = true;
            this.cbFs.Items.AddRange(new object[] {
            "Slow",
            "Default",
            "Normal",
            "Fast",
            "Lightning"});
            this.cbFs.Location = new System.Drawing.Point(101, 17);
            this.cbFs.Name = "cbFs";
            this.cbFs.Size = new System.Drawing.Size(118, 23);
            this.cbFs.TabIndex = 5;
            this.cbFs.SelectedIndexChanged += new System.EventHandler(this.cbFs_SelectedIndexChanged);
            // 
            // lblfs
            // 
            this.lblfs.AutoSize = true;
            this.lblfs.Location = new System.Drawing.Point(23, 20);
            this.lblfs.Name = "lblfs";
            this.lblfs.Size = new System.Drawing.Size(72, 15);
            this.lblfs.TabIndex = 4;
            this.lblfs.Text = "Flash Speed:";
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblHeader.Size = new System.Drawing.Size(608, 24);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Advanced Settings";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.eBtnCancel);
            this.pnlControl.Controls.Add(this.eBtnSelect);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(20, 234);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Padding = new System.Windows.Forms.Padding(190, 16, 190, 18);
            this.pnlControl.Size = new System.Drawing.Size(608, 69);
            this.pnlControl.TabIndex = 5;
            // 
            // eBtnCancel
            // 
            this.eBtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eBtnCancel.Angle = 0;
            this.eBtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.eBtnCancel.Background = System.Drawing.Color.DodgerBlue;
            this.eBtnCancel.BackgroundOnClick = System.Drawing.Color.DeepSkyBlue;
            this.eBtnCancel.BackgroundOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.eBtnCancel.Border = 1;
            this.eBtnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.eBtnCancel.BorderColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.eBtnCancel.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.eBtnCancel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnCancel.ColorOneClick = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnCancel.ColorOneHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnCancel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnCancel.ColorTwoClick = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnCancel.ColorTwoHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnCancel.Gradient = false;
            this.eBtnCancel.Location = new System.Drawing.Point(328, 16);
            this.eBtnCancel.Name = "eBtnCancel";
            this.eBtnCancel.Picture = null;
            this.eBtnCancel.PictureOffset = new System.Drawing.Point(0, 0);
            this.eBtnCancel.Radius = 15;
            this.eBtnCancel.RoundEdges = true;
            this.eBtnCancel.Size = new System.Drawing.Size(90, 35);
            this.eBtnCancel.SmoothText = false;
            this.eBtnCancel.TabIndex = 6;
            this.eBtnCancel.Text = "Cancel";
            this.eBtnCancel.TextColor = System.Drawing.Color.White;
            this.eBtnCancel.TextColorOnClick = System.Drawing.Color.White;
            this.eBtnCancel.TextColorOnHover = System.Drawing.Color.White;
            this.eBtnCancel.TextOffset = new System.Drawing.Point(0, 0);
            this.eBtnCancel.Click += new System.EventHandler(this.eBtnCancel_Click);
            // 
            // eBtnSelect
            // 
            this.eBtnSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.eBtnSelect.Enabled = false;
            this.eBtnSelect.Gradient = true;
            this.eBtnSelect.Location = new System.Drawing.Point(190, 16);
            this.eBtnSelect.Name = "eBtnSelect";
            this.eBtnSelect.Picture = null;
            this.eBtnSelect.PictureOffset = new System.Drawing.Point(0, 0);
            this.eBtnSelect.Radius = 15;
            this.eBtnSelect.RoundEdges = true;
            this.eBtnSelect.Size = new System.Drawing.Size(130, 35);
            this.eBtnSelect.SmoothText = false;
            this.eBtnSelect.TabIndex = 5;
            this.eBtnSelect.Text = "Save Changes";
            this.eBtnSelect.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.eBtnSelect.TextColorOnClick = System.Drawing.Color.White;
            this.eBtnSelect.TextColorOnHover = System.Drawing.Color.White;
            this.eBtnSelect.TextOffset = new System.Drawing.Point(0, 0);
            this.eBtnSelect.Click += new System.EventHandler(this.eBtnSelect_Click);
            // 
            // AdvSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(648, 323);
            this.Controls.Add(this.pnlDvSel);
            this.Controls.Add(this.pnlControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvSettings";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvSettings";
            this.pnlDvSel.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDvSel;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlControl;
        private ExtendedButton eBtnCancel;
        private ExtendedButton eBtnSelect;
        private System.Windows.Forms.TextBox txtCli;
        private System.Windows.Forms.Label lblcli;
        private System.Windows.Forms.ComboBox cbFs;
        private System.Windows.Forms.Label lblfs;
        private System.Windows.Forms.ComboBox cbSpi;
        private System.Windows.Forms.Label lblspi;
        private System.Windows.Forms.Label lblbd;
        private System.Windows.Forms.ComboBox cbRate;
        private System.Windows.Forms.Label note2;
        private System.Windows.Forms.Label note1;
    }
}