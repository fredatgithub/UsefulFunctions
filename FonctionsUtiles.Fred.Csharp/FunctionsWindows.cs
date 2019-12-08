using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
  }
}