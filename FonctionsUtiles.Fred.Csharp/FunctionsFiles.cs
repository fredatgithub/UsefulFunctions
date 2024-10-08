using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace FonctionsUtiles.Fred.Csharp
{
  public static class FunctionsFiles
  {
    public static void SetManyAttributes(string cheminFichier, params FileAttributes[] listeAttributs)
    {
      foreach (FileAttributes item in listeAttributs)
      {
        SetAttributesEnumere(cheminFichier, item);
      }
    }

    public static void RemoveManyAttributes(string cheminFichier, params FileAttributes[] listeAttributs)
    {
      foreach (FileAttributes item in listeAttributs)
      {
        RemoveAttributes(cheminFichier, item);
      }
    }

    public static void SetAttributesEnumere(string chemin, FileAttributes attributs)
    {
      File.SetAttributes(chemin, File.GetAttributes(chemin) | attributs);
    }

    public static void RemoveAttributes(string chemin, FileAttributes attributesToRemove)
    {
      File.SetAttributes(chemin, File.GetAttributes(chemin) & ~attributesToRemove);
    }

    public static FileAttributes GetRemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
    {
      return attributes & ~attributesToRemove;
    }

    public static void SetAttributes(string chemin, FileAttributes attributs)
    {
      File.SetAttributes(chemin, attributs);
    }

    public static string GetAttributes(string chemin)
    {
      return File.GetAttributes(chemin).ToString();
    }

    public static void SetCreationTime(string chemin, DateTime date)
    {
      File.SetCreationTime(chemin, date);
    }

    public static void SetLastAccessTime(string chemin, DateTime date)
    {
      File.SetLastAccessTime(chemin, date);
    }

    public static DateTime GetCreationTime(string chemin)
    {
      return File.GetCreationTime(chemin);
    }

    public static DateTime GetLastAccessTime(string chemin)
    {
      return File.GetLastAccessTime(chemin);
    }

    public static DateTime GetLastAccessTimeUtc(string chemin)
    {
      return File.GetLastAccessTimeUtc(chemin);
    }

    public static void ReadAndDisplayInConsole(string chemin)
    {
      Action<string> display = Console.WriteLine;
      string[] lines = File.ReadAllLines(chemin);
      foreach (string line in lines)
      {
        display(line);
      }

      display(string.Empty);
    }

    public static bool Deletefile(string filePath)
    {
      if (!File.Exists(filePath))
      {
        return false;
      }

      File.Delete(filePath);
      return true;
    }

    public static void CopyFile(string sourcefile, string destFile, bool overwrite = false)
    {
      File.Copy(sourcefile, destFile, overwrite);
    }

    public static bool MoveFile(string sourcefile, string destFile)
    {
      if (File.Exists(destFile))
      {
        return false;
      }

      File.Move(sourcefile, destFile);
      return true;
    }

    public static void WriteDataArray(string filePath, string[] dataArray)
    {
      if (File.Exists(filePath))
      {
        File.AppendAllLines(filePath, dataArray);
      }
      else
      {
        File.WriteAllLines(filePath, dataArray);
      }
    }

    public static void WriteData(string filePath, string stringData)
    {
      if (File.Exists(filePath))
      {
        File.AppendAllText(filePath, stringData);
      }
      else
      {
        File.WriteAllText(filePath, stringData);
      }
    }

    public static void WriteByteArray(string filePath, byte[] byteArray)
    {
      File.WriteAllBytes(filePath, byteArray);
    }

    public static void CreateFile(string filePath, string stringData = " ")
    {
      File.Create(filePath, stringData.Length);
    }

    public static bool FileRename(string file1, string file2)
    {
      bool result = false;
      try
      {
        File.Move(file1, file2);
        result = true;
      }
      catch (Exception)
      {
        result = false;
      }

      return result;
    }

    public static string GenerateUniqueFileName(string fileName)
    {
      string result = string.Empty;
      if (!File.Exists(fileName))
      {
        return fileName;
      }

      int fileNumber = 1;
      result = AddAtTheEndOfFileName(fileName, fileNumber.ToString(CultureInfo.InvariantCulture));
      while (File.Exists(result))
      {
        fileNumber++;
        result = AddAtTheEndOfFileName(fileName, fileNumber.ToString(CultureInfo.InvariantCulture));
      }

      return result;
    }

    private static string IncreaseFileName(string fileName)
    {
      int fileNumber = 1;
      string result = AddAtTheEndOfFileName(fileName, fileNumber.ToString(CultureInfo.InvariantCulture));
      while (File.Exists(result))
      {
        fileNumber++;
        result = AddAtTheEndOfFileName(fileName, fileNumber.ToString(CultureInfo.InvariantCulture));
      }

      return result;
    }

    private static string AddAtTheEndOfFileName(string fileName, string textToBeAdded)
    {
      const string backslash = "\\";
      string result = GetDirectoryFileNameAndExtension(fileName)[0] + backslash
                                 + GetDirectoryFileNameAndExtension(fileName)[1]
                                 + textToBeAdded
                                 + GetDirectoryFileNameAndExtension(fileName)[2];
      return result;
    }

    private static string[] GetDirectoryFileNameAndExtension(string filePath)
    {
      string directory = Path.GetDirectoryName(filePath);
      string fileName = Path.GetFileNameWithoutExtension(filePath);
      string extension = Path.GetExtension(filePath);

      return new[] { directory, fileName, extension };
    }

    public static void CreateDirectory(string directory)
    {
      Directory.CreateDirectory(directory);
    }

    public static bool DeleteDirectory(string directory)
    {
      bool result = false;
      if (Directory.Exists(directory))
      {
        // check for subdirectories and files within
        string[] files = Directory.GetFiles(directory);
        if (files.Length == 0)
        {
          try
          {
            Directory.Delete(directory);
            result = true;
          }
          catch (Exception)
          {
            result = false;
          }
        }
        else
        {
          // TODO delete subdirectories
          foreach (var file in files)
          {
            try
            {
              File.Delete(file);
            }
            catch (Exception)
            {
              result = false;
            }
          }

        }
      }

      return result;
    }

    public static void CleanDirectory(string tempDirectory)
    {
      Directory.Delete(tempDirectory);
    }

    public static void CreateFile(string filename)
    {
      File.Create(filename);
    }

    public static long FileGetSize(string filePath)
    {
      try
      {
        return File.Exists(filePath) ? new FileInfo(filePath).Length : 0;
      }
      catch (Exception)
      {
        return -1;
      }
    }

    public static string ChooseOneFile(string filter = "All files (*.*)|*.*")
    {
      string result = string.Empty;
      FileDialog fd = new OpenFileDialog();
      fd.Filter = filter;
      if (fd.ShowDialog() == DialogResult.OK)
      {
        result = fd.FileName;
      }

      return result;
    }

    public static string ChooseDirectory()
    {
      string result = string.Empty;
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        result = fbd.SelectedPath;
      }

      return result;
    }

    public static void CreateNewFile(string updateScript)
    {
      StreamWriter sw = new StreamWriter(updateScript, false, Encoding.UTF8);
      sw.Close();
    }

    public static List<FileInfo> SearchFiles(List<string> pattern)
    {
      List<FileInfo> files = new List<FileInfo>();

      foreach (DriveInfo drive in DriveInfo.GetDrives().Where(drive => drive.DriveType != DriveType.CDRom))
      {
        var dirs = from dir in drive.RootDirectory.EnumerateDirectories()
                   select new { ProgDir = dir };
        foreach (var di in dirs)
        {
          try
          {
            foreach (string file in pattern)
            {
              foreach (var fi in di.ProgDir.EnumerateFiles(file, SearchOption.AllDirectories))
              {
                try
                {
                  files.Add(fi);
                }
                catch (UnauthorizedAccessException)
                {
                  // handle accordingly
                }
                catch (Exception)
                {
                  // handle accordingly
                }
              }
            }
          }
          catch (UnauthorizedAccessException)
          {
            // handle accordingly
          }
          catch (Exception)
          {
            // handle accordingly
          }
        }
      }

      return files;
    }

    public static List<string> GetSubfoldersAndFiles(DirectoryInfo directoryInfo, int depth)
    {
      List<string> result = new List<string>();
      foreach (FileInfo fileInfo in directoryInfo.GetFiles())
      {
        result.Add(fileInfo.FullName);
      }

      if (depth > 0)
      {
        foreach (DirectoryInfo subDi in directoryInfo.GetDirectories())
        {
          result.AddRange(GetSubfoldersAndFiles(subDi, depth - 1).ToArray());
        }
      }

      return result;
    }

    public static Tuple<List<string>, List<string>> GetFilesAndFolders(string root, int depth)
    {
      var folders = new List<string>();
      var files = new List<string>();
      try
      {
        foreach (var directory in Directory.EnumerateDirectories(root))
        {
          folders.Add(directory);
          if (depth > 0)
          {
            var result = GetFilesAndFolders(directory, depth - 1);
            folders.AddRange(result.Item1);
            files.AddRange(result.Item2);
          }
        }
      }
      catch (Exception)
      {
        // handle accordingly
      }

      files.AddRange(Directory.EnumerateFiles(root));

      return new Tuple<List<string>, List<string>>(folders, files);
    }

    public static IList<string> GetFilesToDepth(string path, int depth)
    {
      var files = Directory.EnumerateFiles(path).ToList();

      if (depth > 0)
      {
        var folders = Directory.EnumerateDirectories(path);

        foreach (var folder in folders)
        {
          files.AddRange(GetFilesToDepth(folder, depth - 1));
        }
      }

      return files;
    }

    public static List<DriveInfo> GetAllDrives(DriveType[] excludeDriveTypeList)
    {
      List<DriveInfo> result = new List<DriveInfo>();
      try
      {
        foreach (DriveInfo drive in DriveInfo.GetDrives())
        {
          bool addingDrive = true;
          foreach (var excludeDriveType in excludeDriveTypeList)
          {
            if (excludeDriveType == drive.DriveType)
            {
              addingDrive = false;
              break;
            }
          }

          if (addingDrive)
          {
            result.Add(drive);
          }
        }
      }
      catch (Exception)
      {
        // handle accordingly
      }

      return result;
    }

    public static IEnumerable<string> GetAllDirectories(string path, string pattern = "*",
      SearchOption searchOption = SearchOption.TopDirectoryOnly)
    {
      List<string> result = new List<string>();
      if (!Directory.Exists(path))
      {
        return result;
      }

      bool complete = false;
      do
      {
        try
        {
          foreach (var directory in Directory.EnumerateDirectories(path, pattern, searchOption))
          {
            result.Add(directory);
            Application.DoEvents();
          }
          complete = true;
        }
        catch (UnauthorizedAccessException) { complete = false; }
        catch (Exception) { complete = false; }
      } while (!complete);

      return result;
    }

    public static IEnumerable<DirectoryInfo> GetDirs(string rootFolderPath)
    {
      DirectoryInfo rootDir = new DirectoryInfo(rootFolderPath);
      yield return rootDir;

      foreach (DirectoryInfo dir in rootDir.GetDirectories("*", SearchOption.AllDirectories))
      {
        yield return dir;
      }
    }

    public static string Serialize<T>(T value)
    {
      if (value == null)
      {
        return null;
      }

      XmlSerializer serializer = new XmlSerializer(typeof(T));
      XmlWriterSettings settings = new XmlWriterSettings
      {
        Encoding = new UnicodeEncoding(false, false),
        Indent = false,
        OmitXmlDeclaration = false
      };

      using (StringWriter textWriter = new StringWriter())
      {
        using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
        {
          serializer.Serialize(xmlWriter, value);
        }

        return textWriter.ToString();
      }
    }

    public static T Deserialize<T>(string xml)
    {
      if (string.IsNullOrEmpty(xml))
      {
        return default(T);
      }

      XmlSerializer serializer = new XmlSerializer(typeof(T));
      XmlReaderSettings settings = new XmlReaderSettings();

      using (StringReader textReader = new StringReader(xml))
      {
        using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
        {
          return (T)serializer.Deserialize(xmlReader);
        }
      }
    }

    /// <summary>
    /// Remove illegal XML characters from a string.
    /// </summary>
    public static string SanitizeXmlString(string xml)
    {
      // TODO write unit tests for this method
      if (xml == null)
      {
        throw new ArgumentNullException("xml");
      }

      StringBuilder buffer = new StringBuilder(xml.Length);

      foreach (char c in xml)
      {
        if (IsLegalXmlChar(c))
        {
          buffer.Append(c);
        }
      }

      return buffer.ToString();
    }

    /// <summary>
    /// Whether a given character is allowed by XML 1.0.
    /// </summary>
    public static bool IsLegalXmlChar(int character)
    {
      return
      character == 0x9 /* == '\t' == 9   */          ||
      character == 0xA /* == '\n' == 10  */          ||
      character == 0xD /* == '\r' == 13  */          ||
      (character >= 0x20 && character <= 0xD7FF) ||
      (character >= 0xE000 && character <= 0xFFFD) ||
      (character >= 0x10000 && character <= 0x10FFFF);
    }

    public static List<string> GetFilesFileteredBySize(DirectoryInfo directoryInfo, long sizeGreaterOrEqualTo)
    {
      List<string> result = new List<string>();
      foreach (FileInfo fileInfo in directoryInfo.GetFiles())
      {
        if (fileInfo.Length >= sizeGreaterOrEqualTo)
        {
          result.Add(fileInfo.FullName);
        }
      }

      return result;
    }

    public static void WriteAllLines(string fileName, IEnumerable<string> lines)
    {
      if (fileName == null)
      {
        throw new ArgumentNullException(nameof(fileName));
      }

      if (lines == null)
      {
        throw new ArgumentNullException(nameof(lines));
      }

      if (string.IsNullOrWhiteSpace(fileName))
      {
        throw new ArgumentException(@"Value must be filled.", nameof(fileName));
      }

      File.WriteAllLines(fileName, lines, Encoding.UTF8);
    }

    public static string[] ReadAllLines(string fileName)
    {
      if (fileName == null)
      {
        throw new ArgumentNullException(nameof(fileName));
      }

      if (string.IsNullOrWhiteSpace(fileName))
      {
        throw new ArgumentException(@"Value must be filled.", nameof(fileName));
      }

      return File.ReadAllLines(fileName, Encoding.UTF8);
    }

    /// <summary>
    /// Supprime s'il existe plus de 20 fichiers de log par rapport au chemin 'path'
    /// </summary>
    /// <param name="path"></param>
    public static void CleanUp(string path, int numberOfFileToKeep = 20)
    {
      try
      {
        if (File.Exists(path))
        {
          FileInfo fileInfo = new FileInfo(path);
          FileInfo[] logFiles = fileInfo.Directory.GetFiles(fileInfo.Name + "*");
          DateCompareFileInfo dateCompareFileInfo = new DateCompareFileInfo();

          Array.Sort(logFiles, dateCompareFileInfo);

          while (logFiles.Length > numberOfFileToKeep)
          {
            if (File.Exists(logFiles[logFiles.Length - 1].FullName))
            {
              File.Delete(logFiles[logFiles.Length - 1].FullName);
            }

            logFiles = fileInfo.Directory.GetFiles(fileInfo.Name + "*");
          }
        }
      }
      catch (Exception)
      {
        // handle accordingly
      }
    }

    public static string GetOldestFileName(string[] files, string extension)
    {
      // ApplicationName_C_26_backup_2020_04_17_21_02_14_900.full
      string result = string.Empty;
      var subList = files.Where(f => f.Contains(".full"));
      DateTime file1 = GetDateFromFileName(subList.ToArray()[0]);
      DateTime file2 = GetDateFromFileName(subList.ToArray()[1]);
      result = subList.ToList()
        .Min(date => date)
        .ToString();
      return result;
    }

    public static DateTime GetDateFromFileName(string fileName)
    {
      // ApplicationName_C_26_backup_2020_04_17_21_02_14_900.full
      DateTime result;
      var dateSplitted = fileName.Split('_');
      int annee = int.Parse(dateSplitted[4]);
      int mois = int.Parse(dateSplitted[5]);
      int jour = int.Parse(dateSplitted[6]);
      int heure = int.Parse(dateSplitted[7]);
      int minute = int.Parse(dateSplitted[8]);
      int seconde = int.Parse(dateSplitted[9]);

      result = new DateTime(annee, mois, jour, heure, minute, seconde);
      return result;
    }

    public static List<string> GetListOfOlder(IEnumerable<string> list, DateTime date)
    {
      List<string> result = new List<string>();
      foreach (var item in list)
      {
        if (GetDateFromFileName(item) < date)
        {
          result.Add(item);
        }
      }

      return result;
    }

    public static string GetOldestFileName(List<string> value)
    {
      string result = string.Empty;
      List<FileName> tmpFileList = new List<FileName>();
      foreach (var item in value)
      {
        FileName tmpFile = new FileName(item);
        tmpFileList.Add(tmpFile);
      }

      var oldestDate = tmpFileList.Select(f => f.DateOfFile).Min();
      foreach (var item in value)
      {
        FileName tmpFileName = new FileName(item);
        if (tmpFileName.DateOfFile == oldestDate)
        {
          result = tmpFileName.LongName;
          break;
        }
      }

      return result;
    }

    public static List<string> GetOldestFileNames(List<string> value)
    {
      List<string> result = new List<string>();
      List<FileName> tmpFileList = new List<FileName>();
      foreach (var item in value)
      {
        FileName tmpFile = new FileName(item);
        tmpFileList.Add(tmpFile);
      }

      var newestDate = tmpFileList.Select(f => f.DateOfFile).Max();
      foreach (var item in value)
      {
        FileName tmpFileName = new FileName(item);
        if (tmpFileName.DateOfFile != newestDate)
        {
          result.Add(tmpFileName.LongName);
        }
      }

      return result;
    }

    public static string CreateTemporaryDirectory()
    {
      string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
      Directory.CreateDirectory(tempDirectory);
      return tempDirectory;
    }

    public static List<string> GetRandomFileNames(int numberOfFiles = 1)
    {
      var result = new List<string>();
      for (int i = 1; i <= numberOfFiles; i++)
      {
        result.Add(Path.GetRandomFileName());
      }

      return result;
    }

    /// <summary>
    /// Return a string that is a safe file name.
    /// </summary>
    public static string GetSafeFileName(string fileName)
    {
      // List of invalid characters.
      char[] invalid = Path.GetInvalidFileNameChars();

      // Remove all invalid characters.
      int pos;
      while ((pos = fileName.IndexOfAny(invalid)) != -1)
      {
        fileName = fileName.Remove(pos, 1);
      }

      return fileName;
    }

    public static int CountLinesInFilename(string filename)
    {
      int numberOfLines = 0;
      try
      {
        using (StreamReader streamReader = new StreamReader(filename))
        {
          while (streamReader.ReadLine() != null)
          {
            numberOfLines++;
          }
        }
      }
      catch (Exception exception)
      {
        throw new Exception(exception.Message);
      }

      return numberOfLines;
    }

    public static IEnumerable<string> ReadLines(this string content)
    {
      string line;
      using (var sr = new StringReader(content))
      {
        while ((line = sr.ReadLine()) != null)
        {
          yield return line;
        }
      }
    }

    /// <summary>
    /// Change the extension of a filename.
    /// </summary>
    /// <param name="filename">The name of the file with its extension.</param>
    /// <param name="newExtension">The new extension to be changed.</param>
    /// <returns>A string with the full path of the file with the new extension.</returns>
    public static string ChangeExtension(string filename, string newExtension)
    {
      var filenameWithoutExtension = Path.GetFileNameWithoutExtension(filename);
      var directory = Path.GetDirectoryName(filename);
      var fullName = Path.Combine(directory, filenameWithoutExtension);
      var result = $"{fullName}.{newExtension}";
      return result;
    }

    /// <summary>
    /// Get the list of files which have been modified today.
    /// </summary>
    /// <param name="directoryPath">The directory path to start searching from.</param>
    /// <param name="pattern">The pattern for file search. The default is all files (*).</param>
    /// <param name="searchOption">The search option which can be TopDirectoryOnly or AllDirectories. The default is TopDirectoryOnly.</param>
    /// <returns>A list of strings with all files that have been modified today.</returns>
    public static List<string> GetTodayModifiedListOfFiles(string directoryPath, string pattern = "*", SearchOption searchOption = SearchOption.TopDirectoryOnly)
    {
      var result = new List<string>();
      if (!Directory.Exists(directoryPath))
      {
        return result;
      }

      foreach (string file in Directory.GetFiles(directoryPath, pattern, searchOption))
      {
        var modifiedDate = new FileInfo(file).LastWriteTime;
        if (modifiedDate.Year == DateTime.Now.Year && modifiedDate.Month == DateTime.Now.Month && modifiedDate.Day == DateTime.Now.Day)
        {
          result.Add(file);
        }
      }

      return result;
    }

    //Param�tres d'attribut de chemin de fichier s�rialis�
    public static string FileName { get; set; }

    /// <summary>
    /// Save a list of objects to a file.
    /// </summary>
    /// <param name="list">The list of objects.</param>
    /// <param name="filename">The name of the file.</param>
    /// <returns>A boolean to state if saving the file was ok or not.</returns>
    public static bool SaveBinary(List<object> list, string filename)
    {
      bool result = true;
      try
      {
        if (!Directory.Exists(Path.GetDirectoryName(filename)))
        {
          Directory.CreateDirectory(Path.GetDirectoryName(filename));
        }

        FileStream fileStream = new FileStream(filename, FileMode.OpenOrCreate);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(fileStream, list);
        fileStream.Close();
      }
      catch
      {
        result = false;
      }

      return result;
    }

    /// <summary>
    /// Read the file and deserialize the result.
    /// </summary>
    /// <param name="filename">The name of the file.</param>
    /// <returns>A list of objects.</returns>
    public static List<object> ReadBinary(string filename)
    {
      var list = new List<object>();
      if (File.Exists(filename))
      {
        try
        {
          FileStream fileStream = new FileStream(filename, FileMode.OpenOrCreate);
          BinaryFormatter binaryFormatter = new BinaryFormatter();
          list = binaryFormatter.Deserialize(fileStream) as List<object>;
          fileStream.Close();
        }
        catch
        {
          return list;
        }
      }

      return list;
    }
  }
}
