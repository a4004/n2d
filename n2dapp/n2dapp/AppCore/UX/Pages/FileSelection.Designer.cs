
namespace N2D.AppCore.UX.Pages
{
    partial class FileSelection
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Avater 5W EL14 Lamp",
            "2.6.0",
            "esp8266_deauther_2.6.0_AVATAR_5W_E14_LAMP.bin"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Display Example",
            "2.6.0",
            "*"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "DSTIKE Deauther Boy",
            "2.6.0",
            "esp8266_deauther_2.6.0_DSTIKE_DEAUTHER_BOY.bin"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "DSTIKE Deauther Mini",
            "2.6.0",
            "*"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "DSTIKE Deauther Moster",
            "2.6.0",
            "*"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "DSTIKE Deauther OLED",
            "2.6.0",
            "*"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "DSTIKE Deauther",
            "2.6.0",
            "*"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "DSTIKE Deauther Watch",
            "2.6.0",
            "*"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "DSTIKE D-DUINO ",
            "2.6.0",
            "esp8266_deauther_2.6.0_DSTIKE_D_DUINO_B_V5_LED_RING.bin"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "DSTIKE NodeMCU",
            "2.6.0",
            "*"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "DSTIKE USB Deauther",
            "2.6.0",
            "*"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "LYASI 7W E27 Lamp",
            "2.6.0",
            "esp8266_deauther_2.6.0_LYASI_7W_E27_LAMP.bin"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Maltronics",
            "2.6.0",
            "esp8266_deauther_2.6.0_MALTRONICS.bin"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "NodeMCU",
            "2.6.0",
            "esp8266_deauther_2.6.0_NODEMCU.bin"}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Wemos D1 Mini",
            "2.6.0",
            "esp8266_deauther_2.6.0_WEMOS_D1_MINI.bin"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileSelection));
            this.scSplitter = new System.Windows.Forms.SplitContainer();
            this.lvItems = new System.Windows.Forms.ListView();
            this.devName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlVersionSelect = new System.Windows.Forms.Panel();
            this.pnlRvContainer = new System.Windows.Forms.Panel();
            this.lbRev = new System.Windows.Forms.ListBox();
            this.lblRev = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.eBtnCancel = new N2D.AppCore.UX.ExtendedButton();
            this.eBtnSelect = new N2D.AppCore.UX.ExtendedButton();
            ((System.ComponentModel.ISupportInitialize)(this.scSplitter)).BeginInit();
            this.scSplitter.Panel1.SuspendLayout();
            this.scSplitter.Panel2.SuspendLayout();
            this.scSplitter.SuspendLayout();
            this.pnlVersionSelect.SuspendLayout();
            this.pnlRvContainer.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // scSplitter
            // 
            this.scSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSplitter.Location = new System.Drawing.Point(10, 10);
            this.scSplitter.Name = "scSplitter";
            // 
            // scSplitter.Panel1
            // 
            this.scSplitter.Panel1.Controls.Add(this.lvItems);
            // 
            // scSplitter.Panel2
            // 
            this.scSplitter.Panel2.Controls.Add(this.pnlVersionSelect);
            this.scSplitter.Panel2.Controls.Add(this.pnlControl);
            this.scSplitter.Size = new System.Drawing.Size(628, 303);
            this.scSplitter.SplitterDistance = 446;
            this.scSplitter.TabIndex = 0;
            // 
            // lvItems
            // 
            this.lvItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.devName,
            this.version,
            this.fileName});
            this.lvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvItems.ForeColor = System.Drawing.Color.White;
            this.lvItems.FullRowSelect = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15});
            this.lvItems.Location = new System.Drawing.Point(0, 0);
            this.lvItems.MultiSelect = false;
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(446, 303);
            this.lvItems.TabIndex = 1;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            this.lvItems.SelectedIndexChanged += new System.EventHandler(this.lvItems_SelectedIndexChanged);
            // 
            // devName
            // 
            this.devName.Text = "Vendor";
            this.devName.Width = 153;
            // 
            // version
            // 
            this.version.Text = "Version";
            this.version.Width = 51;
            // 
            // fileName
            // 
            this.fileName.Text = "File Name";
            this.fileName.Width = 217;
            // 
            // pnlVersionSelect
            // 
            this.pnlVersionSelect.Controls.Add(this.pnlRvContainer);
            this.pnlVersionSelect.Controls.Add(this.lblRev);
            this.pnlVersionSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVersionSelect.Location = new System.Drawing.Point(0, 0);
            this.pnlVersionSelect.Name = "pnlVersionSelect";
            this.pnlVersionSelect.Size = new System.Drawing.Size(178, 173);
            this.pnlVersionSelect.TabIndex = 1;
            this.pnlVersionSelect.Visible = false;
            // 
            // pnlRvContainer
            // 
            this.pnlRvContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.pnlRvContainer.Controls.Add(this.lbRev);
            this.pnlRvContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRvContainer.Location = new System.Drawing.Point(0, 24);
            this.pnlRvContainer.Name = "pnlRvContainer";
            this.pnlRvContainer.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlRvContainer.Size = new System.Drawing.Size(178, 149);
            this.pnlRvContainer.TabIndex = 1;
            // 
            // lbRev
            // 
            this.lbRev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.lbRev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRev.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRev.ForeColor = System.Drawing.Color.White;
            this.lbRev.FormattingEnabled = true;
            this.lbRev.ItemHeight = 17;
            this.lbRev.Items.AddRange(new object[] {
            "Version 1",
            "Version 2",
            "Version 3"});
            this.lbRev.Location = new System.Drawing.Point(0, 2);
            this.lbRev.Name = "lbRev";
            this.lbRev.Size = new System.Drawing.Size(178, 147);
            this.lbRev.TabIndex = 2;
            this.lbRev.SelectedIndexChanged += new System.EventHandler(this.lbRev_SelectedIndexChanged);
            // 
            // lblRev
            // 
            this.lblRev.BackColor = System.Drawing.Color.White;
            this.lblRev.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRev.ForeColor = System.Drawing.Color.Black;
            this.lblRev.Location = new System.Drawing.Point(0, 0);
            this.lblRev.Name = "lblRev";
            this.lblRev.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblRev.Size = new System.Drawing.Size(178, 24);
            this.lblRev.TabIndex = 0;
            this.lblRev.Text = "Device Revision";
            this.lblRev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.eBtnCancel);
            this.pnlControl.Controls.Add(this.eBtnSelect);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 173);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(178, 130);
            this.pnlControl.TabIndex = 0;
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
            this.eBtnCancel.Location = new System.Drawing.Point(24, 60);
            this.eBtnCancel.Name = "eBtnCancel";
            this.eBtnCancel.Picture = null;
            this.eBtnCancel.PictureOffset = new System.Drawing.Point(0, 0);
            this.eBtnCancel.Radius = 15;
            this.eBtnCancel.RoundEdges = true;
            this.eBtnCancel.Size = new System.Drawing.Size(130, 35);
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
            this.eBtnSelect.Location = new System.Drawing.Point(24, 20);
            this.eBtnSelect.Name = "eBtnSelect";
            this.eBtnSelect.Picture = null;
            this.eBtnSelect.PictureOffset = new System.Drawing.Point(0, 0);
            this.eBtnSelect.Radius = 15;
            this.eBtnSelect.RoundEdges = true;
            this.eBtnSelect.Size = new System.Drawing.Size(130, 35);
            this.eBtnSelect.SmoothText = false;
            this.eBtnSelect.TabIndex = 5;
            this.eBtnSelect.Text = "Select image";
            this.eBtnSelect.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.eBtnSelect.TextColorOnClick = System.Drawing.Color.White;
            this.eBtnSelect.TextColorOnHover = System.Drawing.Color.White;
            this.eBtnSelect.TextOffset = new System.Drawing.Point(0, 0);
            this.eBtnSelect.Click += new System.EventHandler(this.eBtnSelect_Click);
            // 
            // FileSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(648, 323);
            this.Controls.Add(this.scSplitter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileSelection";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileSelection";
            this.scSplitter.Panel1.ResumeLayout(false);
            this.scSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSplitter)).EndInit();
            this.scSplitter.ResumeLayout(false);
            this.pnlVersionSelect.ResumeLayout(false);
            this.pnlRvContainer.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scSplitter;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader devName;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader version;
        private System.Windows.Forms.Panel pnlControl;
        private ExtendedButton eBtnCancel;
        private ExtendedButton eBtnSelect;
        private System.Windows.Forms.Panel pnlVersionSelect;
        private System.Windows.Forms.Label lblRev;
        private System.Windows.Forms.Panel pnlRvContainer;
        private System.Windows.Forms.ListBox lbRev;
    }
}