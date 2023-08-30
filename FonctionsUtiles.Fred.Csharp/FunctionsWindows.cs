using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FonctionsUtiles.Fred.Csharp.Enums;
using System.Net.Http;

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

    public static string PCName()
    {
      string name = string.Empty;
      var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT CSName FROM Win32_OperatingSystem");
      foreach (ManagementObject queryObj in searcher.Get())
      {
        name = queryObj["CSName"].ToString().Trim();
      }

      searcher.Dispose();
      return name;
    }

    public static string SystemName()
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

    public static bool IsWindowsXPSP3()
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

    public static bool IsFrameworkV4Installed()
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

    public static bool DoesCrystalVersionIsInV13()
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


    public static string AdresseIP(string computerName)
    {
      try
      {
        if (computerName != string.Empty)
        {
          string[] saddr = null;
          IPAddress[] addr = Dns.GetHostEntry(computerName).AddressList;

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

    public static string GetProfileUserName()
    {
      return Environment.UserName;
    }

    public static string GetHostname()
    {
      return Environment.MachineName;
    }

    public static string GetFramework()
    {
      object[] list = Assembly.GetExecutingAssembly().GetCustomAttributes(true);
      var attribute = list.OfType<TargetFrameworkAttribute>().First();
      return attribute.FrameworkDisplayName;
    }

    public static async Task DownloadAsync(string url, string downloadFullPath, IProgress<double> progress, CancellationToken token)
    {
      //var client = new HttpClient();

      //HttpResponseMessage response = client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, token).Result;
      //response.EnsureSuccessStatusCode();

      //await Stream contentStream = await response.Content.ReadAsStreamAsync(token), FileStream = new FileStream(downloadFullPath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true);
      //var totalRead = 0L;
      //var totalReads = 0L;
      //var buffer = new byte[8192];
      //var isMoreToRead = true;

      //do
      //{
      //  var read = await contentStream.ReadAsync(buffer, 0, buffer.Length, token);
      //  if (read == 0)
      //  {
      //    isMoreToRead = false;
      //  }
      //  else
      //  {
      //    await fileStream.WriteAsync(buffer.AsMemory(0, read), token);

      //    totalRead += read;
      //    totalReads += 1;

      //    if (totalReads % 2000 == 0)
      //    {
      //      Console.WriteLine($"total bytes downloaded so far: {totalRead:n0}");
      //    }
      //  }
      //}
      //while (isMoreToRead);
    }

    public static void ExtractZip(string zipFile, string destDir, string extractPath = "", bool ignoreRootDir = false)
    {
      //Stream stream = File.OpenRead(zipFile);
      //var reader = ReaderFactory.Open(stream);
      //var isWindows = IsWindows();
      //var symbolicLinks = new Dictionary<string, string>();

      //var opts = new ExtractionOptions()
      //{
      //  ExtractFullPath = true,
      //  Overwrite = true,
      //  WriteSymbolicLink = (symbolicLinkPath, symbolicLinkSourceFile) =>
      //  {
      //    if (isWindows) return;
      //    var fileDir = Path.GetDirectoryName(symbolicLinkPath);
      //    symbolicLinks[symbolicLinkPath] = Path.Combine(fileDir, symbolicLinkSourceFile);
      //  }
      //};

      //while (reader.MoveToNextEntry())
      //{
      //  if (reader.Entry.IsDirectory) continue;
      //  // Specify the extraction path for the entry
      //  var extractionPath = Path.Combine(destDir, reader.Entry.Key);

      //  // Ensure that the target directory exists
      //  var targetDirectory = Path.GetDirectoryName(extractionPath);
      //  if (!Directory.Exists(targetDirectory))
      //  {
      //    Directory.CreateDirectory(targetDirectory!);
      //  }

      //  reader.WriteEntryToFile(extractionPath, opts);
      //}

      //foreach (var item in symbolicLinks.Where(item => File.Exists(item.Value)))
      //{
      //  File.Copy(item.Value, item.Key);
      //}
    }

    public static void ExtractZipFolder(string zipFile, string destDir, string extractPath = "", bool ignoreRootDir = false)
    {
      //var archive = ZipFile.OpenRead(zipFile);
      //var result = from entry in archive.Entries
      //             where entry.FullName.StartsWith(extractPath)
      //             select entry;

      //foreach (var entry in result)
      //{
      //  var fullName = entry.FullName;

      //  if (ignoreRootDir)
      //  {
      //    var pathParts = entry.FullName.Split('/');
      //    pathParts = pathParts.Skip(1).ToArray();

      //    fullName = Path.Combine(pathParts);
      //  }

      //  var fullPath = Path.Combine(destDir, fullName);
      //  if (string.IsNullOrEmpty(entry.Name))
      //  {
      //    Directory.CreateDirectory(fullPath);
      //  }
      //  else
      //  {
      //    entry.ExtractToFile(fullPath, overwrite: true);
      //  }
      //}
    }

    public static int GetAvailablePort(int startingPort = 5500)
    {
      List<int> portArray = new List<int>();

      IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();

      //getting active connections
      TcpConnectionInformation[] connections = properties.GetActiveTcpConnections();
      portArray.AddRange(from n in connections
                         where n.LocalEndPoint.Port >= startingPort
                         select n.LocalEndPoint.Port);

      //getting active tcp listeners
      var endPoints = properties.GetActiveTcpListeners();
      portArray.AddRange(from n in endPoints
                         where n.Port >= startingPort
                         select n.Port);

      //getting active udp listeners
      endPoints = properties.GetActiveUdpListeners();
      portArray.AddRange(from n in endPoints
                         where n.Port >= startingPort
                         select n.Port);

      portArray.Sort();

      for (int i = startingPort; i < UInt16.MaxValue; i++)
      {
        if (!portArray.Contains(i))
        {
          return i;
        }
      }

      return 0;
    }

    public static ProcessResult RunProcess(string filename, List<string> args)
    {
      var outputBuilder = new StringBuilder();
      var errorBuilder = new StringBuilder();
      using (var process = new Process())
      {
        process.StartInfo.RedirectStandardError = true;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.UseShellExecute = false;
        process.EnableRaisingEvents = true;
        process.OutputDataReceived += (_, e) =>
        {
          if (!string.IsNullOrEmpty(e.Data))
            outputBuilder.AppendLine(e.Data);
        };

        process.ErrorDataReceived += (_, e) =>
        {
          if (!string.IsNullOrEmpty(e.Data))
            errorBuilder.AppendLine(e.Data);
        };

        process.StartInfo.FileName = filename;
        process.StartInfo.Arguments = string.Join(" ", args);
        process.StartInfo.CreateNoWindow = true;

        process.Start();

        process.BeginOutputReadLine();
        process.BeginErrorReadLine();

        process.WaitForExit();

        process.CancelOutputRead();
        process.CancelErrorRead();

        var output = outputBuilder.ToString();
        var error = errorBuilder.ToString();

        return new ProcessResult { ExitCode = process.ExitCode, Output = output, Error = error };
      }
    }

    public static bool IsWindows()
    {
      return RuntimeInformation.IsOSPlatform(
          OSPlatform.Windows
      );
    }

    public static Platform? GetPlatform()
    {
      if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
      {
        return Platform.Windows;
      }

      if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
      {
        return Platform.Linux;
      }

      if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
      {
        return Platform.Darwin;
      }

      return null;
    }

    public static Enums.Architecture GetArchitecture(Platform platform)
    {
      if (platform != Platform.Darwin) return Enums.Architecture.Amd64;

      var processResult = RunProcess("sysctl", new List<string>
    {
        "machdep.cpu.brand_string"
    });

      return processResult.Output.Contains("Apple M") ? Enums.Architecture.Arm64V8 : Enums.Architecture.Amd64;
    }
  }
}