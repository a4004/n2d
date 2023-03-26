
namespace N2D22.Window
{
    partial class DriverTimeoutFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverTimeoutFm));
            this.header = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Label();
            this.mCaption = new System.Windows.Forms.Label();
            this.usbConnectionPanel = new System.Windows.Forms.Panel();
            this.btnOpenDevmgr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usbBad = new System.Windows.Forms.PictureBox();
            this.solutionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.driverPanel = new System.Windows.Forms.Panel();
            this.linkInstallInstructions = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            this.usbConnectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usbBad)).BeginInit();
            this.solutionsPanel.SuspendLayout();
            this.helpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.driverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.message);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(15, 16);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(570, 36);
            this.header.TabIndex = 3;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Dock = System.Windows.Forms.DockStyle.Left;
            this.message.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.message.Location = new System.Drawing.Point(0, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(273, 32);
            this.message.TabIndex = 0;
            this.message.Text = "Device still not detected?";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mCaption
            // 
            this.mCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.mCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCaption.Location = new System.Drawing.Point(15, 52);
            this.mCaption.Name = "mCaption";
            this.mCaption.Padding = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.mCaption.Size = new System.Drawing.Size(570, 45);
            this.mCaption.TabIndex = 4;
            this.mCaption.Text = "Try the following solutions which might help you diagnose the problem.";
            // 
            // usbConnectionPanel
            // 
            this.usbConnectionPanel.Controls.Add(this.btnOpenDevmgr);
            this.usbConnectionPanel.Controls.Add(this.label2);
            this.usbConnectionPanel.Controls.Add(this.label1);
            this.usbConnectionPanel.Controls.Add(this.usbBad);
            this.usbConnectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usbConnectionPanel.Location = new System.Drawing.Point(3, 3);
            this.usbConnectionPanel.Name = "usbConnectionPanel";
            this.usbConnectionPanel.Size = new System.Drawing.Size(184, 272);
            this.usbConnectionPanel.TabIndex = 0;
            // 
            // btnOpenDevmgr
            // 
            this.btnOpenDevmgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenDevmgr.Location = new System.Drawing.Point(0, 230);
            this.btnOpenDevmgr.Name = "btnOpenDevmgr";
            this.btnOpenDevmgr.Size = new System.Drawing.Size(184, 23);
            this.btnOpenDevmgr.TabIndex = 7;
            this.btnOpenDevmgr.Text = "Open Device Manager";
            this.btnOpenDevmgr.UseVisualStyleBackColor = true;
            this.btnOpenDevmgr.Click += new System.EventHandler(this.btnOpenDevmgr_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 86);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.label2.Size = new System.Drawing.Size(184, 144);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 64);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Check USB Connection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usbBad
            // 
            this.usbBad.Dock = System.Windows.Forms.DockStyle.Top;
            this.usbBad.Image = global::N2D22.Properties.Resources.usb_disconnected_96px;
            this.usbBad.Location = new System.Drawing.Point(0, 0);
            this.usbBad.Name = "usbBad";
            this.usbBad.Size = new System.Drawing.Size(184, 64);
            this.usbBad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usbBad.TabIndex = 0;
            this.usbBad.TabStop = false;
            // 
            // solutionsPanel
            // 
            this.solutionsPanel.ColumnCount = 3;
            this.solutionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.solutionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.solutionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.solutionsPanel.Controls.Add(this.helpPanel, 0, 0);
            this.solutionsPanel.Controls.Add(this.driverPanel, 0, 0);
            this.solutionsPanel.Controls.Add(this.usbConnectionPanel, 0, 0);
            this.solutionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionsPanel.Location = new System.Drawing.Point(15, 97);
            this.solutionsPanel.Name = "solutionsPanel";
            this.solutionsPanel.RowCount = 1;
            this.solutionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.solutionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.solutionsPanel.Size = new System.Drawing.Size(570, 278);
            this.solutionsPanel.TabIndex = 5;
            // 
            // helpPanel
            // 
            this.helpPanel.Controls.Add(this.label5);
            this.helpPanel.Controls.Add(this.label6);
            this.helpPanel.Controls.Add(this.pictureBox2);
            this.helpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpPanel.Location = new System.Drawing.Point(383, 3);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(184, 272);
            this.helpPanel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 86);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.label5.Size = new System.Drawing.Size(184, 98);
            this.label5.TabIndex = 6;
            this.label5.Text = "If after trying the previous steps your device still isn\'t being detected, please" +
    " raise an issue on GitHub making sure to attach the \"dump-xxxxxxxxxxxxxxxxx.log\"" +
    " file created after the program exits.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 64);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.label6.Size = new System.Drawing.Size(184, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ask for Help";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::N2D22.Properties.Resources.help_96px;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // driverPanel
            // 
            this.driverPanel.Controls.Add(this.linkInstallInstructions);
            this.driverPanel.Controls.Add(this.label3);
            this.driverPanel.Controls.Add(this.label4);
            this.driverPanel.Controls.Add(this.pictureBox1);
            this.driverPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driverPanel.Location = new System.Drawing.Point(193, 3);
            this.driverPanel.Name = "driverPanel";
            this.driverPanel.Size = new System.Drawing.Size(184, 272);
            this.driverPanel.TabIndex = 1;
            // 
            // linkInstallInstructions
            // 
            this.linkInstallInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkInstallInstructions.Location = new System.Drawing.Point(0, 184);
            this.linkInstallInstructions.Name = "linkInstallInstructions";
            this.linkInstallInstructions.Size = new System.Drawing.Size(184, 19);
            this.linkInstallInstructions.TabIndex = 7;
            this.linkInstallInstructions.TabStop = true;
            this.linkInstallInstructions.Text = "Installation Instructions";
            this.linkInstallInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkInstallInstructions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInstallInstructions_LinkClicked);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 86);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.label3.Size = new System.Drawing.Size(184, 98);
            this.label3.TabIndex = 6;
            this.label3.Text = "If you can see an unknown device listed in device manager, then it\'s most likely " +
    "that your PC is missing the required drivers. You can install the drivers by fol" +
    "lowing the instructions on the Wiki.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 64);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.label4.Size = new System.Drawing.Size(184, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Install Drivers";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::N2D22.Properties.Resources.services_96px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DriverTimeoutFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.solutionsPanel);
            this.Controls.Add(this.mCaption);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DriverTimeoutFm";
            this.Padding = new System.Windows.Forms.Padding(15, 16, 15, 25);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.usbConnectionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usbBad)).EndInit();
            this.solutionsPanel.ResumeLayout(false);
            this.helpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.driverPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label mCaption;
        private System.Windows.Forms.Panel usbConnectionPanel;
        private System.Windows.Forms.Button btnOpenDevmgr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox usbBad;
        private System.Windows.Forms.TableLayoutPanel solutionsPanel;
        private System.Windows.Forms.Panel driverPanel;
        private System.Windows.Forms.LinkLabel linkInstallInstructions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel helpPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}