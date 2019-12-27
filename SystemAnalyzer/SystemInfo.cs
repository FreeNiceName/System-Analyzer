using System;
using System.Collections.Generic;
using System.Management;

namespace SystemAnalyzer
{
    class SystemInfo
    {
        public enum InfoType
        {
            OS, GPU, CPU,
            MB, DiskDrive, RAM
        }
        public string OS { get; set; }
        public string GPU { get; }
        public string CPU { get; }
        public string MB { get; }
        public string DiskDrive { get; }
        public string RAM { get; }

        private string toMB(string _bytes, bool _ram = false)
        {
            double temp = Convert.ToDouble(_bytes) * Math.Pow(10, -9.0);
            if(_ram)
                temp--;
            return Convert.ToInt32(temp).ToString() + " GB ";
        }

        public SystemInfo()
        {
            this.OS = this.GetInfoString(InfoType.OS, "Win32_OperatingSystem");
            this.CPU = this.GetInfoString(InfoType.CPU, "Win32_Processor");
            this.GPU = this.GetInfoString(InfoType.GPU, "Win32_VideoController");
            this.MB = this.GetInfoString(InfoType.MB, "Win32_BaseBoard");
            this.DiskDrive = this.GetInfoString(InfoType.DiskDrive, "Win32_DiskDrive");
            this.RAM = this.GetInfoString(InfoType.RAM, "Win32_PhysicalMemory");
        }
        private List<PropertyDataCollection> GetHardwareInfo(string WIN32_Class)
        {
            List<PropertyDataCollection> result = new List<PropertyDataCollection>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);
            foreach (ManagementObject obj in searcher.Get())
            {
                result.Add(obj.Properties);
            }
            return result;
        }

        private string GetInfoString(InfoType _type, string WIN32_Class)
        {
            List<PropertyDataCollection> info = this.GetHardwareInfo(WIN32_Class);
            string str = "";

            switch (_type)
            {
                case InfoType.CPU:
                    return info[0]["Name"].Value.ToString();
                case InfoType.GPU:
                    for(int i = 0; i < info.Count;i++)
                    {
                        str+= this.toMB(info[i]["AdapterRAM"].Value.ToString()) + info[i]["Name"].Value.ToString();
                        if (i < info.Count - 1)
                            str += ", ";
                    }
                    return str;
                case InfoType.MB:
                    return info[0]["Product"].Value.ToString() + info[0]["Manufacturer"].Value.ToString();
                case InfoType.OS:
                    return info[0]["Caption"].Value.ToString();
                case InfoType.RAM:
                    double size = 0;
                    foreach (var obj in info)
                        size += Convert.ToDouble(obj["Capacity"].Value);
                    return this.toMB(size.ToString(), true);
                case InfoType.DiskDrive:
                    for (int i = 0; i < info.Count; i++)
                    {
                        str += this.toMB(info[i]["Size"].Value.ToString()) + info[i]["Model"].Value.ToString();
                        if (i < info.Count - 1)
                            str += ", ";
                    }
                    return str;
            }
            return "Unknown";
        }

    }
}
