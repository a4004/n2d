
namespace N2D22.Window
{
    partial class MessageFm
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
            this.header = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Label();
            this.mCaption = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
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
            this.message.Size = new System.Drawing.Size(279, 32);
            this.message.TabIndex = 0;
            this.message.Text = "Something has happened";
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
            this.mCaption.Text = "If you\'re seeing this page, please restart the application";
            // 
            // MessageFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.mCaption);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageFm";
            this.Padding = new System.Windows.Forms.Padding(15, 16, 15, 25);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label mCaption;
    }
}