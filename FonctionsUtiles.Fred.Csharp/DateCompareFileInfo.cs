using System.Collections.Generic;
using System.IO;

namespace FonctionsUtiles.Fred.Csharp
{
  /// <summary>
  /// Compare les dates de dernières écritures des fileinfo
  /// </summary>
  /// <param name="file1">premier FileInfo à comparer</param>
  /// <param name="file2">deuxième FileInfo à comparer</param>
  /// <returns>0 = les dates sont les mêmes, 1 = file1 plus ancien que file2, -1 = file1 plus récent que file2</returns>
  public class DateCompareFileInfo : IComparer<FileInfo>
  {
    public int Compare(FileInfo file1, FileInfo file2)
    {
      int result;
      if (file1.LastWriteTime == file2.LastWriteTime)
      {
        result = 0;
      }
      else if (file1.LastWriteTime < file2.LastWriteTime)
      {
        result = 1;
      }
      else
      {
        result = -1;
      }

      return result;
    }
  }
}