/*
The MIT License(MIT)
Copyright(c) 2015 Freddy Juhel
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
namespace FonctionsUtiles.Fred.Csharp
{
  using System;
  using System.Globalization;
  using System.IO;

  public class FunctionsFiles
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
      string Backslash = "\\";
      string result = GetDirectoryFileNameAndExtension(fileName)[0] + Backslash
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
  }
}