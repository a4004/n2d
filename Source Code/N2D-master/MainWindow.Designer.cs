namespace N2D
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.close_btn = new System.Windows.Forms.Label();
            this.minimize_btn = new System.Windows.Forms.Label();
            this.menubar = new System.Windows.Forms.Panel();
            this.aboutlink = new System.Windows.Forms.LinkLabel();
            this.status3 = new System.Windows.Forms.Label();
            this.status2 = new System.Windows.Forms.Label();
            this.status1 = new System.Windows.Forms.Label();
            this.msg1 = new System.Windows.Forms.Label();
            this.linelbl = new System.Windows.Forms.Label();
            this.idriver_btn = new System.Windows.Forms.Button();
            this.mainpage = new System.Windows.Forms.Panel();
            this.pag2 = new System.Windows.Forms.Panel();
            this.flash = new System.Windows.Forms.Panel();
            this.finished = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.RichTextBox();
            this.status_flash = new System.Windows.Forms.Label();
            this.stat = new System.Windows.Forms.Label();
            this.wifi = new System.Windows.Forms.Label();
            this.flashbtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.Label();
            this.hint = new System.Windows.Forms.Label();
            this.base_block = new System.Windows.Forms.Panel();
            this.block = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.COM_DEVICE = new System.IO.Ports.SerialPort(this.components);
            this.Board_Sniffer = new System.ComponentModel.BackgroundWorker();
            this.Loading_t = new System.Windows.Forms.Timer(this.components);
            this.FlashDevice = new System.ComponentModel.BackgroundWorker();
            this.Loading_t_2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.circlebar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.icon3 = new System.Windows.Forms.PictureBox();
            this.icon2 = new System.Windows.Forms.PictureBox();
            this.icon1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.com_list = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menubar.SuspendLayout();
            this.mainpage.SuspendLayout();
            this.pag2.SuspendLayout();
            this.flash.SuspendLayout();
            this.finished.SuspendLayout();
            this.base_block.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).BeginInit();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(770, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(25, 28);
            this.close_btn.TabIndex = 0;
            this.close_btn.Text = "x";
            this.close_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.close_btn.MouseLeave += new System.EventHandler(this.Close_btn_MouseLeave);
            this.close_btn.MouseHover += new System.EventHandler(this.Close_btn_MouseHover);
            // 
            // minimize_btn
            // 
            this.minimize_btn.AutoSize = true;
            this.minimize_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.Location = new System.Drawing.Point(739, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(24, 28);
            this.minimize_btn.TabIndex = 1;
            this.minimize_btn.Text = "_";
            this.minimize_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            this.minimize_btn.MouseLeave += new System.EventHandler(this.Minimize_btn_MouseLeave);
            this.minimize_btn.MouseHover += new System.EventHandler(this.Minimize_btn_MouseHover);
            // 
            // menubar
            // 
            this.menubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.menubar.Controls.Add(this.aboutlink);
            this.menubar.Controls.Add(this.icon3);
            this.menubar.Controls.Add(this.status3);
            this.menubar.Controls.Add(this.icon2);
            this.menubar.Controls.Add(this.status2);
            this.menubar.Controls.Add(this.icon1);
            this.menubar.Controls.Add(this.status1);
            this.menubar.Controls.Add(this.msg1);
            this.menubar.Controls.Add(this.linelbl);
            this.menubar.Controls.Add(this.idriver_btn);
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(168, 448);
            this.menubar.TabIndex = 2;
            // 
            // aboutlink
            // 
            this.aboutlink.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.aboutlink.AutoSize = true;
            this.aboutlink.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutlink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.aboutlink.Location = new System.Drawing.Point(12, 316);
            this.aboutlink.Name = "aboutlink";
            this.aboutlink.Size = new System.Drawing.Size(50, 20);
            this.aboutlink.TabIndex = 9;
            this.aboutlink.TabStop = true;
            this.aboutlink.Text = "About";
            this.aboutlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Aboutlink_LinkClicked);
            // 
            // status3
            // 
            this.status3.AutoSize = true;
            this.status3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status3.ForeColor = System.Drawing.Color.White;
            this.status3.Location = new System.Drawing.Point(65, 169);
            this.status3.Name = "status3";
            this.status3.Size = new System.Drawing.Size(51, 21);
            this.status3.TabIndex = 7;
            this.status3.Text = "Flash!";
            // 
            // status2
            // 
            this.status2.AutoSize = true;
            this.status2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status2.ForeColor = System.Drawing.Color.White;
            this.status2.Location = new System.Drawing.Point(25, 89);
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(134, 21);
            this.status2.TabIndex = 5;
            this.status2.Text = "Prepare Firmware";
            // 
            // status1
            // 
            this.status1.AutoSize = true;
            this.status1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status1.ForeColor = System.Drawing.Color.White;
            this.status1.Location = new System.Drawing.Point(38, 13);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(104, 21);
            this.status1.TabIndex = 3;
            this.status1.Text = "Detect Device";
            // 
            // msg1
            // 
            this.msg1.AutoSize = true;
            this.msg1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg1.ForeColor = System.Drawing.Color.White;
            this.msg1.Location = new System.Drawing.Point(12, 355);
            this.msg1.Name = "msg1";
            this.msg1.Size = new System.Drawing.Size(130, 26);
            this.msg1.TabIndex = 2;
            this.msg1.Text = "Having trouble with the\r\nconnection?";
            // 
            // linelbl
            // 
            this.linelbl.AutoSize = true;
            this.linelbl.Location = new System.Drawing.Point(12, 333);
            this.linelbl.Name = "linelbl";
            this.linelbl.Size = new System.Drawing.Size(148, 17);
            this.linelbl.TabIndex = 1;
            this.linelbl.Text = "____________________________";
            // 
            // idriver_btn
            // 
            this.idriver_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.idriver_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.idriver_btn.FlatAppearance.BorderSize = 0;
            this.idriver_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idriver_btn.Location = new System.Drawing.Point(12, 401);
            this.idriver_btn.Name = "idriver_btn";
            this.idriver_btn.Size = new System.Drawing.Size(145, 35);
            this.idriver_btn.TabIndex = 0;
            this.idriver_btn.Text = "Install Drivers";
            this.idriver_btn.UseVisualStyleBackColor = false;
            this.idriver_btn.Click += new System.EventHandler(this.Idriver_btn_Click);
            // 
            // mainpage
            // 
            this.mainpage.Controls.Add(this.pag2);
            this.mainpage.Controls.Add(this.logo);
            this.mainpage.Controls.Add(this.hint);
            this.mainpage.Controls.Add(this.base_block);
            this.mainpage.Controls.Add(this.info);
            this.mainpage.Location = new System.Drawing.Point(174, 31);
            this.mainpage.Name = "mainpage";
            this.mainpage.Size = new System.Drawing.Size(625, 417);
            this.mainpage.TabIndex = 3;
            // 
            // pag2
            // 
            this.pag2.Controls.Add(this.flash);
            this.pag2.Controls.Add(this.wifi);
            this.pag2.Controls.Add(this.flashbtn);
            this.pag2.Controls.Add(this.logo2);
            this.pag2.Controls.Add(this.name);
            this.pag2.Controls.Add(this.info2);
            this.pag2.Controls.Add(this.label3);
            this.pag2.Controls.Add(this.label4);
            this.pag2.Controls.Add(this.com_list);
            this.pag2.Location = new System.Drawing.Point(3, 6);
            this.pag2.Name = "pag2";
            this.pag2.Size = new System.Drawing.Size(622, 408);
            this.pag2.TabIndex = 4;
            this.pag2.Visible = false;
            // 
            // flash
            // 
            this.flash.Controls.Add(this.finished);
            this.flash.Controls.Add(this.log);
            this.flash.Controls.Add(this.circlebar);
            this.flash.Controls.Add(this.status_flash);
            this.flash.Controls.Add(this.stat);
            this.flash.Location = new System.Drawing.Point(3, 3);
            this.flash.Name = "flash";
            this.flash.Size = new System.Drawing.Size(611, 405);
            this.flash.TabIndex = 7;
            this.flash.Visible = false;
            // 
            // finished
            // 
            this.finished.Controls.Add(this.label2);
            this.finished.Controls.Add(this.pictureBox1);
            this.finished.Controls.Add(this.label1);
            this.finished.Location = new System.Drawing.Point(19, 3);
            this.finished.Name = "finished";
            this.finished.Size = new System.Drawing.Size(580, 396);
            this.finished.TabIndex = 6;
            this.finished.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 126);
            this.label2.TabIndex = 5;
            this.label2.Text = "To use your deauther, go on a WiFi enabled device and\r\nconnect to the SSID named " +
    "\'pwned\' with the password\r\n\'deauther\' - Then navigate to http://192.168.4.1\r\n\r\n\r" +
    "\nHAVE FUN!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Flash Complete!";
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Black;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.Location = new System.Drawing.Point(111, 127);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(416, 217);
            this.log.TabIndex = 5;
            this.log.Text = "_";
            // 
            // status_flash
            // 
            this.status_flash.AutoSize = true;
            this.status_flash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_flash.Location = new System.Drawing.Point(107, 74);
            this.status_flash.Name = "status_flash";
            this.status_flash.Size = new System.Drawing.Size(212, 21);
            this.status_flash.TabIndex = 4;
            this.status_flash.Text = "Downloading firmware..............";
            // 
            // stat
            // 
            this.stat.AutoSize = true;
            this.stat.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat.Location = new System.Drawing.Point(106, 27);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(149, 30);
            this.stat.TabIndex = 2;
            this.stat.Text = "Getting Ready";
            // 
            // wifi
            // 
            this.wifi.AutoEllipsis = true;
            this.wifi.AutoSize = true;
            this.wifi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wifi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.wifi.Location = new System.Drawing.Point(9, 296);
            this.wifi.Name = "wifi";
            this.wifi.Size = new System.Drawing.Size(593, 34);
            this.wifi.TabIndex = 6;
            this.wifi.Text = "IMPORTANT: An Internet connection is REQUIRED to download the firmware files! - P" +
    "lease allow N2D\r\n                    through your antivirus / firewall.";
            // 
            // flashbtn
            // 
            this.flashbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.flashbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.flashbtn.FlatAppearance.BorderSize = 0;
            this.flashbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flashbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flashbtn.Location = new System.Drawing.Point(235, 227);
            this.flashbtn.Name = "flashbtn";
            this.flashbtn.Size = new System.Drawing.Size(144, 39);
            this.flashbtn.TabIndex = 5;
            this.flashbtn.Text = "Begin Flash";
            this.flashbtn.UseVisualStyleBackColor = false;
            this.flashbtn.Click += new System.EventHandler(this.Flashbtn_Click);
            // 
            // name
            // 
            this.name.AutoEllipsis = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(75, 62);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(460, 21);
            this.name.TabIndex = 3;
            this.name.Text = "Name:";
            this.name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2.Location = new System.Drawing.Point(230, 24);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(149, 30);
            this.info2.TabIndex = 1;
            this.info2.Text = "Device Found!";
            // 
            // hint
            // 
            this.hint.AutoSize = true;
            this.hint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint.Location = new System.Drawing.Point(205, 67);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(239, 17);
            this.hint.TabIndex = 2;
            this.hint.Text = "Please plug in your development board";
            // 
            // base_block
            // 
            this.base_block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.base_block.Controls.Add(this.block);
            this.base_block.Location = new System.Drawing.Point(117, 103);
            this.base_block.Name = "base_block";
            this.base_block.Size = new System.Drawing.Size(416, 5);
            this.base_block.TabIndex = 1;
            // 
            // block
            // 
            this.block.BackColor = System.Drawing.Color.Cyan;
            this.block.Location = new System.Drawing.Point(342, 0);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(74, 10);
            this.block.TabIndex = 2;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(197, 35);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(261, 30);
            this.info.TabIndex = 0;
            this.info.Text = "Looking for an ESP8266....";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(174, 7);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(38, 17);
            this.title.TabIndex = 4;
            this.title.Text = "N2D ";
            // 
            // Board_Sniffer
            // 
            this.Board_Sniffer.WorkerSupportsCancellation = true;
            this.Board_Sniffer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Board_Sniffer_DoWork);
            // 
            // Loading_t
            // 
            this.Loading_t.Enabled = true;
            this.Loading_t.Interval = 5;
            this.Loading_t.Tick += new System.EventHandler(this.Loading_t_Tick);
            // 
            // FlashDevice
            // 
            this.FlashDevice.WorkerSupportsCancellation = true;
            this.FlashDevice.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FlashDevice_DoWork);
            // 
            // Loading_t_2
            // 
            this.Loading_t_2.Enabled = true;
            this.Loading_t_2.Interval = 1;
            this.Loading_t_2.Tick += new System.EventHandler(this.Loading_t_2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::N2D.Properties.Resources.done;
            this.pictureBox1.Location = new System.Drawing.Point(213, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // circlebar
            // 
            this.circlebar.animated = true;
            this.circlebar.animationIterval = 10;
            this.circlebar.animationSpeed = 1;
            this.circlebar.BackColor = System.Drawing.Color.Transparent;
            this.circlebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circlebar.BackgroundImage")));
            this.circlebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circlebar.ForeColor = System.Drawing.Color.SeaGreen;
            this.circlebar.LabelVisible = false;
            this.circlebar.LineProgressThickness = 8;
            this.circlebar.LineThickness = 5;
            this.circlebar.Location = new System.Drawing.Point(451, 27);
            this.circlebar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.circlebar.MaxValue = 100;
            this.circlebar.Name = "circlebar";
            this.circlebar.ProgressBackColor = System.Drawing.Color.Transparent;
            this.circlebar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.circlebar.Size = new System.Drawing.Size(77, 77);
            this.circlebar.TabIndex = 7;
            this.circlebar.Value = 10;
            // 
            // logo2
            // 
            this.logo2.Image = global::N2D.Properties.Resources.check64;
            this.logo2.Location = new System.Drawing.Point(22, 97);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(560, 63);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 4;
            this.logo2.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::N2D.Properties.Resources.ICON_DEAUTHER;
            this.logo.Location = new System.Drawing.Point(25, 133);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(580, 63);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // icon3
            // 
            this.icon3.Image = global::N2D.Properties.Resources.upcoming;
            this.icon3.Location = new System.Drawing.Point(38, 193);
            this.icon3.Name = "icon3";
            this.icon3.Size = new System.Drawing.Size(104, 44);
            this.icon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon3.TabIndex = 8;
            this.icon3.TabStop = false;
            // 
            // icon2
            // 
            this.icon2.Image = global::N2D.Properties.Resources.upcoming;
            this.icon2.Location = new System.Drawing.Point(38, 113);
            this.icon2.Name = "icon2";
            this.icon2.Size = new System.Drawing.Size(104, 44);
            this.icon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon2.TabIndex = 6;
            this.icon2.TabStop = false;
            // 
            // icon1
            // 
            this.icon1.Image = global::N2D.Properties.Resources.inprog;
            this.icon1.Location = new System.Drawing.Point(38, 37);
            this.icon1.Name = "icon1";
            this.icon1.Size = new System.Drawing.Size(104, 44);
            this.icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon1.TabIndex = 4;
            this.icon1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Incorrect device? - Choose COM Port:";
            // 
            // com_list
            // 
            this.com_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.com_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.com_list.ForeColor = System.Drawing.Color.White;
            this.com_list.FormattingEnabled = true;
            this.com_list.Location = new System.Drawing.Point(295, 180);
            this.com_list.Name = "com_list";
            this.com_list.Size = new System.Drawing.Size(291, 25);
            this.com_list.TabIndex = 9;
            this.com_list.SelectedIndexChanged += new System.EventHandler(this.Com_list_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "If device is still not found, please relaunch the app.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(803, 448);
            this.Controls.Add(this.title);
            this.Controls.Add(this.mainpage);
            this.Controls.Add(this.menubar);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.close_btn);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N2D";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.mainpage.ResumeLayout(false);
            this.mainpage.PerformLayout();
            this.pag2.ResumeLayout(false);
            this.pag2.PerformLayout();
            this.flash.ResumeLayout(false);
            this.flash.PerformLayout();
            this.finished.ResumeLayout(false);
            this.finished.PerformLayout();
            this.base_block.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.Label minimize_btn;
        private System.Windows.Forms.Panel menubar;
        private System.Windows.Forms.Button idriver_btn;
        private System.Windows.Forms.Panel mainpage;
        private System.Windows.Forms.Label linelbl;
        private System.Windows.Forms.Label status1;
        private System.Windows.Forms.Label msg1;
        private System.Windows.Forms.PictureBox icon1;
        private System.Windows.Forms.PictureBox icon3;
        private System.Windows.Forms.Label status3;
        private System.Windows.Forms.PictureBox icon2;
        private System.Windows.Forms.Label status2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.LinkLabel aboutlink;
        private System.IO.Ports.SerialPort COM_DEVICE;
        private System.ComponentModel.BackgroundWorker Board_Sniffer;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Timer Loading_t;
        private System.Windows.Forms.Panel base_block;
        private System.Windows.Forms.Panel block;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel pag2;
        private System.Windows.Forms.Label wifi;
        private System.Windows.Forms.Button flashbtn;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label info2;
        private System.ComponentModel.BackgroundWorker FlashDevice;
        private System.Windows.Forms.Panel flash;
        private System.Windows.Forms.Label stat;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Label status_flash;
        private System.Windows.Forms.Timer Loading_t_2;

        private System.Windows.Forms.Panel finished;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circlebar;
        private System.Windows.Forms.ComboBox com_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

