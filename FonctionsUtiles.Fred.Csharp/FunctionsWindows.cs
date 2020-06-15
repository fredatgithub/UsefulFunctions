using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.Principal;

namespace FonctionsUtiles.Fred.Csharp
{
  public class FunctionsWindows
  {
    public static bool IsInWinPath(string substring)
    {
      bool result = false;
      string winPath = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
      if (winPath != null) result = winPath.Contains(substring);
      return result;
    }

    public static string DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      return $@"V{fvi.FileMajorPart}.{fvi.FileMinorPart}.{fvi.FileBuildPart}.{fvi.FilePrivatePart}";
    }

    public static bool IsAdministrator()
    {
      WindowsIdentity identity = WindowsIdentity.GetCurrent();
      WindowsPrincipal principal = new WindowsPrincipal(identity);
      return principal.IsInRole(WindowsBuiltInRole.Administrator);
    }

    public static bool IsAdmin()
    {
      return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
    }

    public static IEnumerable<Process> GetAllProcesses()
    {
      Process[] processlist = Process.GetProcesses();
      return processlist.ToList();
    }

    public static bool IsProcessRunningById(Process process)
    {
      try { Process.GetProcessById(process.Id); }
      catch (InvalidOperationException) { return false; }
      catch (ArgumentException) { return false; }
      return true;
    }

    public static bool IsProcessRunningByName(string processName)
    {
      try { Process.GetProcessesByName(processName); }
      catch (InvalidOperationException) { return false; }
      catch (ArgumentException) { return false; }
      return true;
    }

    public static Process GetProcessByName(string processName)
    {
      Process result = new Process();
      foreach (Process process in GetAllProcesses())
      {
        if (process.ProcessName == processName)
        {
          result = process;
          break;
        }
      }

      return result;
    }

    public static IEnumerable<FileInfo> GetAllLargeFilesWithLinq(string path)
    {
      var query = new DirectoryInfo(path).GetFiles()
                      .OrderByDescending(file => file.Length);
      return query;
    }

    public static string NomPC()
    {
      string nom = string.Empty;
      var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT CSName FROM Win32_OperatingSystem");
      foreach (ManagementObject queryObj in searcher.Get())
      {
        nom = queryObj["CSName"].ToString().Trim();
      }

      searcher.Dispose();
      return nom;
    }

    public static string NomSysteme()
    {
      string nom = string.Empty;
      var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT Caption FROM Win32_OperatingSystem");
      foreach (ManagementObject queryObj in searcher.Get())
      {
        nom = queryObj["Caption"].ToString().Trim();
      }

      searcher.Dispose();
      return nom;
    }

    public static bool EstXPSP3()
    {
      try
      {
        string nom = string.Empty;
        var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT CSDVersion FROM Win32_OperatingSystem");
        foreach (ManagementObject queryObj in searcher.Get())
        {
          if (queryObj["CSDVersion"].ToString().Trim().ToUpper() == "SERVICE PACK 3")
          {
            searcher.Dispose();
            return true;
          }
        }

        searcher.Dispose();
        return false;
      }
      catch
      {
        return false;
      }
    }

    public static bool EstFramework4()
    {
      try
      {
        string version = string.Empty;
        var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT Name, Version FROM Win32_Product WHERE Name like '%Framework 4%' AND Version LIKE '%4%'");
        foreach (ManagementObject queryObj in searcher.Get())
        {
          version = queryObj["Version"].ToString().Trim();
          if (version.Substring(0, 1) == "4")
          {
            searcher.Dispose();
            return true;
          }
        }

        searcher.Dispose();
        return false;
      }
      catch
      {
        return false;
      }
    }

    public static bool EstCrystal13()
    {
      try
      {
        string version = string.Empty;
        var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT Name, Version FROM Win32_Product WHERE Name like 'SAP Crystal%' AND Version LIKE '%13%'");
        foreach (ManagementObject queryObj in searcher.Get())
        {
          version = queryObj["Version"].ToString().Trim();
          if (version.Substring(0, 2) == "13")
          {
            searcher.Dispose();
            return true;
          }
        }

        searcher.Dispose();
        return false;
      }
      catch
      {
        return false;
      }
    }


    public static string AdresseIP(string computername)
    {
      try
      {
        if (computername != string.Empty)
        {
          string[] saddr = null;
          IPAddress[] addr = Dns.GetHostEntry(computername).AddressList;

          if (addr.Length > 0)
          {
            saddr = new string[addr.Length];
            for (int i = 0; i < addr.Length; i++)
            {
              saddr[i] = addr[i].ToString();
            }
          }

          if (saddr.Length == 1)
          {
            return saddr[0];
          }
          else
          {
            return saddr[1];
          }
        }
        else
        {
          return string.Empty;
        }
      }
      catch
      {
        return string.Empty;
      }
    }
  }
}