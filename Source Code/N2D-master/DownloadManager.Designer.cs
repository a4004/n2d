namespace N2D
{
    partial class DownloadManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadManager));
            this.close = new System.Windows.Forms.Label();
            this.PACKAGE_NAME = new System.Windows.Forms.Label();
            this.base_prog = new System.Windows.Forms.Panel();
            this.percentage_bar = new System.Windows.Forms.Panel();
            this.PACKAGE_LOCATION = new System.Windows.Forms.Label();
            this.SPEED = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.DownloadManagerAgent = new System.ComponentModel.BackgroundWorker();
            this.base_prog.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(525, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 28);
            this.close.TabIndex = 0;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.Close_Click);
            this.close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // PACKAGE_NAME
            // 
            this.PACKAGE_NAME.AutoSize = true;
            this.PACKAGE_NAME.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PACKAGE_NAME.Location = new System.Drawing.Point(13, 47);
            this.PACKAGE_NAME.Name = "PACKAGE_NAME";
            this.PACKAGE_NAME.Size = new System.Drawing.Size(121, 21);
            this.PACKAGE_NAME.TabIndex = 1;
            this.PACKAGE_NAME.Text = "Package Name:";
            // 
            // base_prog
            // 
            this.base_prog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.base_prog.Controls.Add(this.percentage_bar);
            this.base_prog.Location = new System.Drawing.Point(17, 83);
            this.base_prog.Name = "base_prog";
            this.base_prog.Size = new System.Drawing.Size(522, 28);
            this.base_prog.TabIndex = 2;
            // 
            // percentage_bar
            // 
            this.percentage_bar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.percentage_bar.Location = new System.Drawing.Point(3, 0);
            this.percentage_bar.Name = "percentage_bar";
            this.percentage_bar.Size = new System.Drawing.Size(1, 28);
            this.percentage_bar.TabIndex = 3;
            // 
            // PACKAGE_LOCATION
            // 
            this.PACKAGE_LOCATION.AutoEllipsis = true;
            this.PACKAGE_LOCATION.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PACKAGE_LOCATION.Location = new System.Drawing.Point(17, 119);
            this.PACKAGE_LOCATION.Name = "PACKAGE_LOCATION";
            this.PACKAGE_LOCATION.Size = new System.Drawing.Size(413, 21);
            this.PACKAGE_LOCATION.TabIndex = 3;
            this.PACKAGE_LOCATION.Text = "Downloading...........";
            // 
            // SPEED
            // 
            this.SPEED.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPEED.Location = new System.Drawing.Point(446, 119);
            this.SPEED.Name = "SPEED";
            this.SPEED.Size = new System.Drawing.Size(93, 17);
            this.SPEED.TabIndex = 4;
            this.SPEED.Text = "0 kb/s";
            this.SPEED.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // percent
            // 
            this.percent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(449, 47);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(91, 21);
            this.percent.TabIndex = 5;
            this.percent.Text = "0%";
            this.percent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
            this.cancelbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
            this.cancelbtn.FlatAppearance.BorderSize = 0;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(444, 158);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(95, 31);
            this.cancelbtn.TabIndex = 6;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(147, 17);
            this.title.TabIndex = 7;
            this.title.Text = "N2D Dowload Manager";
            // 
            // DownloadManagerAgent
            // 
            this.DownloadManagerAgent.WorkerSupportsCancellation = true;
            this.DownloadManagerAgent.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DownloadManagerAgent_DoWork);
            // 
            // DownloadManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(551, 205);
            this.Controls.Add(this.title);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.SPEED);
            this.Controls.Add(this.PACKAGE_LOCATION);
            this.Controls.Add(this.base_prog);
            this.Controls.Add(this.PACKAGE_NAME);
            this.Controls.Add(this.close);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DownloadManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DownloadManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadManager_FormClosing);
            this.Load += new System.EventHandler(this.DownloadManager_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownloadManager_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DownloadManager_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DownloadManager_MouseUp);
            this.base_prog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label PACKAGE_NAME;
        private System.Windows.Forms.Panel base_prog;
        private System.Windows.Forms.Panel percentage_bar;
        private System.Windows.Forms.Label PACKAGE_LOCATION;
        private System.Windows.Forms.Label SPEED;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label title;
        private System.ComponentModel.BackgroundWorker DownloadManagerAgent;
    }
}