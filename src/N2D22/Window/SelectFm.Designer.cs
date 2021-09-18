
namespace N2D22.Window
{
    partial class SelectFm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "NULL",
            "NULL",
            "NULL"}, -1);
            this.header = new System.Windows.Forms.Panel();
            this.question = new System.Windows.Forms.Label();
            this.qCaption = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.versionSelect = new System.Windows.Forms.ComboBox();
            this.lblver = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.spacer = new System.Windows.Forms.Panel();
            this.submit = new System.Windows.Forms.Button();
            this.body = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.colvendor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colfile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colext = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header.SuspendLayout();
            this.footer.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.question);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(15, 16);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(570, 36);
            this.header.TabIndex = 3;
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Dock = System.Windows.Forms.DockStyle.Left;
            this.question.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.question.Location = new System.Drawing.Point(0, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(215, 32);
            this.question.TabIndex = 0;
            this.question.Text = "Software download";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // qCaption
            // 
            this.qCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.qCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qCaption.Location = new System.Drawing.Point(15, 52);
            this.qCaption.Name = "qCaption";
            this.qCaption.Padding = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.qCaption.Size = new System.Drawing.Size(570, 21);
            this.qCaption.TabIndex = 4;
            this.qCaption.Text = "Choose the appropriate software version for your device.";
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.SystemColors.Window;
            this.footer.Controls.Add(this.versionSelect);
            this.footer.Controls.Add(this.lblver);
            this.footer.Controls.Add(this.back);
            this.footer.Controls.Add(this.spacer);
            this.footer.Controls.Add(this.submit);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(15, 330);
            this.footer.Name = "footer";
            this.footer.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.footer.Size = new System.Drawing.Size(570, 45);
            this.footer.TabIndex = 6;
            // 
            // versionSelect
            // 
            this.versionSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.versionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionSelect.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionSelect.FormattingEnabled = true;
            this.versionSelect.Location = new System.Drawing.Point(55, 10);
            this.versionSelect.Name = "versionSelect";
            this.versionSelect.Size = new System.Drawing.Size(121, 21);
            this.versionSelect.TabIndex = 4;
            // 
            // lblver
            // 
            this.lblver.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblver.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblver.Location = new System.Drawing.Point(5, 10);
            this.lblver.Name = "lblver";
            this.lblver.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblver.Size = new System.Drawing.Size(50, 25);
            this.lblver.TabIndex = 5;
            this.lblver.Text = "Version:";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.back.Dock = System.Windows.Forms.DockStyle.Right;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(408, 10);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 25);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // spacer
            // 
            this.spacer.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacer.Location = new System.Drawing.Point(483, 10);
            this.spacer.Name = "spacer";
            this.spacer.Size = new System.Drawing.Size(7, 25);
            this.spacer.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.submit.Dock = System.Windows.Forms.DockStyle.Right;
            this.submit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(490, 10);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 25);
            this.submit.TabIndex = 0;
            this.submit.Text = "Next";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.SystemColors.Window;
            this.body.Controls.Add(this.listView);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(15, 73);
            this.body.Name = "body";
            this.body.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.body.Size = new System.Drawing.Size(570, 257);
            this.body.TabIndex = 7;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colvendor,
            this.colfile,
            this.colext});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView.Location = new System.Drawing.Point(5, 10);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(560, 237);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // colvendor
            // 
            this.colvendor.Text = "Vendor";
            this.colvendor.Width = 132;
            // 
            // colfile
            // 
            this.colfile.Text = "Version";
            this.colfile.Width = 349;
            // 
            // colext
            // 
            this.colext.Text = "Type";
            this.colext.Width = 75;
            // 
            // SelectFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.body);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.qCaption);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectFm";
            this.Padding = new System.Windows.Forms.Padding(15, 16, 15, 25);
            this.Load += new System.EventHandler(this.SelectFm_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.footer.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label qCaption;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Panel spacer;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ComboBox versionSelect;
        private System.Windows.Forms.Label lblver;
        private System.Windows.Forms.ColumnHeader colvendor;
        private System.Windows.Forms.ColumnHeader colfile;
        private System.Windows.Forms.ColumnHeader colext;
    }
}