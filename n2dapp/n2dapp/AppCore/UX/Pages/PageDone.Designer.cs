
namespace N2D.AppCore.UX.Pages
{
    partial class PageDone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageDone));
            this.lbmsg = new System.Windows.Forms.Label();
            this.lbcaption = new System.Windows.Forms.Label();
            this.lbnote = new System.Windows.Forms.Label();
            this.eBtnExit = new N2D.AppCore.UX.ExtendedButton();
            this.SuspendLayout();
            // 
            // lbmsg
            // 
            this.lbmsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbmsg.AutoEllipsis = true;
            this.lbmsg.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmsg.Location = new System.Drawing.Point(28, 50);
            this.lbmsg.Name = "lbmsg";
            this.lbmsg.Size = new System.Drawing.Size(586, 38);
            this.lbmsg.TabIndex = 8;
            this.lbmsg.Text = "All done!";
            this.lbmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbcaption
            // 
            this.lbcaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcaption.AutoEllipsis = true;
            this.lbcaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcaption.Location = new System.Drawing.Point(28, 88);
            this.lbcaption.Name = "lbcaption";
            this.lbcaption.Size = new System.Drawing.Size(586, 24);
            this.lbcaption.TabIndex = 9;
            this.lbcaption.Text = "Your device was flashed successfully.";
            this.lbcaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnote
            // 
            this.lbnote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnote.AutoEllipsis = true;
            this.lbnote.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lbnote.ForeColor = System.Drawing.Color.Silver;
            this.lbnote.Location = new System.Drawing.Point(32, 276);
            this.lbnote.Name = "lbnote";
            this.lbnote.Size = new System.Drawing.Size(577, 28);
            this.lbnote.TabIndex = 10;
            this.lbnote.Text = resources.GetString("lbnote.Text");
            // 
            // eBtnExit
            // 
            this.eBtnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eBtnExit.Angle = 0;
            this.eBtnExit.BackColor = System.Drawing.Color.Transparent;
            this.eBtnExit.Background = System.Drawing.Color.DodgerBlue;
            this.eBtnExit.BackgroundOnClick = System.Drawing.Color.DeepSkyBlue;
            this.eBtnExit.BackgroundOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.eBtnExit.Border = 1;
            this.eBtnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.eBtnExit.BorderColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.eBtnExit.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.eBtnExit.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnExit.ColorOneClick = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnExit.ColorOneHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnExit.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnExit.ColorTwoClick = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnExit.ColorTwoHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.eBtnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eBtnExit.Gradient = false;
            this.eBtnExit.Location = new System.Drawing.Point(275, 205);
            this.eBtnExit.Name = "eBtnExit";
            this.eBtnExit.Picture = null;
            this.eBtnExit.PictureOffset = new System.Drawing.Point(0, 0);
            this.eBtnExit.Radius = 15;
            this.eBtnExit.RoundEdges = true;
            this.eBtnExit.Size = new System.Drawing.Size(98, 43);
            this.eBtnExit.SmoothText = false;
            this.eBtnExit.TabIndex = 7;
            this.eBtnExit.Text = "Finish";
            this.eBtnExit.TextColor = System.Drawing.Color.White;
            this.eBtnExit.TextColorOnClick = System.Drawing.Color.White;
            this.eBtnExit.TextColorOnHover = System.Drawing.Color.White;
            this.eBtnExit.TextOffset = new System.Drawing.Point(0, 0);
            this.eBtnExit.Click += new System.EventHandler(this.eBtnExit_Click);
            // 
            // PageDone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(648, 323);
            this.Controls.Add(this.lbnote);
            this.Controls.Add(this.lbcaption);
            this.Controls.Add(this.lbmsg);
            this.Controls.Add(this.eBtnExit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PageDone";
            this.Padding = new System.Windows.Forms.Padding(275, 50, 275, 75);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageDone";
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedButton eBtnExit;
        private System.Windows.Forms.Label lbmsg;
        private System.Windows.Forms.Label lbcaption;
        private System.Windows.Forms.Label lbnote;
    }
}