using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace paee2_WF
{
    public enum DiskData
    {
        Read,
        Write,
        ReadAndWrite
    }

    public enum NetData
    {
        Received,
        Sent,
        ReceivedAndSent
    }

    public class LectorRecursosSistema
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private class MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;

            public MEMORYSTATUSEX()
            {
                dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
            }
        }

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

        private PerformanceCounter cpuCounter;
        private PerformanceCounter diskReadCounter;
        private PerformanceCounter diskWriteCounter;
        private PerformanceCounter diskBytesCounter;

        private long lastBytesReceived;
        private long lastBytesSent;
        private DateTime lastNetSampleTime;
        private double lastNetReceivedBps;
        private double lastNetSentBps;

        private string cachedManufacturer;
        private string cachedModel;
        private string[] cachedProcessors;
        private string cachedUser;

        public LectorRecursosSistema()
        {
            try
            {
                cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                cpuCounter.NextValue();
            }
            catch
            {
                cpuCounter = null;
            }

            try
            {
                diskReadCounter = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "_Total");
                diskReadCounter.NextValue();
            }
            catch
            {
                diskReadCounter = null;
            }

            try
            {
                diskWriteCounter = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_Total");
                diskWriteCounter.NextValue();
            }
            catch
            {
                diskWriteCounter = null;
            }

            try
            {
                diskBytesCounter = new PerformanceCounter("PhysicalDisk", "Disk Bytes/sec", "_Total");
                diskBytesCounter.NextValue();
            }
            catch
            {
                diskBytesCounter = null;
            }

            InitializeNetworkSampling();
        }

        private void InitializeNetworkSampling()
        {
            try
            {
                long rx = 0;
                long tx = 0;
                GetTotalNetworkBytes(out rx, out tx);
                lastBytesReceived = rx;
                lastBytesSent = tx;
                lastNetSampleTime = DateTime.UtcNow;
                lastNetReceivedBps = 0;
                lastNetSentBps = 0;
            }
            catch
            {
                lastNetSampleTime = DateTime.UtcNow;
            }
        }

        private void GetTotalNetworkBytes(out long received, out long sent)
        {
            received = 0;
            sent = 0;
            try
            {
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface ni in interfaces)
                {
                    if (ni.OperationalStatus == OperationalStatus.Up &&
                        ni.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                    {
                        IPInterfaceStatistics stats = ni.GetIPStatistics();
                        received += stats.BytesReceived;
                        sent += stats.BytesSent;
                    }
                }
            }
            catch
            {
                // Fallback silently
            }
        }

        private void UpdateNetworkRates()
        {
            DateTime now = DateTime.UtcNow;
            double elapsed = (now - lastNetSampleTime).TotalSeconds;
            if (elapsed <= 0.2)
            {
                return;
            }

            long currentRx, currentTx;
            GetTotalNetworkBytes(out currentRx, out currentTx);

            if (lastBytesReceived > 0 && currentRx >= lastBytesReceived)
            {
                lastNetReceivedBps = (currentRx - lastBytesReceived) / elapsed;
            }
            else
            {
                lastNetReceivedBps = 0;
            }

            if (lastBytesSent > 0 && currentTx >= lastBytesSent)
            {
                lastNetSentBps = (currentTx - lastBytesSent) / elapsed;
            }
            else
            {
                lastNetSentBps = 0;
            }

            lastBytesReceived = currentRx;
            lastBytesSent = currentTx;
            lastNetSampleTime = now;
        }

        public string getCPU()
        {
            try
            {
                if (cpuCounter != null)
                {
                    float val = cpuCounter.NextValue();
                    return string.Format("{0:0.00}%", val);
                }
            }
            catch
            {
                // Fallback
            }

            return "0.00%";
        }

        public double getDatosDisco(DiskData data)
        {
            try
            {
                switch (data)
                {
                    case DiskData.Read:
                        if (diskReadCounter != null) return diskReadCounter.NextValue();
                        break;
                    case DiskData.Write:
                        if (diskWriteCounter != null) return diskWriteCounter.NextValue();
                        break;
                    case DiskData.ReadAndWrite:
                        if (diskBytesCounter != null)
                        {
                            double val = diskBytesCounter.NextValue();
                            if (val > 0) return val;
                        }
                        if (diskReadCounter != null && diskWriteCounter != null)
                        {
                            return diskReadCounter.NextValue() + diskWriteCounter.NextValue();
                        }
                        break;
                }
            }
            catch
            {
                // Fallback
            }

            return 0.0;
        }

        public double getDatosRed(NetData data)
        {
            try
            {
                UpdateNetworkRates();

                switch (data)
                {
                    case NetData.Received:
                        return lastNetReceivedBps;
                    case NetData.Sent:
                        return lastNetSentBps;
                    case NetData.ReceivedAndSent:
                        return lastNetReceivedBps + lastNetSentBps;
                }
            }
            catch
            {
                // Fallback
            }

            return 0.0;
        }

        public string getDiscosLogicos()
        {
            try
            {
                List<string> drivesList = new List<string>();
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady)
                    {
                        string driveLetter = drive.Name.TrimEnd('\\', '/', ':');
                        drivesList.Add(string.Format("{0}:{1}", driveLetter, FormatearBytes(drive.TotalFreeSpace)));
                    }
                }

                if (drivesList.Count > 0)
                {
                    return string.Join(", ", drivesList);
                }
            }
            catch
            {
                // Fallback
            }

            return "N/D";
        }

        public string getMemoriaFisica()
        {
            try
            {
                MEMORYSTATUSEX status = new MEMORYSTATUSEX();
                if (GlobalMemoryStatusEx(status))
                {
                    double totalBytes = status.ullTotalPhys;
                    double freeBytes = status.ullAvailPhys;
                    double usedBytes = totalBytes - freeBytes;

                    double totalGb = totalBytes / (1024.0 * 1024.0 * 1024.0);
                    double usedGb = usedBytes / (1024.0 * 1024.0 * 1024.0);
                    double pct = (usedBytes / totalBytes) * 100.0;

                    return string.Format("{0:0.00}% ({1:0.00} GB / {2:0.00} GB)", pct, usedGb, totalGb);
                }
            }
            catch
            {
                // Fallback
            }

            return "0.00% (0.00 GB / 0.00 GB)";
        }

        public string getMemoriaVirtual()
        {
            try
            {
                MEMORYSTATUSEX status = new MEMORYSTATUSEX();
                if (GlobalMemoryStatusEx(status))
                {
                    double totalBytes = status.ullTotalPageFile;
                    double freeBytes = status.ullAvailPageFile;
                    double usedBytes = totalBytes - freeBytes;

                    double totalGb = totalBytes / (1024.0 * 1024.0 * 1024.0);
                    double usedGb = usedBytes / (1024.0 * 1024.0 * 1024.0);
                    double pct = totalBytes > 0 ? (usedBytes / totalBytes) * 100.0 : 0.0;

                    return string.Format("{0:0.00}% ({1:0.00} GB / {2:0.00} GB)", pct, usedGb, totalGb);
                }
            }
            catch
            {
                // Fallback
            }

            return "0.00% (0.00 GB / 0.00 GB)";
        }

        public string getOrdenadorFabricante()
        {
            if (cachedManufacturer != null)
            {
                return cachedManufacturer;
            }

            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Manufacturer FROM Win32_ComputerSystem"))
                {
                    foreach (ManagementObject mo in searcher.Get())
                    {
                        object val = mo["Manufacturer"];
                        if (val != null)
                        {
                            cachedManufacturer = val.ToString().Trim();
                            return cachedManufacturer;
                        }
                    }
                }
            }
            catch
            {
                // Fallback
            }

            cachedManufacturer = "Desconocido";
            return cachedManufacturer;
        }

        public string getOrdenadorModelo()
        {
            if (cachedModel != null)
            {
                return cachedModel;
            }

            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Model FROM Win32_ComputerSystem"))
                {
                    foreach (ManagementObject mo in searcher.Get())
                    {
                        object val = mo["Model"];
                        if (val != null)
                        {
                            cachedModel = val.ToString().Trim();
                            return cachedModel;
                        }
                    }
                }
            }
            catch
            {
                // Fallback
            }

            cachedModel = "Desconocido";
            return cachedModel;
        }

        public string[] getProcesadores()
        {
            if (cachedProcessors != null)
            {
                return cachedProcessors;
            }

            try
            {
                List<string> procs = new List<string>();
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Name FROM Win32_Processor"))
                {
                    foreach (ManagementObject mo in searcher.Get())
                    {
                        object val = mo["Name"];
                        if (val != null)
                        {
                            procs.Add(val.ToString().Trim());
                        }
                    }
                }

                if (procs.Count > 0)
                {
                    cachedProcessors = procs.ToArray();
                    return cachedProcessors;
                }
            }
            catch
            {
                // Fallback
            }

            cachedProcessors = new string[] { Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER") ?? "Desconocido" };
            return cachedProcessors;
        }

        public string getUsuario()
        {
            if (cachedUser != null)
            {
                return cachedUser;
            }

            try
            {
                string domain = Environment.UserDomainName;
                string user = Environment.UserName;
                if (!string.IsNullOrEmpty(domain) && !string.IsNullOrEmpty(user))
                {
                    cachedUser = string.Format("{0}\\{1}", domain, user);
                    return cachedUser;
                }
            }
            catch
            {
                // Fallback
            }

            cachedUser = Environment.UserName ?? "Usuario";
            return cachedUser;
        }

        private static string FormatearBytes(long bytes)
        {
            if (bytes >= 1024L * 1024L * 1024L * 1024L)
                return string.Format("{0:0.00} TB", (double)bytes / (1024L * 1024L * 1024L * 1024L));
            if (bytes >= 1024L * 1024L * 1024L)
                return string.Format("{0:0.00} GB", (double)bytes / (1024L * 1024L * 1024L));
            if (bytes >= 1024L * 1024L)
                return string.Format("{0:0.00} MB", (double)bytes / (1024L * 1024L));
            if (bytes >= 1024L)
                return string.Format("{0:0.00} KB", (double)bytes / 1024L);
            return string.Format("{0} B", bytes);
        }
    }
}
