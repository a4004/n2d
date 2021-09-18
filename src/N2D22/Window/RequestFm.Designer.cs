
namespace N2D22.Window
{
    partial class RequestFm
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
            this.question = new System.Windows.Forms.Label();
            this.qCaption = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.submit = new System.Windows.Forms.Button();
            this.body = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.header.SuspendLayout();
            this.footer.SuspendLayout();
            this.body.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.question);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(15, 16);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(570, 36);
            this.header.TabIndex = 2;
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Dock = System.Windows.Forms.DockStyle.Left;
            this.question.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.question.Location = new System.Drawing.Point(0, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(300, 32);
            this.question.TabIndex = 0;
            this.question.Text = "What would you like to do?";
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
            this.qCaption.TabIndex = 3;
            this.qCaption.Text = "You can change your mind at any time";
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.SystemColors.Window;
            this.footer.Controls.Add(this.submit);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(15, 330);
            this.footer.Name = "footer";
            this.footer.Padding = new System.Windows.Forms.Padding(0, 10, 5, 10);
            this.footer.Size = new System.Drawing.Size(570, 45);
            this.footer.TabIndex = 4;
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
            this.body.Controls.Add(this.panel1);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(15, 73);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(570, 257);
            this.body.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.option2);
            this.panel1.Controls.Add(this.option1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 7, 0, 10);
            this.panel1.Size = new System.Drawing.Size(570, 75);
            this.panel1.TabIndex = 6;
            // 
            // option2
            // 
            this.option2.Dock = System.Windows.Forms.DockStyle.Top;
            this.option2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.Location = new System.Drawing.Point(20, 30);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(550, 23);
            this.option2.TabIndex = 3;
            this.option2.Text = "Option 2";
            this.option2.UseVisualStyleBackColor = true;
            // 
            // option1
            // 
            this.option1.Checked = true;
            this.option1.Dock = System.Windows.Forms.DockStyle.Top;
            this.option1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.Location = new System.Drawing.Point(20, 7);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(550, 23);
            this.option1.TabIndex = 2;
            this.option1.TabStop = true;
            this.option1.Text = "Option 1";
            this.option1.UseVisualStyleBackColor = true;
            // 
            // RequestFm
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
            this.Name = "RequestFm";
            this.Padding = new System.Windows.Forms.Padding(15, 16, 15, 25);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.footer.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label qCaption;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option1;
    }
}