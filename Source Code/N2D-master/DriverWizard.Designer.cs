namespace N2D
{
    partial class DriverWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverWizard));
            this.close = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.questionlbl = new System.Windows.Forms.Label();
            this.detaillbl = new System.Windows.Forms.Label();
            this.options = new System.Windows.Forms.ComboBox();
            this.download = new System.Windows.Forms.Button();
            this.notice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(465, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 28);
            this.close.TabIndex = 0;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.Close_Click);
            this.close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(154, 17);
            this.title.TabIndex = 1;
            this.title.Text = "Driver Installation Wizard";
            // 
            // questionlbl
            // 
            this.questionlbl.AutoSize = true;
            this.questionlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionlbl.Location = new System.Drawing.Point(93, 55);
            this.questionlbl.Name = "questionlbl";
            this.questionlbl.Size = new System.Drawing.Size(316, 21);
            this.questionlbl.TabIndex = 2;
            this.questionlbl.Text = "Which UART Chip is present on your device?";
            // 
            // detaillbl
            // 
            this.detaillbl.AutoSize = true;
            this.detaillbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaillbl.Location = new System.Drawing.Point(94, 80);
            this.detaillbl.Name = "detaillbl";
            this.detaillbl.Size = new System.Drawing.Size(206, 13);
            this.detaillbl.TabIndex = 3;
            this.detaillbl.Text = ">> This is the USB to SERIAL converter.";
            // 
            // options
            // 
            this.options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.options.ForeColor = System.Drawing.Color.White;
            this.options.FormattingEnabled = true;
            this.options.Items.AddRange(new object[] {
            "CP2102",
            "CH340",
            "I don\'t know - Install Both"});
            this.options.Location = new System.Drawing.Point(97, 119);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(312, 25);
            this.options.TabIndex = 4;
            this.options.Text = "Please select an option.";
            // 
            // download
            // 
            this.download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(32)))));
            this.download.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(32)))));
            this.download.FlatAppearance.BorderSize = 0;
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download.Location = new System.Drawing.Point(159, 183);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(181, 35);
            this.download.TabIndex = 5;
            this.download.Text = "Download and Install";
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.Download_Click);
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice.Location = new System.Drawing.Point(12, 256);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(463, 26);
            this.notice.TabIndex = 6;
            this.notice.Text = "NOTE: An internet connection is REQUIRED and you must grant this app access throu" +
    "gh  \r\n            your firewall.";
            // 
            // DriverWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(495, 291);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.download);
            this.Controls.Add(this.options);
            this.Controls.Add(this.detaillbl);
            this.Controls.Add(this.questionlbl);
            this.Controls.Add(this.title);
            this.Controls.Add(this.close);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DriverWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverWizard";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DriverWizard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DriverWizard_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DriverWizard_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label questionlbl;
        private System.Windows.Forms.Label detaillbl;
        private System.Windows.Forms.ComboBox options;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Label notice;
    }
}