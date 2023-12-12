using OpenHardwareMonitor.Hardware;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;
using System.Linq;

namespace ComputerMonitor
{
    public partial class CM : Form
    {
        private Computer computer = new Computer() { CPUEnabled = true, GPUEnabled = true, RAMEnabled = true };

        private PerformanceCounter perfCpuCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        private PerformanceCounter perfMemCounter = new PerformanceCounter("Memory", "Available MBytes");
        
        private string path = @"c:\NVSMI";
        private string SourcePath = @"C:\Program Files\NVIDIA Corporation\NVSMI\";
        private string DestinationPath = @"c:\NVSMI";

        private Char delimiter = '-';
        private Char delimiter2 = 'W';
        private int GPUCount = 0;
        private string output;

        private DriveInfo[] allDrives = DriveInfo.GetDrives();

        private string buffer;
        private string buffer2  ;

        private int counter = 0;
        private int counter2 = 0;
        private int counter3 = 0;

        private int cpu1;
        private int cpu2;
        private int cpu3;
        private int cpu4;
        private int cpuTotal;
        private int _cpuLoad;

        private double _Disk01;
        private double _Disk02;
        private double _Disk03;
        private double _Disk04;
        private int byteConvert = 1073741824;

        private double tRam;
        private double tRamTotal = 32000;
        private double tRamBar;

        private int _gpuTemp;
        private int _gpuLoad;

