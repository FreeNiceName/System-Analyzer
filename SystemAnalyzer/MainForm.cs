using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace SystemAnalyzer
{
    public partial class MainForm : Form
    {
        private bool saveLogs = true;

        private const int nExceedsToWarning = 10;

        private int cpuLoadExceedCounter;
        private int cpuTemperatureExceedCounter;
        private int ramLoadExceedCounter;
        private int pagingFileLoadExceedCounter;
        private int diskLoadExceedCounter;
        private int diskTemperatureExceedCounter;

        private int maxCpuLoad;
        private int maxCpuTemperature;
        private int maxRamLoad;
        private int maxPagingFileLoad;
        private int maxDiskLoad;
        private int maxDiskTemperature;

        private SystemState state;

        public MainForm()
        {
            InitializeComponent();
            SystemInfoInit();
            MaxValuesInit();
            state = new SystemState();
            timerUpdateInfo.Interval = 1000;
            timerUpdateInfo.Start();
        }

        private void SystemInfoInit()
        {
            SystemInfo sysInfo = new SystemInfo();

            lbOSInfo.DataBindings.Add("Text", sysInfo, "OS");
            lbCpuInfo.DataBindings.Add("Text", sysInfo, "CPU");
            lbGpuInfo.DataBindings.Add("Text", sysInfo, "GPU");
            lbRamInfo.DataBindings.Add("Text", sysInfo, "RAM");
            lbDiskDriveInfo.DataBindings.Add("Text", sysInfo, "DiskDrive");
            lbMotherboardInfo.DataBindings.Add("Text", sysInfo, "MB");
        }

        private void MaxValuesInit()
        {
            maxCpuTemperature = Convert.ToInt32(numMaxCpuTemperature.Value);
            maxCpuLoad = Convert.ToInt32(numMaxCpuLoad.Value);
            maxRamLoad = Convert.ToInt32(numMaxRamLoad.Value);
            maxPagingFileLoad = Convert.ToInt32(numMaxPagingFileLoad.Value);
            maxDiskTemperature = Convert.ToInt32(numMaxDiskTemperature.Value);
            maxDiskLoad = Convert.ToInt32(numMaxDiskLoad.Value);
        }

        private void UpdateCpuLoad()
        {
            if (state.CpuLoad > maxCpuLoad)
            {
                if (cpuLoadExceedCounter > nExceedsToWarning)
                {
                    cpuLoadExceedCounter = 0;
                    MessageBox.Show("Загрузка процессора превышает допустимое значение", "Предупреждение", MessageBoxButtons.OK);
                }
                else
                    cpuLoadExceedCounter++;
            }
            else
                cpuLoadExceedCounter = 0;

            lbCPULoad.Text = state.CpuLoad + "%";
        }

        private void UpdateCpuTemperature()
        {
            if (state.CpuTemperature > maxCpuTemperature)
            {
                if (cpuTemperatureExceedCounter > nExceedsToWarning)
                {
                    cpuTemperatureExceedCounter = 0;
                    MessageBox.Show("Температура процессора превышает допустимое значение", "Предупреждение", MessageBoxButtons.OK);
                }
                else
                    cpuTemperatureExceedCounter++;
            }
            else
                cpuTemperatureExceedCounter = 0;

            lbCPUTemperature.Text = state.CpuTemperature + "°C";
        }

        private void UpdateRamLoad()
        {
            if (state.RamLoad > maxRamLoad)
            {
                if (ramLoadExceedCounter > nExceedsToWarning)
                {
                    ramLoadExceedCounter = 0;
                    MessageBox.Show("Загрузка оперативной памяти превышает допустимое значение", "Предупреждение", MessageBoxButtons.OK);
                }
                else
                    ramLoadExceedCounter++;
            }
            else
                ramLoadExceedCounter = 0;

            lbRAMLoad.Text = state.RamLoad + "%";
        }

        private void UpdatePagingFileLoad()
        {
            if (state.PagingFileLoad > maxPagingFileLoad)
            {
                if (pagingFileLoadExceedCounter > nExceedsToWarning)
                {
                    pagingFileLoadExceedCounter = 0;
                    MessageBox.Show("Загрузка файла подкачки превышает допустимое значение", "Предупреждение", MessageBoxButtons.OK);
                }
                else
                    pagingFileLoadExceedCounter++;
            }
            else
                pagingFileLoadExceedCounter = 0;

            lbPagingFileLoad.Text = state.PagingFileLoad + "%";
        }

        private void UpdateDiskLoad()
        {
            if (state.DiskLoad > maxDiskLoad)
            {
                if (diskLoadExceedCounter > nExceedsToWarning)
                {
                    diskLoadExceedCounter = 0;
                    MessageBox.Show("Загрузка дискового накопителя превышает допустимое значение", "Предупреждение", MessageBoxButtons.OK);
                }
                else
                    diskLoadExceedCounter++;
            }
            else
                diskLoadExceedCounter = 0;

            lbDiskLoad.Text = state.DiskLoad + "%";
        }

        private void UpdateDiskTemperature()
        {
            if (state.DiskTemperature > maxDiskTemperature)
            {
                if (diskTemperatureExceedCounter > nExceedsToWarning)
                {
                    diskTemperatureExceedCounter = 0;
                    MessageBox.Show("Температура дискового накопителя превышает допустимое значение", "Предупреждение", MessageBoxButtons.OK);
                }
                else
                    diskTemperatureExceedCounter++;
            }
            else
                diskTemperatureExceedCounter = 0;

            lbDiskTemperature.Text = state.DiskTemperature + "°C";
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerUpdateInfo.Stop();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerUpdateInfo_Tick(object sender, EventArgs e)
        {
            state.UpdateValues();
            
            UpdateCpuLoad();
            UpdateCpuTemperature();
            UpdateRamLoad();
            UpdatePagingFileLoad();
            UpdateDiskLoad();
            UpdateDiskTemperature();

            if(saveLogs)
                state.WriteInFile();
        }

        private void menuAutoSaveLogs_CheckedChanged(object sender, EventArgs e)
        {
            saveLogs = menuAutoSaveLogs.Checked;
        }

        private void menuOpenLog_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "log.txt");
        }

        private void numMaxCpuTemperature_ValueChanged(object sender, EventArgs e)
        {
            maxCpuTemperature = Convert.ToInt32(numMaxCpuTemperature.Value);
        }

        private void numMaxCpuLoad_ValueChanged(object sender, EventArgs e)
        {
            maxCpuLoad = Convert.ToInt32(numMaxCpuLoad.Value);
        }

        private void numMaxRamLoad_ValueChanged(object sender, EventArgs e)
        {
            maxRamLoad = Convert.ToInt32(numMaxRamLoad.Value);
        }

        private void numMaxPagingFileLoad_ValueChanged(object sender, EventArgs e)
        {
            maxPagingFileLoad = Convert.ToInt32(numMaxPagingFileLoad.Value);
        }

        private void numMaxDiskTemperature_ValueChanged(object sender, EventArgs e)
        {
            maxDiskTemperature = Convert.ToInt32(numMaxDiskTemperature.Value);
        }

        private void numMaxDiskLoad_ValueChanged(object sender, EventArgs e)
        {
            maxDiskLoad = Convert.ToInt32(numMaxDiskLoad.Value);
        }
    }
}
