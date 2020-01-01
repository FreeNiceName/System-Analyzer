namespace SystemAnalyzer
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSystemState = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.numMaxDiskLoad = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.lbDiskLoad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numMaxCpuTemperature = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numMaxDiskTemperature = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numMaxRamLoad = new System.Windows.Forms.NumericUpDown();
            this.numMaxPagingFileLoad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numMaxCpuLoad = new System.Windows.Forms.NumericUpDown();
            this.lbCPULoad = new System.Windows.Forms.Label();
            this.lbRAMLoad = new System.Windows.Forms.Label();
            this.lbCPUTemperature = new System.Windows.Forms.Label();
            this.lbPagingFileLoad = new System.Windows.Forms.Label();
            this.lbDiskTemperature = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutoSaveLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSystemInfo = new System.Windows.Forms.Panel();
            this.lbDiskDriveInfo = new System.Windows.Forms.Label();
            this.lbRamInfo = new System.Windows.Forms.Label();
            this.lbGpuInfo = new System.Windows.Forms.Label();
            this.lbMotherboardInfo = new System.Windows.Forms.Label();
            this.lbCpuInfo = new System.Windows.Forms.Label();
            this.lbOSInfo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timerUpdateInfo = new System.Windows.Forms.Timer(this.components);
            this.panelSystemState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDiskLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCpuTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDiskTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxRamLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPagingFileLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCpuLoad)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelSystemInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Температура процессора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Загрузка процессора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Загрузка файла подкачки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Температура диска";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Загрузка памяти";
            // 
            // panelSystemState
            // 
            this.panelSystemState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSystemState.Controls.Add(this.label25);
            this.panelSystemState.Controls.Add(this.numMaxDiskLoad);
            this.panelSystemState.Controls.Add(this.label24);
            this.panelSystemState.Controls.Add(this.lbDiskLoad);
            this.panelSystemState.Controls.Add(this.label7);
            this.panelSystemState.Controls.Add(this.label23);
            this.panelSystemState.Controls.Add(this.label22);
            this.panelSystemState.Controls.Add(this.label21);
            this.panelSystemState.Controls.Add(this.label20);
            this.panelSystemState.Controls.Add(this.label19);
            this.panelSystemState.Controls.Add(this.label18);
            this.panelSystemState.Controls.Add(this.numMaxCpuTemperature);
            this.panelSystemState.Controls.Add(this.label17);
            this.panelSystemState.Controls.Add(this.numMaxDiskTemperature);
            this.panelSystemState.Controls.Add(this.label10);
            this.panelSystemState.Controls.Add(this.label8);
            this.panelSystemState.Controls.Add(this.numMaxRamLoad);
            this.panelSystemState.Controls.Add(this.numMaxPagingFileLoad);
            this.panelSystemState.Controls.Add(this.label6);
            this.panelSystemState.Controls.Add(this.numMaxCpuLoad);
            this.panelSystemState.Controls.Add(this.lbCPULoad);
            this.panelSystemState.Controls.Add(this.lbRAMLoad);
            this.panelSystemState.Controls.Add(this.lbCPUTemperature);
            this.panelSystemState.Controls.Add(this.lbPagingFileLoad);
            this.panelSystemState.Controls.Add(this.lbDiskTemperature);
            this.panelSystemState.Controls.Add(this.label2);
            this.panelSystemState.Controls.Add(this.label5);
            this.panelSystemState.Controls.Add(this.label1);
            this.panelSystemState.Controls.Add(this.label3);
            this.panelSystemState.Controls.Add(this.label4);
            this.panelSystemState.Location = new System.Drawing.Point(12, 200);
            this.panelSystemState.Name = "panelSystemState";
            this.panelSystemState.Size = new System.Drawing.Size(551, 166);
            this.panelSystemState.TabIndex = 5;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(424, 140);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(15, 13);
            this.label25.TabIndex = 27;
            this.label25.Text = "%";
            // 
            // numMaxDiskLoad
            // 
            this.numMaxDiskLoad.Location = new System.Drawing.Point(355, 138);
            this.numMaxDiskLoad.Name = "numMaxDiskLoad";
            this.numMaxDiskLoad.Size = new System.Drawing.Size(63, 20);
            this.numMaxDiskLoad.TabIndex = 6;
            this.numMaxDiskLoad.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numMaxDiskLoad.ValueChanged += new System.EventHandler(this.numMaxDiskLoad_ValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(230, 140);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(124, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Предупреждение при >";
            // 
            // lbDiskLoad
            // 
            this.lbDiskLoad.AutoSize = true;
            this.lbDiskLoad.Location = new System.Drawing.Point(187, 140);
            this.lbDiskLoad.Name = "lbDiskLoad";
            this.lbDiskLoad.Size = new System.Drawing.Size(13, 13);
            this.lbDiskLoad.TabIndex = 24;
            this.lbDiskLoad.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Загрузка диска";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(424, 65);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "%";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(424, 93);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(424, 115);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "°C";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(424, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "°C";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(424, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "%";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(230, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Предупреждение при >";
            // 
            // numMaxCpuTemperature
            // 
            this.numMaxCpuTemperature.Location = new System.Drawing.Point(355, 13);
            this.numMaxCpuTemperature.Name = "numMaxCpuTemperature";
            this.numMaxCpuTemperature.Size = new System.Drawing.Size(63, 20);
            this.numMaxCpuTemperature.TabIndex = 1;
            this.numMaxCpuTemperature.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMaxCpuTemperature.ValueChanged += new System.EventHandler(this.numMaxCpuTemperature_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(230, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Предупреждение при >";
            // 
            // numMaxDiskTemperature
            // 
            this.numMaxDiskTemperature.Location = new System.Drawing.Point(355, 113);
            this.numMaxDiskTemperature.Name = "numMaxDiskTemperature";
            this.numMaxDiskTemperature.Size = new System.Drawing.Size(63, 20);
            this.numMaxDiskTemperature.TabIndex = 5;
            this.numMaxDiskTemperature.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numMaxDiskTemperature.ValueChanged += new System.EventHandler(this.numMaxDiskTemperature_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Предупреждение при >";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Предупреждение при >";
            // 
            // numMaxRamLoad
            // 
            this.numMaxRamLoad.Location = new System.Drawing.Point(355, 63);
            this.numMaxRamLoad.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numMaxRamLoad.Name = "numMaxRamLoad";
            this.numMaxRamLoad.Size = new System.Drawing.Size(63, 20);
            this.numMaxRamLoad.TabIndex = 3;
            this.numMaxRamLoad.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numMaxRamLoad.ValueChanged += new System.EventHandler(this.numMaxRamLoad_ValueChanged);
            // 
            // numMaxPagingFileLoad
            // 
            this.numMaxPagingFileLoad.Location = new System.Drawing.Point(355, 88);
            this.numMaxPagingFileLoad.Name = "numMaxPagingFileLoad";
            this.numMaxPagingFileLoad.Size = new System.Drawing.Size(63, 20);
            this.numMaxPagingFileLoad.TabIndex = 4;
            this.numMaxPagingFileLoad.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numMaxPagingFileLoad.ValueChanged += new System.EventHandler(this.numMaxPagingFileLoad_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Предупреждение при >";
            // 
            // numMaxCpuLoad
            // 
            this.numMaxCpuLoad.Location = new System.Drawing.Point(355, 38);
            this.numMaxCpuLoad.Name = "numMaxCpuLoad";
            this.numMaxCpuLoad.Size = new System.Drawing.Size(63, 20);
            this.numMaxCpuLoad.TabIndex = 2;
            this.numMaxCpuLoad.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numMaxCpuLoad.ValueChanged += new System.EventHandler(this.numMaxCpuLoad_ValueChanged);
            // 
            // lbCPULoad
            // 
            this.lbCPULoad.AutoSize = true;
            this.lbCPULoad.Location = new System.Drawing.Point(187, 40);
            this.lbCPULoad.Name = "lbCPULoad";
            this.lbCPULoad.Size = new System.Drawing.Size(13, 13);
            this.lbCPULoad.TabIndex = 6;
            this.lbCPULoad.Text = "0";
            // 
            // lbRAMLoad
            // 
            this.lbRAMLoad.AutoSize = true;
            this.lbRAMLoad.Location = new System.Drawing.Point(187, 65);
            this.lbRAMLoad.Name = "lbRAMLoad";
            this.lbRAMLoad.Size = new System.Drawing.Size(13, 13);
            this.lbRAMLoad.TabIndex = 9;
            this.lbRAMLoad.Text = "0";
            // 
            // lbCPUTemperature
            // 
            this.lbCPUTemperature.AutoSize = true;
            this.lbCPUTemperature.Location = new System.Drawing.Point(187, 15);
            this.lbCPUTemperature.Name = "lbCPUTemperature";
            this.lbCPUTemperature.Size = new System.Drawing.Size(13, 13);
            this.lbCPUTemperature.TabIndex = 5;
            this.lbCPUTemperature.Text = "0";
            // 
            // lbPagingFileLoad
            // 
            this.lbPagingFileLoad.AutoSize = true;
            this.lbPagingFileLoad.Location = new System.Drawing.Point(187, 90);
            this.lbPagingFileLoad.Name = "lbPagingFileLoad";
            this.lbPagingFileLoad.Size = new System.Drawing.Size(13, 13);
            this.lbPagingFileLoad.TabIndex = 8;
            this.lbPagingFileLoad.Text = "0";
            // 
            // lbDiskTemperature
            // 
            this.lbDiskTemperature.AutoSize = true;
            this.lbDiskTemperature.Location = new System.Drawing.Point(187, 115);
            this.lbDiskTemperature.Name = "lbDiskTemperature";
            this.lbDiskTemperature.Size = new System.Drawing.Size(13, 13);
            this.lbDiskTemperature.TabIndex = 7;
            this.lbDiskTemperature.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenLog,
            this.menuAutoSaveLogs,
            this.ExitMenu});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // menuOpenLog
            // 
            this.menuOpenLog.Name = "menuOpenLog";
            this.menuOpenLog.Size = new System.Drawing.Size(199, 22);
            this.menuOpenLog.Text = "Посмотреть лог";
            this.menuOpenLog.Click += new System.EventHandler(this.menuOpenLog_Click);
            // 
            // menuAutoSaveLogs
            // 
            this.menuAutoSaveLogs.Checked = true;
            this.menuAutoSaveLogs.CheckOnClick = true;
            this.menuAutoSaveLogs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuAutoSaveLogs.Name = "menuAutoSaveLogs";
            this.menuAutoSaveLogs.Size = new System.Drawing.Size(199, 22);
            this.menuAutoSaveLogs.Text = "Автосохранение логов";
            this.menuAutoSaveLogs.CheckedChanged += new System.EventHandler(this.menuAutoSaveLogs_CheckedChanged);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(199, 22);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // panelSystemInfo
            // 
            this.panelSystemInfo.Controls.Add(this.lbDiskDriveInfo);
            this.panelSystemInfo.Controls.Add(this.lbRamInfo);
            this.panelSystemInfo.Controls.Add(this.lbGpuInfo);
            this.panelSystemInfo.Controls.Add(this.lbMotherboardInfo);
            this.panelSystemInfo.Controls.Add(this.lbCpuInfo);
            this.panelSystemInfo.Controls.Add(this.lbOSInfo);
            this.panelSystemInfo.Controls.Add(this.label16);
            this.panelSystemInfo.Controls.Add(this.label15);
            this.panelSystemInfo.Controls.Add(this.label14);
            this.panelSystemInfo.Controls.Add(this.label13);
            this.panelSystemInfo.Controls.Add(this.label12);
            this.panelSystemInfo.Controls.Add(this.label11);
            this.panelSystemInfo.Location = new System.Drawing.Point(12, 27);
            this.panelSystemInfo.Name = "panelSystemInfo";
            this.panelSystemInfo.Size = new System.Drawing.Size(551, 167);
            this.panelSystemInfo.TabIndex = 7;
            // 
            // lbDiskDriveInfo
            // 
            this.lbDiskDriveInfo.AutoSize = true;
            this.lbDiskDriveInfo.Location = new System.Drawing.Point(187, 140);
            this.lbDiskDriveInfo.Name = "lbDiskDriveInfo";
            this.lbDiskDriveInfo.Size = new System.Drawing.Size(32, 13);
            this.lbDiskDriveInfo.TabIndex = 13;
            this.lbDiskDriveInfo.Text = "ROM";
            // 
            // lbRamInfo
            // 
            this.lbRamInfo.AutoSize = true;
            this.lbRamInfo.Location = new System.Drawing.Point(187, 115);
            this.lbRamInfo.Name = "lbRamInfo";
            this.lbRamInfo.Size = new System.Drawing.Size(28, 13);
            this.lbRamInfo.TabIndex = 12;
            this.lbRamInfo.Text = "Disk";
            // 
            // lbGpuInfo
            // 
            this.lbGpuInfo.AutoSize = true;
            this.lbGpuInfo.Location = new System.Drawing.Point(187, 90);
            this.lbGpuInfo.Name = "lbGpuInfo";
            this.lbGpuInfo.Size = new System.Drawing.Size(30, 13);
            this.lbGpuInfo.TabIndex = 11;
            this.lbGpuInfo.Text = "GPU";
            // 
            // lbMotherboardInfo
            // 
            this.lbMotherboardInfo.AutoSize = true;
            this.lbMotherboardInfo.Location = new System.Drawing.Point(187, 65);
            this.lbMotherboardInfo.Name = "lbMotherboardInfo";
            this.lbMotherboardInfo.Size = new System.Drawing.Size(23, 13);
            this.lbMotherboardInfo.TabIndex = 10;
            this.lbMotherboardInfo.Text = "MB";
            // 
            // lbCpuInfo
            // 
            this.lbCpuInfo.AutoSize = true;
            this.lbCpuInfo.Location = new System.Drawing.Point(187, 40);
            this.lbCpuInfo.Name = "lbCpuInfo";
            this.lbCpuInfo.Size = new System.Drawing.Size(29, 13);
            this.lbCpuInfo.TabIndex = 9;
            this.lbCpuInfo.Text = "CPU";
            // 
            // lbOSInfo
            // 
            this.lbOSInfo.AutoSize = true;
            this.lbOSInfo.Location = new System.Drawing.Point(187, 15);
            this.lbOSInfo.Name = "lbOSInfo";
            this.lbOSInfo.Size = new System.Drawing.Size(22, 13);
            this.lbOSInfo.TabIndex = 8;
            this.lbOSInfo.Text = "OS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Хранилище данных";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Оперативная память";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Графическое устройство";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Системная плата";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Процессор";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Операционная система";
            // 
            // timerUpdateInfo
            // 
            this.timerUpdateInfo.Tick += new System.EventHandler(this.timerUpdateInfo_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.panelSystemInfo);
            this.Controls.Add(this.panelSystemState);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовой проект";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panelSystemState.ResumeLayout(false);
            this.panelSystemState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDiskLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCpuTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDiskTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxRamLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPagingFileLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCpuLoad)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSystemInfo.ResumeLayout(false);
            this.panelSystemInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelSystemState;
        private System.Windows.Forms.Label lbCPULoad;
        private System.Windows.Forms.Label lbRAMLoad;
        private System.Windows.Forms.Label lbCPUTemperature;
        private System.Windows.Forms.Label lbPagingFileLoad;
        private System.Windows.Forms.Label lbDiskTemperature;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Panel panelSystemInfo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbDiskDriveInfo;
        private System.Windows.Forms.Label lbRamInfo;
        private System.Windows.Forms.Label lbGpuInfo;
        private System.Windows.Forms.Label lbMotherboardInfo;
        private System.Windows.Forms.Label lbCpuInfo;
        private System.Windows.Forms.Label lbOSInfo;
        private System.Windows.Forms.ToolStripMenuItem menuOpenLog;
        private System.Windows.Forms.ToolStripMenuItem menuAutoSaveLogs;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.Timer timerUpdateInfo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numMaxCpuTemperature;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numMaxDiskTemperature;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numMaxRamLoad;
        private System.Windows.Forms.NumericUpDown numMaxPagingFileLoad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numMaxCpuLoad;
        private System.Windows.Forms.NumericUpDown numMaxDiskLoad;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbDiskLoad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label25;
    }
}

