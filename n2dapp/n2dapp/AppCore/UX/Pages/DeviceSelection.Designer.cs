
namespace N2D.AppCore.UX.Pages
{
    partial class DeviceSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceSelection));
            this.pnlDvSel = new System.Windows.Forms.Panel();
            this.pnldvContainer = new System.Windows.Forms.Panel();
            this.lbDev = new System.Windows.Forms.ListBox();
            this.lblDev = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.eBtnCancel = new N2D.AppCore.UX.ExtendedButton();
            this.eBtnSelect = new N2D.AppCore.UX.ExtendedButton();
            this.pnlDvSel.SuspendLayout();
            this.pnldvContainer.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDvSel
            // 
            this.pnlDvSel.Controls.Add(this.pnldvContainer);
            this.pnlDvSel.Controls.Add(this.lblDev);
            this.pnlDvSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDvSel.Location = new System.Drawing.Point(20, 20);
            this.pnlDvSel.Name = "pnlDvSel";
            this.pnlDvSel.Size = new System.Drawing.Size(608, 214);
            this.pnlDvSel.TabIndex = 2;
            // 
            // pnldvContainer
            // 
            this.pnldvContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.pnldvContainer.Controls.Add(this.lbDev);
            this.pnldvContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldvContainer.Location = new System.Drawing.Point(0, 24);
            this.pnldvContainer.Name = "pnldvContainer";
            this.pnldvContainer.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnldvContainer.Size = new System.Drawing.Size(608, 190);
            this.pnldvContainer.TabIndex = 1;
            // 
            // lbDev
            // 
            this.lbDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.lbDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDev.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDev.ForeColor = System.Drawing.Color.White;
            this.lbDev.FormattingEnabled = true;
            this.lbDev.ItemHeight = 17;
            this.lbDev.Location = new System.Drawing.Point(0, 2);
            this.lbDev.Name = "lbDev";
            this.lbDev.Size = new System.Drawing.Size(608, 188);
            this.lbDev.TabIndex = 2;
            this.lbDev.SelectedIndexChanged += new System.EventHandler(this.lbDev_SelectedIndexChanged);
            // 
            // lblDev
            // 
            this.lblDev.BackColor = System.Drawing.Color.White;
            this.lblDev.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDev.ForeColor = System.Drawing.Color.Black;
            this.lblDev.Location = new System.Drawing.Point(0, 0);
            this.lblDev.Name = "lblDev";
            this.lblDev.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblDev.Size = new System.Drawing.Size(608, 24);
            this.lblDev.TabIndex = 0;
            this.lblDev.Text = "Please connect your device and select it from the list";
            this.lblDev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlControl.TabIndex = 3;
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
            this.eBtnCancel.Location = new System.Drawing.Point(308, 16);
            this.eBtnCancel.Name = "eBtnCancel";
            this.eBtnCancel.Picture = null;
            this.eBtnCancel.PictureOffset = new System.Drawing.Point(0, 0);
            this.eBtnCancel.Radius = 15;
            this.eBtnCancel.RoundEdges = true;
            this.eBtnCancel.Size = new System.Drawing.Size(110, 35);
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
            this.eBtnSelect.Size = new System.Drawing.Size(110, 35);
            this.eBtnSelect.SmoothText = false;
            this.eBtnSelect.TabIndex = 5;
            this.eBtnSelect.Text = "Select";
            this.eBtnSelect.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.eBtnSelect.TextColorOnClick = System.Drawing.Color.White;
            this.eBtnSelect.TextColorOnHover = System.Drawing.Color.White;
            this.eBtnSelect.TextOffset = new System.Drawing.Point(0, 0);
            this.eBtnSelect.Click += new System.EventHandler(this.eBtnSelect_Click);
            this.eBtnSelect.MouseEnter += new System.EventHandler(this.eBtnSelect_MouseEnter);
            // 
            // DeviceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(648, 323);
            this.Controls.Add(this.pnlDvSel);
            this.Controls.Add(this.pnlControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeviceSelection";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviceSelection";
            this.Load += new System.EventHandler(this.DeviceSelection_Load);
            this.pnlDvSel.ResumeLayout(false);
            this.pnldvContainer.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDvSel;
        private System.Windows.Forms.Panel pnldvContainer;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Panel pnlControl;
        private ExtendedButton eBtnCancel;
        private ExtendedButton eBtnSelect;
        public System.Windows.Forms.ListBox lbDev;
    }
}