
namespace N2D22.Window
{
    partial class WaitFm
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
            this.taskTitle = new System.Windows.Forms.Label();
            this.taskCaption = new System.Windows.Forms.Label();
            this.lnkVerbose = new System.Windows.Forms.LinkLabel();
            this.detailView = new System.Windows.Forms.Panel();
            this.debugOutput = new System.Windows.Forms.ListBox();
            this.header = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.extendedSpinner = new N2D22.Controls.ExtendedSpinner();
            this.detailView.SuspendLayout();
            this.header.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskTitle
            // 
            this.taskTitle.AutoSize = true;
            this.taskTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.taskTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.taskTitle.Location = new System.Drawing.Point(0, 0);
            this.taskTitle.Name = "taskTitle";
            this.taskTitle.Size = new System.Drawing.Size(101, 32);
            this.taskTitle.TabIndex = 0;
            this.taskTitle.Text = "Working";
            this.taskTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taskCaption
            // 
            this.taskCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskCaption.Location = new System.Drawing.Point(15, 52);
            this.taskCaption.Name = "taskCaption";
            this.taskCaption.Padding = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.taskCaption.Size = new System.Drawing.Size(570, 21);
            this.taskCaption.TabIndex = 1;
            this.taskCaption.Text = "This won\'t take long";
            // 
            // lnkVerbose
            // 
            this.lnkVerbose.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lnkVerbose.AutoEllipsis = true;
            this.lnkVerbose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lnkVerbose.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.lnkVerbose.Location = new System.Drawing.Point(15, 343);
            this.lnkVerbose.Name = "lnkVerbose";
            this.lnkVerbose.Size = new System.Drawing.Size(570, 32);
            this.lnkVerbose.TabIndex = 2;
            this.lnkVerbose.TabStop = true;
            this.lnkVerbose.Text = "Show Details";
            this.lnkVerbose.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lnkVerbose.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.lnkVerbose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVerbose_LinkClicked);
            // 
            // detailView
            // 
            this.detailView.BackColor = System.Drawing.SystemColors.Window;
            this.detailView.Controls.Add(this.debugOutput);
            this.detailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailView.Location = new System.Drawing.Point(15, 73);
            this.detailView.Name = "detailView";
            this.detailView.Padding = new System.Windows.Forms.Padding(5, 15, 5, 0);
            this.detailView.Size = new System.Drawing.Size(570, 270);
            this.detailView.TabIndex = 3;
            this.detailView.Visible = false;
            // 
            // debugOutput
            // 
            this.debugOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugOutput.FormattingEnabled = true;
            this.debugOutput.HorizontalScrollbar = true;
            this.debugOutput.ItemHeight = 15;
            this.debugOutput.Location = new System.Drawing.Point(5, 15);
            this.debugOutput.Name = "debugOutput";
            this.debugOutput.Size = new System.Drawing.Size(560, 255);
            this.debugOutput.TabIndex = 0;
            // 
            // header
            // 
            this.header.Controls.Add(this.container);
            this.header.Controls.Add(this.taskTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(15, 16);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(570, 36);
            this.header.TabIndex = 1;
            // 
            // container
            // 
            this.container.Controls.Add(this.extendedSpinner);
            this.container.Dock = System.Windows.Forms.DockStyle.Left;
            this.container.Location = new System.Drawing.Point(101, 0);
            this.container.Name = "container";
            this.container.Padding = new System.Windows.Forms.Padding(9, 4, 9, 8);
            this.container.Size = new System.Drawing.Size(42, 36);
            this.container.TabIndex = 8;
            // 
            // extendedSpinner
            // 
            this.extendedSpinner.Animated = true;
            this.extendedSpinner.BackObjectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.extendedSpinner.BackThickness = 2;
            this.extendedSpinner.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.extendedSpinner.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.extendedSpinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extendedSpinner.Gradient = false;
            this.extendedSpinner.Location = new System.Drawing.Point(9, 4);
            this.extendedSpinner.Name = "extendedSpinner";
            this.extendedSpinner.ObjectColor = System.Drawing.Color.DodgerBlue;
            this.extendedSpinner.Size = new System.Drawing.Size(24, 24);
            this.extendedSpinner.Speed = 7;
            this.extendedSpinner.TabIndex = 10;
            this.extendedSpinner.Thickness = 2;
            this.extendedSpinner.Trail = true;
            this.extendedSpinner.Value = 50;
            // 
            // WaitFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.detailView);
            this.Controls.Add(this.lnkVerbose);
            this.Controls.Add(this.taskCaption);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitFm";
            this.Padding = new System.Windows.Forms.Padding(15, 16, 15, 25);
            this.detailView.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label taskTitle;
        private System.Windows.Forms.Label taskCaption;
        private System.Windows.Forms.LinkLabel lnkVerbose;
        private System.Windows.Forms.Panel detailView;
        private System.Windows.Forms.ListBox debugOutput;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel container;
        private Controls.ExtendedSpinner extendedSpinner;
    }
}