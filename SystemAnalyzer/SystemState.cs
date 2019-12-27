using System;
using System.IO;
using System.Management;
using System.Diagnostics;

namespace SystemAnalyzer
{
    class SystemState
    {
        private const string logPath = "log.txt";

        public int CpuLoad { get; private set;}
        public int CpuTemperature { get; private set; }
        public int RamLoad { get; private set; }
        public int PagingFileLoad { get; private set; }
        public int DiskLoad { get; private set; }
        public int DiskTemperature { get; private set; }

        private PerformanceCounter cpuLoadCounter = null;
        private PerformanceCounter cpuTemperatureCounter = null;
        private PerformanceCounter ramLoadCounter = null;
        private PerformanceCounter pagingFileLoadCounter = null;
        private PerformanceCounter diskActiveTimeCounter = null;

        public SystemState()
        {
            cpuLoadCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuTemperatureCounter = new PerformanceCounter("Thermal Zone Information", "Temperature", @"\_TZ.THRM");
            ramLoadCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            pagingFileLoadCounter = new PerformanceCounter("Paging File", "% Usage", "_Total");
            diskActiveTimeCounter = new PerformanceCounter("PhysicalDisk", "% Idle Time", "_Total");
        }

        public void UpdateValues()
        {
            CpuLoad = Convert.ToInt32(cpuLoadCounter.NextValue());
            CpuTemperature = Convert.ToInt32(cpuTemperatureCounter.NextValue()) - 273;
            RamLoad = Convert.ToInt32(ramLoadCounter.NextValue());
            PagingFileLoad = Convert.ToInt32(pagingFileLoadCounter.NextValue());
            DiskLoad = 100 - Convert.ToInt32(diskActiveTimeCounter.NextValue());
            DiskTemperature = GetDiskTemperature();
        }
        
        private int GetDiskTemperature()
        {
            int result = 0;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSStorageDriver_ATAPISmartData WHERE Active=True");
            foreach (ManagementObject obj in searcher.Get())
            {
                byte[] vendorSpec = obj["VendorSpecific"] as byte[];
                if (vendorSpec != null)
                {
                    result = vendorSpec[163];
                }
            }
            return result;
        }

        public void WriteInFile()
        {
            using (StreamWriter sw = new StreamWriter(logPath, true))
            {
                sw.WriteLine(
                    DateTime.Now.ToString() +
                    "\tCPU Load: " + CpuLoad + "%" +
                    "\tCPU Temperature: " + CpuTemperature + "°C" +
                    "\tRAM Load: " + RamLoad + "%" +
                    "\tPaging File Load: " + PagingFileLoad + "%" +
                    "\tDisk Load: " + DiskLoad + "%" +
                    "\tDisk Temperature: " + DiskTemperature + "°C"
                    );
            }
        }
    }
}
