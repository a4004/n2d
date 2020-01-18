namespace N2D2
{
    partial class MainWnd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWnd));
            this.stageBack = new System.Windows.Forms.Panel();
            this.stageProgress = new System.Windows.Forms.Panel();
            this.progressFader = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.progressFaderT = new System.Windows.Forms.Timer(this.components);
            this.animatedCircle = new System.Windows.Forms.Timer(this.components);
            this.titleLbl = new System.Windows.Forms.Label();
            this.captionLbl = new System.Windows.Forms.Label();
            this.titleApp = new System.Windows.Forms.Label();
            this.captionApp = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.RichTextBox();
            this.debugBorder = new System.Windows.Forms.Panel();
            this.debugTitle = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.Button();
            this.discordLink = new System.Windows.Forms.LinkLabel();
            this.labelPulseCLR = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.labelPulser = new System.Windows.Forms.Timer(this.components);
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.circleProg = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.exitBtn = new System.Windows.Forms.Button();
            this.progC1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.progC2 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.errorFader = new System.Windows.Forms.Timer(this.components);
            this.stageBack.SuspendLayout();
            this.debugBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // stageBack
            // 
            this.stageBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stageBack.Controls.Add(this.stageProgress);
            this.stageBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stageBack.Location = new System.Drawing.Point(0, 374);
            this.stageBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stageBack.Name = "stageBack";
            this.stageBack.Size = new System.Drawing.Size(666, 14);
            this.stageBack.TabIndex = 0;
            // 
            // stageProgress
            // 
            this.stageProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(116)))), ((int)(((byte)(255)))));
            this.stageProgress.Dock = System.Windows.Forms.DockStyle.Left;
            this.stageProgress.Location = new System.Drawing.Point(0, 0);
            this.stageProgress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stageProgress.Name = "stageProgress";
            this.stageProgress.Size = new System.Drawing.Size(138, 14);
            this.stageProgress.TabIndex = 1;
            // 
            // progressFader
            // 
            this.progressFader.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(116)))), ((int)(((byte)(255)))));
            this.progressFader.Color2 = System.Drawing.Color.MediumTurquoise;
            this.progressFader.ProgessValue = 0;
            // 
            // progressFaderT
            // 
            this.progressFaderT.Enabled = true;
            this.progressFaderT.Interval = 50;
            this.progressFaderT.Tick += new System.EventHandler(this.progressFaderT_Tick);
            // 
            // animatedCircle
            // 
            this.animatedCircle.Enabled = true;
            this.animatedCircle.Tick += new System.EventHandler(this.animatedCircle_Tick);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(22, 30);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(226, 25);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Connect your device";
            // 
            // captionLbl
            // 
            this.captionLbl.AutoSize = true;
            this.captionLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLbl.Location = new System.Drawing.Point(23, 55);
            this.captionLbl.Name = "captionLbl";
            this.captionLbl.Size = new System.Drawing.Size(169, 20);
            this.captionLbl.TabIndex = 3;
            this.captionLbl.Text = "Searching for devices";
            // 
            // titleApp
            // 
            this.titleApp.AutoSize = true;
            this.titleApp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleApp.Location = new System.Drawing.Point(93, 300);
            this.titleApp.Name = "titleApp";
            this.titleApp.Size = new System.Drawing.Size(156, 19);
            this.titleApp.TabIndex = 5;
            this.titleApp.Text = "Node2Deauther V2";
            // 
            // captionApp
            // 
            this.captionApp.AutoSize = true;
            this.captionApp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionApp.Location = new System.Drawing.Point(94, 320);
            this.captionApp.Name = "captionApp";
            this.captionApp.Size = new System.Drawing.Size(107, 17);
            this.captionApp.TabIndex = 6;
            this.captionApp.Text = "by mrvodka007";
            // 
            // debug
            // 
            this.debug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.debug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debug.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug.ForeColor = System.Drawing.Color.Gainsboro;
            this.debug.HideSelection = false;
            this.debug.Location = new System.Drawing.Point(1, 1);
            this.debug.Name = "debug";
            this.debug.ReadOnly = true;
            this.debug.Size = new System.Drawing.Size(640, 117);
            this.debug.TabIndex = 7;
            this.debug.Text = "";
            // 
            // debugBorder
            // 
            this.debugBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(116)))), ((int)(((byte)(255)))));
            this.debugBorder.Controls.Add(this.debug);
            this.debugBorder.Location = new System.Drawing.Point(12, 148);
            this.debugBorder.Name = "debugBorder";
            this.debugBorder.Size = new System.Drawing.Size(642, 119);
            this.debugBorder.TabIndex = 8;
            // 
            // debugTitle
            // 
            this.debugTitle.AutoSize = true;
            this.debugTitle.Location = new System.Drawing.Point(9, 125);
            this.debugTitle.Name = "debugTitle";
            this.debugTitle.Size = new System.Drawing.Size(87, 17);
            this.debugTitle.TabIndex = 9;
            this.debugTitle.Text = "Activity Log:";
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.helpBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(116)))), ((int)(((byte)(255)))));
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Location = new System.Drawing.Point(514, 282);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(139, 31);
            this.helpBtn.TabIndex = 10;
            this.helpBtn.Text = "Help and Support";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // discordLink
            // 
            this.discordLink.ActiveLinkColor = System.Drawing.Color.Lime;
            this.discordLink.AutoSize = true;
            this.discordLink.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordLink.ForeColor = System.Drawing.Color.Lime;
            this.discordLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(116)))), ((int)(((byte)(255)))));
            this.discordLink.Location = new System.Drawing.Point(93, 340);
            this.discordLink.Name = "discordLink";
            this.discordLink.Size = new System.Drawing.Size(101, 16);
            this.discordLink.TabIndex = 11;
            this.discordLink.TabStop = true;
            this.discordLink.Text = "Discord Server";
            this.discordLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(116)))), ((int)(((byte)(255)))));
            this.discordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.discordLink_LinkClicked);
            // 
            // labelPulseCLR
            // 
            this.labelPulseCLR.Color1 = System.Drawing.Color.White;
            this.labelPulseCLR.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelPulseCLR.ProgessValue = 0;
            // 
            // labelPulser
            // 
            this.labelPulser.Enabled = true;
            this.labelPulser.Interval = 50;
            this.labelPulser.Tick += new System.EventHandler(this.labelPulser_Tick);
            // 
            // logoBox
            // 
            this.logoBox.Image = global::N2D2.Properties.Resources.N2D_ICON;
            this.logoBox.Location = new System.Drawing.Point(12, 282);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(75, 79);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 4;
            this.logoBox.TabStop = false;
            // 
            // circleProg
            // 
            this.circleProg.animated = true;
            this.circleProg.animationIterval = 10;
            this.circleProg.animationSpeed = 1;
            this.circleProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.circleProg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleProg.BackgroundImage")));
            this.circleProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circleProg.ForeColor = System.Drawing.Color.SeaGreen;
            this.circleProg.LabelVisible = false;
            this.circleProg.LineProgressThickness = 2;
            this.circleProg.LineThickness = 0;
            this.circleProg.Location = new System.Drawing.Point(574, 21);
            this.circleProg.Margin = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.circleProg.MaxValue = 100;
            this.circleProg.Name = "circleProg";
            this.circleProg.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.circleProg.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(116)))), ((int)(((byte)(255)))));
            this.circleProg.Size = new System.Drawing.Size(69, 69);
            this.circleProg.TabIndex = 1;
            this.circleProg.Value = 70;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(445, 282);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(63, 31);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Visible = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // progC1
            // 
            this.progC1.Color1 = System.Drawing.Color.White;
            this.progC1.Color2 = System.Drawing.Color.Red;
            this.progC1.ProgessValue = 0;
            // 
            // progC2
            // 
            this.progC2.Color1 = System.Drawing.Color.White;
            this.progC2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.progC2.ProgessValue = 0;
            // 
            // errorFader
            // 
            this.errorFader.Interval = 50;
            this.errorFader.Tick += new System.EventHandler(this.errorFader_Tick);
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(666, 388);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.discordLink);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.debugTitle);
            this.Controls.Add(this.debugBorder);
            this.Controls.Add(this.captionApp);
            this.Controls.Add(this.titleApp);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.captionLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.circleProg);
            this.Controls.Add(this.stageBack);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Node2Deauther";
            this.Load += new System.EventHandler(this.MainWnd_Load);
            this.stageBack.ResumeLayout(false);
            this.debugBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel stageBack;
        private System.Windows.Forms.Panel stageProgress;
        private Bunifu.Framework.UI.BunifuColorTransition progressFader;
        private System.Windows.Forms.Timer progressFaderT;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleProg;
        private System.Windows.Forms.Timer animatedCircle;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label captionLbl;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label titleApp;
        private System.Windows.Forms.Label captionApp;
        private System.Windows.Forms.RichTextBox debug;
        private System.Windows.Forms.Panel debugBorder;
        private System.Windows.Forms.Label debugTitle;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.LinkLabel discordLink;
        private Bunifu.Framework.UI.BunifuColorTransition labelPulseCLR;
        private System.Windows.Forms.Timer labelPulser;
        private System.Windows.Forms.Button exitBtn;
        private Bunifu.Framework.UI.BunifuColorTransition progC1;
        private Bunifu.Framework.UI.BunifuColorTransition progC2;
        private System.Windows.Forms.Timer errorFader;
    }
}

