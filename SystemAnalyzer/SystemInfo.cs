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
            OS = GetInfoString(InfoType.OS, "Win32_OperatingSystem");
            CPU = GetInfoString(InfoType.CPU, "Win32_Processor");
            GPU = GetInfoString(InfoType.GPU, "Win32_VideoController");
            MB = GetInfoString(InfoType.MB, "Win32_BaseBoard");
            DiskDrive = GetInfoString(InfoType.DiskDrive, "Win32_DiskDrive");
            RAM = GetInfoString(InfoType.RAM, "Win32_PhysicalMemory");
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
            List<PropertyDataCollection> info = GetHardwareInfo(WIN32_Class);
            string str = "";

            switch (_type)
            {
                case InfoType.CPU:
                    return info[0]["Name"].Value.ToString();
                case InfoType.GPU:
                    for(int i = 0; i < info.Count;i++)
                    {
                        str+= toMB(info[i]["AdapterRAM"].Value.ToString()) + info[i]["Name"].Value.ToString();
                        if (i < info.Count - 1)
                            str += ", ";
                    }
                    return str;
                case InfoType.MB:
                    return info[0]["Product"].Value.ToString() + " " + info[0]["Manufacturer"].Value.ToString();
                case InfoType.OS:
                    return info[0]["Caption"].Value.ToString();
                case InfoType.RAM:
                    double size = 0;
                    foreach (var obj in info)
                        size += Convert.ToDouble(obj["Capacity"].Value);
                    return toMB(size.ToString(), true);
                case InfoType.DiskDrive:
                    for (int i = 0; i < info.Count; i++)
                    {
                        str += toMB(info[i]["Size"].Value.ToString()) + info[i]["Model"].Value.ToString();
                        if (i < info.Count - 1)
                            str += ", ";
                    }
                    return str;
            }
            return "Unknown";
        }

    }
}
