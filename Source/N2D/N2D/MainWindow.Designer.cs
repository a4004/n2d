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
            this.statusIcon = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.btnFail = new N2D.Components.ButtonEx();
            this.btnProceed = new N2D.Components.ButtonEx();
            this.progressStrip = new N2D.Components.ProgressStrip();
            ((System.ComponentModel.ISupportInitialize)(this.statusIcon)).BeginInit();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusIcon
            // 
            this.statusIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusIcon.Image = global::N2D.Properties.Resources.icon_32;
            this.statusIcon.Location = new System.Drawing.Point(25, 25);
            this.statusIcon.Name = "statusIcon";
            this.statusIcon.Size = new System.Drawing.Size(334, 50);
            this.statusIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.statusIcon.TabIndex = 0;
            this.statusIcon.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoEllipsis = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(25, 75);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.statusLabel.Size = new System.Drawing.Size(334, 30);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Have you got the board handy?";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // container
            // 
            this.container.Controls.Add(this.btnFail);
            this.container.Controls.Add(this.btnProceed);
            this.container.Dock = System.Windows.Forms.DockStyle.Top;
            this.container.Location = new System.Drawing.Point(25, 125);
            this.container.Name = "container";
            this.container.Padding = new System.Windows.Forms.Padding(125, 10, 125, 0);
            this.container.Size = new System.Drawing.Size(334, 65);
            this.container.TabIndex = 4;
            // 
            // btnFail
            // 
            this.btnFail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.btnFail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFail.FlatAppearance.BorderSize = 0;
            this.btnFail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFail.Location = new System.Drawing.Point(125, 40);
            this.btnFail.Name = "btnFail";
            this.btnFail.Size = new System.Drawing.Size(84, 25);
            this.btnFail.TabIndex = 4;
            this.btnFail.Text = "No";
            this.btnFail.UseVisualStyleBackColor = false;
            this.btnFail.Click += new System.EventHandler(this.btnFail_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.btnProceed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Location = new System.Drawing.Point(125, 10);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(84, 25);
            this.btnProceed.TabIndex = 3;
            this.btnProceed.Text = "Yes";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // progressStrip
            // 
            this.progressStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressStrip.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.progressStrip.Location = new System.Drawing.Point(25, 105);
            this.progressStrip.MarqueeSize = 50;
            this.progressStrip.MarqueeSpeed = 3;
            this.progressStrip.Mode = N2D.Components.ProgressStrip.ControlMode.Regular;
            this.progressStrip.Name = "progressStrip";
            this.progressStrip.RegularSpeed = 3;
            this.progressStrip.ResetOffsetGlow = -300;
            this.progressStrip.ResetOffsetMarquee = -50;
            this.progressStrip.Size = new System.Drawing.Size(334, 20);
            this.progressStrip.TabIndex = 2;
            this.progressStrip.Value = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.container);
            this.Controls.Add(this.progressStrip);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(25, 25, 25, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deauther Flash Utility (formerly N2D)";
            ((System.ComponentModel.ISupportInitialize)(this.statusIcon)).EndInit();
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox statusIcon;
        private System.Windows.Forms.Label statusLabel;
        private Components.ProgressStrip progressStrip;
        private Components.ButtonEx btnProceed;
        private System.Windows.Forms.Panel container;
        private Components.ButtonEx btnFail;
    }
}

