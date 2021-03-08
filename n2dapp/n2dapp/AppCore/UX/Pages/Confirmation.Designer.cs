
namespace N2D.AppCore.UX.Pages
{
    partial class Confirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmation));
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.eBtnCancel = new N2D.AppCore.UX.ExtendedButton();
            this.eBtnSelect = new N2D.AppCore.UX.ExtendedButton();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.pnlContent.Controls.Add(this.lblMsg);
            this.pnlContent.Controls.Add(this.pbxIcon);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(30, 30);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(588, 273);
            this.pnlContent.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg.AutoEllipsis = true;
            this.lblMsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(110, 25);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMsg.Size = new System.Drawing.Size(428, 125);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "The current action requires your consent. Your permission is needed to continue.";
            // 
            // pbxIcon
            // 
            this.pbxIcon.Image = global::N2D.Properties.Resources.important;
            this.pbxIcon.Location = new System.Drawing.Point(50, 25);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(50, 50);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxIcon.TabIndex = 0;
            this.pbxIcon.TabStop = false;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.eBtnCancel);
            this.pnlControl.Controls.Add(this.eBtnSelect);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(30, 223);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Padding = new System.Windows.Forms.Padding(190, 16, 190, 18);
            this.pnlControl.Size = new System.Drawing.Size(588, 80);
            this.pnlControl.TabIndex = 4;
            // 
            // eBtnCancel
            // 
            this.eBtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eBtnCancel.Angle = 0;
            this.eBtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.eBtnCancel.Background = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(150)))), ((int)(((byte)(52)))));
            this.eBtnCancel.BackgroundOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(187)))), ((int)(((byte)(92)))));
            this.eBtnCancel.BackgroundOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(160)))), ((int)(((byte)(42)))));
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
            this.eBtnCancel.Location = new System.Drawing.Point(298, 20);
            this.eBtnCancel.Name = "eBtnCancel";
            this.eBtnCancel.Picture = null;
            this.eBtnCancel.PictureOffset = new System.Drawing.Point(0, 0);
            this.eBtnCancel.Radius = 15;
            this.eBtnCancel.RoundEdges = true;
            this.eBtnCancel.Size = new System.Drawing.Size(110, 35);
            this.eBtnCancel.SmoothText = false;
            this.eBtnCancel.TabIndex = 6;
            this.eBtnCancel.Text = "Go back";
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
            this.eBtnSelect.Gradient = false;
            this.eBtnSelect.Location = new System.Drawing.Point(180, 20);
            this.eBtnSelect.Name = "eBtnSelect";
            this.eBtnSelect.Picture = null;
            this.eBtnSelect.PictureOffset = new System.Drawing.Point(0, 0);
            this.eBtnSelect.Radius = 15;
            this.eBtnSelect.RoundEdges = true;
            this.eBtnSelect.Size = new System.Drawing.Size(110, 35);
            this.eBtnSelect.SmoothText = false;
            this.eBtnSelect.TabIndex = 5;
            this.eBtnSelect.Text = "Continue";
            this.eBtnSelect.TextColor = System.Drawing.Color.White;
            this.eBtnSelect.TextColorOnClick = System.Drawing.Color.White;
            this.eBtnSelect.TextColorOnHover = System.Drawing.Color.White;
            this.eBtnSelect.TextOffset = new System.Drawing.Point(0, 0);
            this.eBtnSelect.Click += new System.EventHandler(this.eBtnSelect_Click);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(648, 323);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Confirmation";
            this.Padding = new System.Windows.Forms.Padding(30, 30, 30, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Confirmation";
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlControl;
        private ExtendedButton eBtnCancel;
        private ExtendedButton eBtnSelect;
        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.Label lblMsg;
    }
}