        public CM()
        {
            InitializeComponent();
            computer.Open();
        }
        private void interval_Tick(object sender, EventArgs e)
        {
            cpu_gpu_temp();

            systemInfo();

            diskSize();

            gpuInfo();
                        
            progress();
        }
        private void cpu_gpu_temp()
        {
            try
            {
                counter = 0;
                counter2 = 0;

                foreach (IHardware hardware in computer.Hardware)
                {
                    hardware.Update();

                    if (counter2 == 0)
                    {
                        gpuPanel.Text = hardware.Name.ToString();
                    }
                    if (counter2 == 2)
                    {
                        cpuPanel.Text = hardware.Name.ToString();
                    }
                    if (counter2 == 1)
                    {
                        ramPanel.Text = hardware.Name.ToString();
                    }
                    if (counter2 == 3)
                    {
                        discPanel.Text = hardware.Name.ToString();
                    }

                    counter2++;

                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            if (counter == 0)
                            {
                                c1.Text = sensor.Value.ToString() + " .C";
                                cpu1 = (int)sensor.Value;
                            }
                            if (counter == 1)
                            {
                                c2.Text = sensor.Value.ToString() + " .C";
                                cpu2 = (int)sensor.Value;
                            }
                            if (counter == 2)
                            {
                                c3.Text = sensor.Value.ToString() + " .C";
                                cpu3 = (int)sensor.Value;
                            }
                            if (counter == 3)
                            {
                                c4.Text = sensor.Value.ToString() + " .C";
                                cpu4 = (int)sensor.Value;
                            }
                            if (counter == 4)
                            {
                                buffer = sensor.Value.ToString();
                            }
                            if (counter == 5)
                            {
                                gpuTemp.Text = sensor.Value.ToString() + " .C";
                                _gpuTemp = (int)sensor.Value;
                            }
                            counter++;
                        }
                        cpuTotal = (cpu1 + cpu2 + cpu3 + cpu4) / 4;

                        coreAve.Text = cpuTotal.ToString() + " .C";
                    }
                }
            }
            catch
            {
                interval.Stop();
                MessageBox.Show("Note that, System Monitor requires 'highestAvailable' permission.", "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void systemInfo()
        {
            _cpuLoad = (int)perfCpuCounter.NextValue();

            tRam = (int)perfMemCounter.NextValue();

            tRamBar = tRam / tRamTotal;

            tRamBar = tRamBar * 100;

            tRamBar = 100 - tRamBar;

            RamByte.Text = tRam + " MB";

            cpuLoad.Text = _cpuLoad + " %";
        }
        private void progress()
        {
            cpuBar.Minimum = 0;
            cpuBar.Maximum = 100;

            if (cpuTotal < cpuBar.Maximum)
            {
                if (cpuTotal < 49)
                {
                    cpuBar.ForeColor = Color.Green;
                }

                if (cpuTotal > 50)
                {
                    cpuBar.ForeColor = Color.Orange;
                }

                if (cpuTotal > 75)
                {
                    cpuBar.ForeColor = Color.Red;
                }
                cpuBar.Value = cpuTotal;
            }

            coreBar01.Minimum = 0;
            coreBar01.Maximum = 100;

            if (cpu1 < coreBar01.Maximum)
            {
                if (cpu1 < 49)
                {
                    coreBar01.ForeColor = Color.Green;
                }
                if (cpu1 > 50)
                {
                    coreBar01.ForeColor = Color.Orange;
                }

                if (cpu1 > 75)
                {
                    coreBar01.ForeColor = Color.Red;
                }
                coreBar01.Value = cpu1;
            }

            coreBar02.Minimum = 0;
            coreBar02.Maximum = 100;

            if (cpu2 < coreBar02.Maximum)
            {
                if (cpu2 < 49)
                {
                    coreBar02.ForeColor = Color.Green;
                }
                if (cpu2 > 50)
                {
                    coreBar02.ForeColor = Color.Orange;
                }

                if (cpu2 > 75)
                {
                    coreBar02.ForeColor = Color.Red;
                }
                coreBar02.Value = cpu2;
            }

            coreBar03.Minimum = 0;
            coreBar03.Maximum = 100;

            if (cpu3 < coreBar03.Maximum)
            {
                if (cpu3 < 49)
                {
                    coreBar03.ForeColor = Color.Green;
                }
                if (cpu3 > 50)
                {
                    coreBar03.ForeColor = Color.Orange;
                }

                if (cpu3 > 75)
                {
                    coreBar03.ForeColor = Color.Red;
                }
                coreBar03.Value = cpu3;
            }

            coreBar04.Minimum = 0;
            coreBar04.Maximum = 100;

            if (cpu4 < coreBar04.Maximum)
            {
                if (cpu4 < 49)
                {
                    coreBar04.ForeColor = Color.Green;
                }
                if (cpu4 > 50)
                {
                    coreBar04.ForeColor = Color.Orange;
                }

                if (cpu4 > 75)
                {
                    coreBar04.ForeColor = Color.Red;
                }
                coreBar04.Value = cpu4;
            }

            CpuLoadBar.Minimum = 0;
            CpuLoadBar.Maximum = 100;

            if (_cpuLoad < CpuLoadBar.Maximum)
            {
                if (_cpuLoad < 49)
                {
                    CpuLoadBar.ForeColor = Color.Green;
                }
                if (_cpuLoad > 50)
                {
                    CpuLoadBar.ForeColor = Color.Orange;
                }

                if (_cpuLoad > 75)
                {
                    CpuLoadBar.ForeColor = Color.Red;
                }
                CpuLoadBar.Value = _cpuLoad;
            }

            gpuTempBar.Minimum = 0;
            gpuTempBar.Maximum = 100;

            if (_gpuTemp < gpuTempBar.Maximum)
            {
                if (_gpuTemp < 49)
                {
                    gpuTempBar.ForeColor = Color.Green;
                }
                if (_gpuTemp > 50)
                {
                    gpuTempBar.ForeColor = Color.Orange;
                }

                if (_gpuTemp > 75)
                {
                    gpuTempBar.ForeColor = Color.Red;
                }
                gpuTempBar.Value = _gpuTemp;
            }
            DiskBar01.Minimum = 0;
            DiskBar01.Maximum = 100;

            if (_Disk01 < DiskBar01.Maximum)
            {
                if (_Disk01 < 49)
                {
                    DiskBar01.ForeColor = Color.Green;
                }
                if (_Disk01 > 50)
                {
                    DiskBar01.ForeColor = Color.Orange;
                }

                if (_Disk01 > 75)
                {
                    DiskBar01.ForeColor = Color.Red;
                }
                DiskBar01.Value = (int)_Disk01;
            }
            DiskBar02.Minimum = 0;
            DiskBar02.Maximum = 100;

            if (_Disk02 < DiskBar02.Maximum)
            {
                if (_Disk02 < 49)
                {
                    DiskBar02.ForeColor = Color.Green;
                }
                if (_Disk02 > 50)
                {
                    DiskBar02.ForeColor = Color.Orange;
                }

                if (_Disk02 > 75)
                {
                    DiskBar02.ForeColor = Color.Red;
                }

                DiskBar02.Value = (int)_Disk02;
            }
            DiskBar03.Minimum = 0;
            DiskBar03.Maximum = 100;

            if (_Disk03 < DiskBar03.Maximum)
            {
                if (_Disk03 < 49)
                {
                    DiskBar03.ForeColor = Color.Green;
                }
                if (_Disk03 > 50)
                {
                    DiskBar03.ForeColor = Color.Orange;
                }

                if (_Disk03 > 75)
                {
                    DiskBar03.ForeColor = Color.Red;
                }

                DiskBar03.Value = (int)_Disk03;
            }
            DiskBar01.Minimum = 0;
            DiskBar01.Maximum = 100;

            if (_Disk04 < DiskBar01.Maximum)
            {
                if (_Disk04 < 49)
                {
                    DiskBar04.ForeColor = Color.Green;
                }
                if (_Disk04 > 50)
                {
                    DiskBar04.ForeColor = Color.Orange;
                }

                if (_Disk04 > 75)
                {
                    DiskBar04.ForeColor = Color.Red;
                }

                DiskBar04.Value = (int)_Disk04;
            }
            ramPerc.Minimum = 0;
            ramPerc.Maximum = 100;

            if (tRamBar < ramPerc.Maximum)
            {
                if (tRamBar < 49)
                {
                    ramPerc.ForeColor = Color.Green;
                }
                if (tRamBar > 50)
                {
                    ramPerc.ForeColor = Color.Orange;
                }

                if (tRamBar > 75)
                {
                    ramPerc.ForeColor = Color.Red;
                }
                ramPerc.Value = (int)tRamBar;
            }

            gpuLoadBar.Minimum = 0;
            gpuLoadBar.Maximum = 100;

            if (_gpuLoad < gpuLoadBar.Maximum)
            {
                if (_gpuLoad < 49)
                {
                    gpuLoadBar.ForeColor = Color.Green;
                }
                if (_gpuLoad > 50)
                {
                    gpuLoadBar.ForeColor = Color.Orange;
                }

                if (_gpuLoad > 75)
                {
                    gpuLoadBar.ForeColor = Color.Red;
                }

                gpuLoadBar.Value = (int)_gpuLoad;
            }
        }

        private void diskSize()
        {
            counter3 = 0;
            foreach (DriveInfo d in allDrives)
            {
                if (counter3 == 0)
                {
                    LDisk01.Text = d.Name;
                }
                if (counter3 == 1)
                {
                    LDisk02.Text = d.Name;
                }
                if (counter3 == 2)
                {
                    LDisk03.Text = d.Name;
                }
                if (counter3 == 3)
                {
                    LDisk04.Text = d.Name;
                }
                if (d.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                    Console.WriteLine("  File system: {0}", d.DriveFormat);
                    Console.WriteLine(
                        "  Available space to current user:{0, 15} bytes",
                        d.AvailableFreeSpace);

                    Console.WriteLine(
                        "  Total available space:          {0, 15} bytes",
                        d.TotalFreeSpace);

                    Console.WriteLine(
                        "  Total size of drive:            {0, 15} bytes ",
                        d.TotalSize);

                    if (counter3 == 0)
                    {
                        DiskSize01.Text = Convert.ToString((d.AvailableFreeSpace / byteConvert)) + " GB Free of " + Convert.ToString((d.TotalSize / byteConvert)) + " GB";
                        _Disk01 = (d.AvailableFreeSpace / byteConvert);
                        _Disk01 = _Disk01 / (d.TotalSize / byteConvert);
                        _Disk01 = _Disk01 * 100;
                        _Disk01 = 100 - _Disk01;
                    }
                    if (counter3 == 1)
                    {
                        DiskSize02.Text = Convert.ToString((d.AvailableFreeSpace / byteConvert)) + " GB Free of " + Convert.ToString((d.TotalSize / byteConvert)) + " GB";
                        _Disk02 = (d.AvailableFreeSpace / byteConvert);
                        _Disk02 = _Disk02 / (d.TotalSize / byteConvert);
                        _Disk02 = _Disk02 * 100;
                        _Disk02 = 100 - _Disk02;
                    }
                    if (counter3 == 2)
                    {
                        DiskSize03.Text = Convert.ToString((d.AvailableFreeSpace / byteConvert)) + " GB Free of " + Convert.ToString((d.TotalSize / byteConvert)) + " GB";
                        _Disk03 = (d.AvailableFreeSpace / byteConvert);
                        _Disk03 = _Disk03 / (d.TotalSize / byteConvert);
                        _Disk03 = _Disk03 * 100;
                        _Disk03 = 100 - _Disk03;
                    }
                    if (counter3 == 3)
                    {
                        DiskSize04.Text = Convert.ToString((d.AvailableFreeSpace / byteConvert)) + " GB Free of " + Convert.ToString((d.TotalSize / byteConvert)) + " GB";
                        _Disk04 = (d.AvailableFreeSpace / byteConvert);
                        _Disk04 = _Disk04 / (d.TotalSize / byteConvert);
                        _Disk04 = _Disk04 * 100;
                        _Disk04 = 100 - _Disk04;
                    }
                }
                counter3++;
            }
        }
          
        private void gpuInfo()
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));
                    NVIDIAGPU();
                }
            }
            catch { MessageBox.Show("Unable to access NVIDIA files"); return; }

            try
            {
                GPUCount = 0;

                ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", @"/C cd c:\NVSMI&nvidia-smi --query-gpu=utilization.memory --format=csv");
                processStartInfo.UseShellExecute = false;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.CreateNoWindow = true;
                               
                Process process = Process.Start(processStartInfo);
                using (StreamReader streamReader = process.StandardOutput)
                {
                    output = streamReader.ReadToEnd();
                }

                String[] substrings = output.Split(delimiter2);
                foreach (var substring in substrings)
                {
                    if (GPUCount == 0)
                    {
                        gpuLoadPer.Text = String.Join("", substring.Where(Char.IsDigit)) + " %";

                        _gpuLoad = Convert.ToInt16(String.Join("", substring.Where(Char.IsDigit)));                                            
                    }
                    GPUCount++;
                }
            }
            catch
            {
                MessageBox.Show("Unable to access NVIDIA files"); return;
            }
        }

        private void NVIDIAGPU()
        {
            SourcePath = SourcePath.EndsWith(@"\") ? SourcePath : SourcePath + @"\";
            DestinationPath = DestinationPath.EndsWith(@"\") ? DestinationPath : DestinationPath + @"\";

            try
            {
                if (Directory.Exists(SourcePath))
                {
                    if (Directory.Exists(DestinationPath) == false)
                    {
                        Directory.CreateDirectory(DestinationPath);
                    }

                    foreach (string files in Directory.GetFiles(SourcePath))
                    {
                        FileInfo fileInfo = new FileInfo(files);
                        fileInfo.CopyTo(string.Format(@"{0}\{1}", DestinationPath, fileInfo.Name), true);
                    }
                }
            }
            catch (Exception )
            {
                MessageBox.Show("NVIDIA File Access Error") ;
                this.Close();
            }
        }

        private void CM_Load(object sender, EventArgs e)
        {

        }
    }
}