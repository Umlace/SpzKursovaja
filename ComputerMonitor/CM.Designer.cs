namespace ComputerMonitor
{
    partial class CM
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
            this.interval = new System.Windows.Forms.Timer(this.components);
            this.cpu01 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.Label();
            this.c2 = new System.Windows.Forms.Label();
            this.c3 = new System.Windows.Forms.Label();
            this.c4 = new System.Windows.Forms.Label();
            this.gpuTemp = new System.Windows.Forms.Label();
            this.cpuPanel = new System.Windows.Forms.GroupBox();
            this.gpuLoadBar = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.gpuLoadPer = new System.Windows.Forms.Label();
            this.gpuTempBar = new System.Windows.Forms.ProgressBar();
            this.gpuPanel = new System.Windows.Forms.GroupBox();
            this.cpuLoad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CpuLoadBar = new System.Windows.Forms.ProgressBar();
            this.coreBar04 = new System.Windows.Forms.ProgressBar();
            this.coreBar03 = new System.Windows.Forms.ProgressBar();
            this.coreBar02 = new System.Windows.Forms.ProgressBar();
            this.coreBar01 = new System.Windows.Forms.ProgressBar();
            this.cpuBar = new System.Windows.Forms.ProgressBar();
            this.coreAve = new System.Windows.Forms.Label();
            this.discPanel = new System.Windows.Forms.GroupBox();
            this.DiskBar04 = new System.Windows.Forms.ProgressBar();
            this.LDisk04 = new System.Windows.Forms.Label();
            this.DiskSize04 = new System.Windows.Forms.Label();
            this.DiskBar03 = new System.Windows.Forms.ProgressBar();
            this.LDisk03 = new System.Windows.Forms.Label();
            this.DiskSize03 = new System.Windows.Forms.Label();
            this.DiskBar02 = new System.Windows.Forms.ProgressBar();
            this.LDisk02 = new System.Windows.Forms.Label();
            this.DiskSize02 = new System.Windows.Forms.Label();
            this.DiskBar01 = new System.Windows.Forms.ProgressBar();
            this.LDisk01 = new System.Windows.Forms.Label();
            this.DiskSize01 = new System.Windows.Forms.Label();
            this.ramPanel = new System.Windows.Forms.GroupBox();
            this.ramPerc = new System.Windows.Forms.ProgressBar();
            this.label19 = new System.Windows.Forms.Label();
            this.RamByte = new System.Windows.Forms.Label();
            this.cpuPanel.SuspendLayout();
            this.gpuPanel.SuspendLayout();
            this.discPanel.SuspendLayout();
            this.ramPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // interval
            // 
            this.interval.Enabled = true;
            this.interval.Interval = 1000;
            this.interval.Tick += new System.EventHandler(this.interval_Tick);
            // 
            // cpu01
            // 
            this.cpu01.AutoSize = true;
            this.cpu01.Location = new System.Drawing.Point(9, 89);
            this.cpu01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpu01.Name = "cpu01";
            this.cpu01.Size = new System.Drawing.Size(112, 29);
            this.cpu01.TabIndex = 2;
            this.cpu01.Text = "Core 01:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Core 02:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Core 03:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Core 04:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "GPU Core:";
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Location = new System.Drawing.Point(150, 89);
            this.c1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(73, 29);
            this.c1.TabIndex = 8;
            this.c1.Text = "00 .C";
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.Location = new System.Drawing.Point(150, 134);
            this.c2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(73, 29);
            this.c2.TabIndex = 9;
            this.c2.Text = "00 .C";
            // 
            // c3
            // 
            this.c3.AutoSize = true;
            this.c3.Location = new System.Drawing.Point(150, 178);
            this.c3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(73, 29);
            this.c3.TabIndex = 10;
            this.c3.Text = "00 .C";
            // 
            // c4
            // 
            this.c4.AutoSize = true;
            this.c4.Location = new System.Drawing.Point(150, 225);
            this.c4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(73, 29);
            this.c4.TabIndex = 11;
            this.c4.Text = "00 .C";
            // 
            // gpuTemp
            // 
            this.gpuTemp.AutoSize = true;
            this.gpuTemp.Location = new System.Drawing.Point(166, 62);
            this.gpuTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gpuTemp.Name = "gpuTemp";
            this.gpuTemp.Size = new System.Drawing.Size(73, 29);
            this.gpuTemp.TabIndex = 13;
            this.gpuTemp.Text = "00 .C";
            // 
            // cpuPanel
            // 
            this.cpuPanel.Controls.Add(this.gpuLoadBar);
            this.cpuPanel.Controls.Add(this.label7);
            this.cpuPanel.Controls.Add(this.gpuLoadPer);
            this.cpuPanel.Controls.Add(this.gpuTempBar);
            this.cpuPanel.Controls.Add(this.label5);
            this.cpuPanel.Controls.Add(this.gpuTemp);
            this.cpuPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuPanel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cpuPanel.Location = new System.Drawing.Point(18, 362);
            this.cpuPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpuPanel.Name = "cpuPanel";
            this.cpuPanel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpuPanel.Size = new System.Drawing.Size(686, 165);
            this.cpuPanel.TabIndex = 14;
            this.cpuPanel.TabStop = false;
            this.cpuPanel.Text = "Information";
            // 
            // gpuLoadBar
            // 
            this.gpuLoadBar.Location = new System.Drawing.Point(264, 100);
            this.gpuLoadBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpuLoadBar.Name = "gpuLoadBar";
            this.gpuLoadBar.Size = new System.Drawing.Size(412, 35);
            this.gpuLoadBar.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "GPU Load:";
            // 
            // gpuLoadPer
            // 
            this.gpuLoadPer.AutoSize = true;
            this.gpuLoadPer.Location = new System.Drawing.Point(166, 106);
            this.gpuLoadPer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gpuLoadPer.Name = "gpuLoadPer";
            this.gpuLoadPer.Size = new System.Drawing.Size(78, 29);
            this.gpuLoadPer.TabIndex = 27;
            this.gpuLoadPer.Text = "00 .%";
            // 
            // gpuTempBar
            // 
            this.gpuTempBar.Location = new System.Drawing.Point(264, 55);
            this.gpuTempBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpuTempBar.Name = "gpuTempBar";
            this.gpuTempBar.Size = new System.Drawing.Size(412, 35);
            this.gpuTempBar.TabIndex = 25;
            // 
            // gpuPanel
            // 
            this.gpuPanel.Controls.Add(this.cpuLoad);
            this.gpuPanel.Controls.Add(this.label4);
            this.gpuPanel.Controls.Add(this.label6);
            this.gpuPanel.Controls.Add(this.CpuLoadBar);
            this.gpuPanel.Controls.Add(this.coreBar04);
            this.gpuPanel.Controls.Add(this.coreBar03);
            this.gpuPanel.Controls.Add(this.coreBar02);
            this.gpuPanel.Controls.Add(this.coreBar01);
            this.gpuPanel.Controls.Add(this.cpuBar);
            this.gpuPanel.Controls.Add(this.coreAve);
            this.gpuPanel.Controls.Add(this.cpu01);
            this.gpuPanel.Controls.Add(this.label1);
            this.gpuPanel.Controls.Add(this.c1);
            this.gpuPanel.Controls.Add(this.label2);
            this.gpuPanel.Controls.Add(this.c2);
            this.gpuPanel.Controls.Add(this.c4);
            this.gpuPanel.Controls.Add(this.c3);
            this.gpuPanel.Controls.Add(this.label3);
            this.gpuPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuPanel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gpuPanel.Location = new System.Drawing.Point(18, 18);
            this.gpuPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpuPanel.Name = "gpuPanel";
            this.gpuPanel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpuPanel.Size = new System.Drawing.Size(686, 334);
            this.gpuPanel.TabIndex = 15;
            this.gpuPanel.TabStop = false;
            this.gpuPanel.Text = "Information";
            // 
            // cpuLoad
            // 
            this.cpuLoad.AutoSize = true;
            this.cpuLoad.Location = new System.Drawing.Point(150, 268);
            this.cpuLoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpuLoad.Name = "cpuLoad";
            this.cpuLoad.Size = new System.Drawing.Size(71, 29);
            this.cpuLoad.TabIndex = 16;
            this.cpuLoad.Text = "00 %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Load:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "CPU:";
            // 
            // CpuLoadBar
            // 
            this.CpuLoadBar.Location = new System.Drawing.Point(248, 268);
            this.CpuLoadBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CpuLoadBar.Name = "CpuLoadBar";
            this.CpuLoadBar.Size = new System.Drawing.Size(429, 35);
            this.CpuLoadBar.TabIndex = 24;
            // 
            // coreBar04
            // 
            this.coreBar04.Location = new System.Drawing.Point(248, 223);
            this.coreBar04.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.coreBar04.Name = "coreBar04";
            this.coreBar04.Size = new System.Drawing.Size(429, 35);
            this.coreBar04.TabIndex = 23;
            // 
            // coreBar03
            // 
            this.coreBar03.Location = new System.Drawing.Point(248, 178);
            this.coreBar03.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.coreBar03.Name = "coreBar03";
            this.coreBar03.Size = new System.Drawing.Size(429, 35);
            this.coreBar03.TabIndex = 22;
            // 
            // coreBar02
            // 
            this.coreBar02.Location = new System.Drawing.Point(248, 134);
            this.coreBar02.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.coreBar02.Name = "coreBar02";
            this.coreBar02.Size = new System.Drawing.Size(429, 35);
            this.coreBar02.TabIndex = 21;
            // 
            // coreBar01
            // 
            this.coreBar01.Location = new System.Drawing.Point(248, 89);
            this.coreBar01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.coreBar01.Name = "coreBar01";
            this.coreBar01.Size = new System.Drawing.Size(429, 35);
            this.coreBar01.TabIndex = 20;
            // 
            // cpuBar
            // 
            this.cpuBar.Location = new System.Drawing.Point(248, 45);
            this.cpuBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpuBar.Name = "cpuBar";
            this.cpuBar.Size = new System.Drawing.Size(429, 35);
            this.cpuBar.TabIndex = 19;
            // 
            // coreAve
            // 
            this.coreAve.AutoSize = true;
            this.coreAve.Location = new System.Drawing.Point(150, 45);
            this.coreAve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coreAve.Name = "coreAve";
            this.coreAve.Size = new System.Drawing.Size(73, 29);
            this.coreAve.TabIndex = 17;
            this.coreAve.Text = "00 .C";
            // 
            // discPanel
            // 
            this.discPanel.Controls.Add(this.DiskBar04);
            this.discPanel.Controls.Add(this.LDisk04);
            this.discPanel.Controls.Add(this.DiskSize04);
            this.discPanel.Controls.Add(this.DiskBar03);
            this.discPanel.Controls.Add(this.LDisk03);
            this.discPanel.Controls.Add(this.DiskSize03);
            this.discPanel.Controls.Add(this.DiskBar02);
            this.discPanel.Controls.Add(this.LDisk02);
            this.discPanel.Controls.Add(this.DiskSize02);
            this.discPanel.Controls.Add(this.DiskBar01);
            this.discPanel.Controls.Add(this.LDisk01);
            this.discPanel.Controls.Add(this.DiskSize01);
            this.discPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discPanel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.discPanel.Location = new System.Drawing.Point(18, 665);
            this.discPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discPanel.Name = "discPanel";
            this.discPanel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discPanel.Size = new System.Drawing.Size(686, 377);
            this.discPanel.TabIndex = 16;
            this.discPanel.TabStop = false;
            this.discPanel.Text = "Disk Information";
            // 
            // DiskBar04
            // 
            this.DiskBar04.Location = new System.Drawing.Point(15, 315);
            this.DiskBar04.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiskBar04.Name = "DiskBar04";
            this.DiskBar04.Size = new System.Drawing.Size(662, 35);
            this.DiskBar04.TabIndex = 34;
            // 
            // LDisk04
            // 
            this.LDisk04.AutoSize = true;
            this.LDisk04.Location = new System.Drawing.Point(9, 282);
            this.LDisk04.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDisk04.Name = "LDisk04";
            this.LDisk04.Size = new System.Drawing.Size(46, 29);
            this.LDisk04.TabIndex = 32;
            this.LDisk04.Text = "D:\\";
            // 
            // DiskSize04
            // 
            this.DiskSize04.AutoSize = true;
            this.DiskSize04.Location = new System.Drawing.Point(76, 282);
            this.DiskSize04.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiskSize04.Name = "DiskSize04";
            this.DiskSize04.Size = new System.Drawing.Size(78, 29);
            this.DiskSize04.TabIndex = 33;
            this.DiskSize04.Text = "00 .%";
            // 
            // DiskBar03
            // 
            this.DiskBar03.Location = new System.Drawing.Point(15, 242);
            this.DiskBar03.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiskBar03.Name = "DiskBar03";
            this.DiskBar03.Size = new System.Drawing.Size(662, 35);
            this.DiskBar03.TabIndex = 31;
            // 
            // LDisk03
            // 
            this.LDisk03.AutoSize = true;
            this.LDisk03.Location = new System.Drawing.Point(9, 208);
            this.LDisk03.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDisk03.Name = "LDisk03";
            this.LDisk03.Size = new System.Drawing.Size(46, 29);
            this.LDisk03.TabIndex = 29;
            this.LDisk03.Text = "C:\\";
            // 
            // DiskSize03
            // 
            this.DiskSize03.AutoSize = true;
            this.DiskSize03.Location = new System.Drawing.Point(76, 208);
            this.DiskSize03.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiskSize03.Name = "DiskSize03";
            this.DiskSize03.Size = new System.Drawing.Size(78, 29);
            this.DiskSize03.TabIndex = 30;
            this.DiskSize03.Text = "00 .%";
            // 
            // DiskBar02
            // 
            this.DiskBar02.Location = new System.Drawing.Point(15, 168);
            this.DiskBar02.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiskBar02.Name = "DiskBar02";
            this.DiskBar02.Size = new System.Drawing.Size(662, 35);
            this.DiskBar02.TabIndex = 28;
            // 
            // LDisk02
            // 
            this.LDisk02.AutoSize = true;
            this.LDisk02.Location = new System.Drawing.Point(9, 134);
            this.LDisk02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDisk02.Name = "LDisk02";
            this.LDisk02.Size = new System.Drawing.Size(45, 29);
            this.LDisk02.TabIndex = 26;
            this.LDisk02.Text = "B:\\";
            // 
            // DiskSize02
            // 
            this.DiskSize02.AutoSize = true;
            this.DiskSize02.Location = new System.Drawing.Point(76, 134);
            this.DiskSize02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiskSize02.Name = "DiskSize02";
            this.DiskSize02.Size = new System.Drawing.Size(78, 29);
            this.DiskSize02.TabIndex = 27;
            this.DiskSize02.Text = "00 .%";
            // 
            // DiskBar01
            // 
            this.DiskBar01.Location = new System.Drawing.Point(15, 94);
            this.DiskBar01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiskBar01.Name = "DiskBar01";
            this.DiskBar01.Size = new System.Drawing.Size(662, 35);
            this.DiskBar01.TabIndex = 25;
            // 
            // LDisk01
            // 
            this.LDisk01.AutoSize = true;
            this.LDisk01.Location = new System.Drawing.Point(9, 60);
            this.LDisk01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDisk01.Name = "LDisk01";
            this.LDisk01.Size = new System.Drawing.Size(44, 29);
            this.LDisk01.TabIndex = 7;
            this.LDisk01.Text = "A:\\";
            // 
            // DiskSize01
            // 
            this.DiskSize01.AutoSize = true;
            this.DiskSize01.Location = new System.Drawing.Point(76, 60);
            this.DiskSize01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiskSize01.Name = "DiskSize01";
            this.DiskSize01.Size = new System.Drawing.Size(78, 29);
            this.DiskSize01.TabIndex = 13;
            this.DiskSize01.Text = "00 .%";
            // 
            // ramPanel
            // 
            this.ramPanel.Controls.Add(this.ramPerc);
            this.ramPanel.Controls.Add(this.label19);
            this.ramPanel.Controls.Add(this.RamByte);
            this.ramPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramPanel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.ramPanel.Location = new System.Drawing.Point(18, 535);
            this.ramPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ramPanel.Name = "ramPanel";
            this.ramPanel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ramPanel.Size = new System.Drawing.Size(686, 120);
            this.ramPanel.TabIndex = 17;
            this.ramPanel.TabStop = false;
            this.ramPanel.Text = "Information";
            // 
            // ramPerc
            // 
            this.ramPerc.Location = new System.Drawing.Point(264, 55);
            this.ramPerc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ramPerc.Name = "ramPerc";
            this.ramPerc.Size = new System.Drawing.Size(412, 35);
            this.ramPerc.TabIndex = 25;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 62);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 29);
            this.label19.TabIndex = 7;
            this.label19.Text = "RAM:";
            // 
            // RamByte
            // 
            this.RamByte.AutoSize = true;
            this.RamByte.Location = new System.Drawing.Point(92, 62);
            this.RamByte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RamByte.Name = "RamByte";
            this.RamByte.Size = new System.Drawing.Size(78, 29);
            this.RamByte.TabIndex = 13;
            this.RamByte.Text = "00 .%";
            // 
            // CM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(722, 1074);
            this.Controls.Add(this.ramPanel);
            this.Controls.Add(this.discPanel);
            this.Controls.Add(this.gpuPanel);
            this.Controls.Add(this.cpuPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CM";
            this.Text = "Sysem Monitor";
            this.Load += new System.EventHandler(this.CM_Load);
            this.cpuPanel.ResumeLayout(false);
            this.cpuPanel.PerformLayout();
            this.gpuPanel.ResumeLayout(false);
            this.gpuPanel.PerformLayout();
            this.discPanel.ResumeLayout(false);
            this.discPanel.PerformLayout();
            this.ramPanel.ResumeLayout(false);
            this.ramPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer interval;
        private System.Windows.Forms.Label cpu01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label c1;
        private System.Windows.Forms.Label c2;
        private System.Windows.Forms.Label c3;
        private System.Windows.Forms.Label c4;
        private System.Windows.Forms.Label gpuTemp;
        private System.Windows.Forms.GroupBox cpuPanel;
        private System.Windows.Forms.GroupBox gpuPanel;
        private System.Windows.Forms.Label coreAve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cpuLoad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar CpuLoadBar;
        private System.Windows.Forms.ProgressBar coreBar04;
        private System.Windows.Forms.ProgressBar coreBar03;
        private System.Windows.Forms.ProgressBar coreBar02;
        private System.Windows.Forms.ProgressBar coreBar01;
        private System.Windows.Forms.ProgressBar cpuBar;
        private System.Windows.Forms.ProgressBar gpuTempBar;
        private System.Windows.Forms.ProgressBar gpuLoadBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label gpuLoadPer;
        private System.Windows.Forms.GroupBox discPanel;
        private System.Windows.Forms.ProgressBar DiskBar04;
        private System.Windows.Forms.Label LDisk04;
        private System.Windows.Forms.Label DiskSize04;
        private System.Windows.Forms.ProgressBar DiskBar03;
        private System.Windows.Forms.Label LDisk03;
        private System.Windows.Forms.Label DiskSize03;
        private System.Windows.Forms.ProgressBar DiskBar02;
        private System.Windows.Forms.Label LDisk02;
        private System.Windows.Forms.Label DiskSize02;
        private System.Windows.Forms.ProgressBar DiskBar01;
        private System.Windows.Forms.Label LDisk01;
        private System.Windows.Forms.Label DiskSize01;
        private System.Windows.Forms.GroupBox ramPanel;
        private System.Windows.Forms.ProgressBar ramPerc;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label RamByte;
    }
}

