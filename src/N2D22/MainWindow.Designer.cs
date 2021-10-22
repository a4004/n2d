
namespace N2D22
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
            this.mitigationNotice = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.warningMsg = new System.Windows.Forms.Label();
            this.iconWarning = new System.Windows.Forms.PictureBox();
            this.mitigationNotice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // mitigationNotice
            // 
            this.mitigationNotice.BackColor = System.Drawing.Color.LemonChiffon;
            this.mitigationNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mitigationNotice.Controls.Add(this.btnConnect);
            this.mitigationNotice.Controls.Add(this.warningMsg);
            this.mitigationNotice.Controls.Add(this.iconWarning);
            this.mitigationNotice.Dock = System.Windows.Forms.DockStyle.Top;
            this.mitigationNotice.Location = new System.Drawing.Point(0, 0);
            this.mitigationNotice.Name = "mitigationNotice";
            this.mitigationNotice.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.mitigationNotice.Size = new System.Drawing.Size(634, 26);
            this.mitigationNotice.TabIndex = 0;
            this.mitigationNotice.Visible = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(403, 1);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(63, 22);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Continue";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // warningMsg
            // 
            this.warningMsg.AutoEllipsis = true;
            this.warningMsg.Dock = System.Windows.Forms.DockStyle.Left;
            this.warningMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningMsg.Location = new System.Drawing.Point(23, 1);
            this.warningMsg.Name = "warningMsg";
            this.warningMsg.Padding = new System.Windows.Forms.Padding(3, 0, 0, 1);
            this.warningMsg.Size = new System.Drawing.Size(380, 22);
            this.warningMsg.TabIndex = 1;
            this.warningMsg.Text = "Device scanning functionality is disabled. See below message for details.";
            this.warningMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconWarning
            // 
            this.iconWarning.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconWarning.Image = global::N2D22.Properties.Resources.important_icon;
            this.iconWarning.Location = new System.Drawing.Point(5, 1);
            this.iconWarning.Name = "iconWarning";
            this.iconWarning.Size = new System.Drawing.Size(18, 22);
            this.iconWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconWarning.TabIndex = 0;
            this.iconWarning.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::N2D22.Properties.Resources.icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.mitigationNotice);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 630);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espressif Flash Manager";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mitigationNotice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconWarning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mitigationNotice;
        private System.Windows.Forms.PictureBox iconWarning;
        private System.Windows.Forms.Label warningMsg;
        private System.Windows.Forms.Button btnConnect;
    }
}

