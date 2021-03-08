
namespace N2D.AppCore.UX.Pages
{
    partial class FlashPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashPage));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblWarn = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pbxAnimation = new System.Windows.Forms.PictureBox();
            this.pnlView1 = new System.Windows.Forms.Panel();
            this.pnlView2 = new System.Windows.Forms.Panel();
            this.pnlDiag = new System.Windows.Forms.Panel();
            this.lblLog = new System.Windows.Forms.Label();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.lnkDiag = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimation)).BeginInit();
            this.pnlView1.SuspendLayout();
            this.pnlView2.SuspendLayout();
            this.pnlDiag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlView2);
            this.pnlContainer.Controls.Add(this.pnlView1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(10, 10);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(628, 303);
            this.pnlContainer.TabIndex = 2;
            // 
            // lblWarn
            // 
            this.lblWarn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWarn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarn.ForeColor = System.Drawing.Color.Silver;
            this.lblWarn.Location = new System.Drawing.Point(0, 137);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(224, 52);
            this.lblWarn.TabIndex = 2;
            this.lblWarn.Text = "Please be patient while the process completes. DO NOT disconnect your device duri" +
    "ng this period.";
            this.lblWarn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(0, 107);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(224, 30);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Flashing...";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pbxAnimation
            // 
            this.pbxAnimation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxAnimation.Image = global::N2D.Properties.Resources.bolt_animated;
            this.pbxAnimation.Location = new System.Drawing.Point(0, 35);
            this.pbxAnimation.Name = "pbxAnimation";
            this.pbxAnimation.Size = new System.Drawing.Size(224, 72);
            this.pbxAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxAnimation.TabIndex = 0;
            this.pbxAnimation.TabStop = false;
            // 
            // pnlView1
            // 
            this.pnlView1.Controls.Add(this.lnkDiag);
            this.pnlView1.Controls.Add(this.lblWarn);
            this.pnlView1.Controls.Add(this.lblMessage);
            this.pnlView1.Controls.Add(this.pbxAnimation);
            this.pnlView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlView1.Location = new System.Drawing.Point(0, 0);
            this.pnlView1.Name = "pnlView1";
            this.pnlView1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.pnlView1.Size = new System.Drawing.Size(224, 303);
            this.pnlView1.TabIndex = 5;
            // 
            // pnlView2
            // 
            this.pnlView2.Controls.Add(this.label3);
            this.pnlView2.Controls.Add(this.label2);
            this.pnlView2.Controls.Add(this.label1);
            this.pnlView2.Controls.Add(this.pictureBox1);
            this.pnlView2.Controls.Add(this.pnlDiag);
            this.pnlView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView2.Location = new System.Drawing.Point(224, 0);
            this.pnlView2.Name = "pnlView2";
            this.pnlView2.Size = new System.Drawing.Size(404, 303);
            this.pnlView2.TabIndex = 6;
            // 
            // pnlDiag
            // 
            this.pnlDiag.Controls.Add(this.rtbOut);
            this.pnlDiag.Controls.Add(this.lblLog);
            this.pnlDiag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDiag.Location = new System.Drawing.Point(0, 127);
            this.pnlDiag.Name = "pnlDiag";
            this.pnlDiag.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDiag.Size = new System.Drawing.Size(404, 176);
            this.pnlDiag.TabIndex = 0;
            this.pnlDiag.Visible = false;
            // 
            // lblLog
            // 
            this.lblLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.ForeColor = System.Drawing.Color.White;
            this.lblLog.Location = new System.Drawing.Point(10, 10);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(384, 24);
            this.lblLog.TabIndex = 6;
            this.lblLog.Text = "Diagnostic Information:";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtbOut
            // 
            this.rtbOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.rtbOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOut.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOut.ForeColor = System.Drawing.Color.Silver;
            this.rtbOut.Location = new System.Drawing.Point(10, 34);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.ReadOnly = true;
            this.rtbOut.Size = new System.Drawing.Size(384, 132);
            this.rtbOut.TabIndex = 5;
            this.rtbOut.Text = "";
            // 
            // lnkDiag
            // 
            this.lnkDiag.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.lnkDiag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lnkDiag.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkDiag.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.lnkDiag.Location = new System.Drawing.Point(0, 215);
            this.lnkDiag.Name = "lnkDiag";
            this.lnkDiag.Size = new System.Drawing.Size(224, 88);
            this.lnkDiag.TabIndex = 5;
            this.lnkDiag.TabStop = true;
            this.lnkDiag.Text = "Show Diagnostic Information >>";
            this.lnkDiag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkDiag.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.lnkDiag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDiag_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::N2D.Properties.Resources.n2d_logo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(237)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(95, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Node2Deauther";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(97, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "version 2021.3";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(0, 90);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(404, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thanks for using N2D! Support by contributing to this or the deauther project.";
            // 
            // FlashPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(648, 323);
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlashPage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlashPage";
            this.Load += new System.EventHandler(this.FlashPage_Load);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimation)).EndInit();
            this.pnlView1.ResumeLayout(false);
            this.pnlView2.ResumeLayout(false);
            this.pnlView2.PerformLayout();
            this.pnlDiag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox pbxAnimation;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.Panel pnlView1;
        private System.Windows.Forms.Panel pnlView2;
        private System.Windows.Forms.Panel pnlDiag;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.LinkLabel lnkDiag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}