﻿using System;
using System.Drawing;
using System.IO;

namespace FonctionsUtiles.Fred.Csharp
{
  public class FileName : IComparable<FileName>
  {
    public string LongName { get; set; }
    public string Extension { get; set; }
    public DateTime DateOfFile { get; set; }
    public string DatabaseName { get; set; }
    public bool IsDiffFile { get; set; }
    public bool IsFullFile { get; set; }

    public FileName()
    {
      LongName = string.Empty;
      Extension = string.Empty;
      IsDiffFile = false;
      IsFullFile = false;
    }

    public FileName(string name, string extension, DateTime date, string databaseName = "")
    {
      LongName = name;
      Extension = extension;
      DateOfFile = date;
      DatabaseName = DatabaseName;
      IsDiffFile = false;
      IsFullFile = false;
    }

    public FileName(string name)
    {
      LongName = name;
      if (name.EndsWith("diff"))
      {
        Extension = "diff";
        IsDiffFile = true;
        IsFullFile = false;
      }
      else if (name.EndsWith("full"))
      {
        Extension = "full";
        IsDiffFile = false;
        IsFullFile = true;
      }
      else
      {
        Extension = string.Empty;
        IsDiffFile = false;
        IsFullFile = false;
      }

      DateOfFile = CalculateDate(Path.GetFileName(name));
      DatabaseName = CalculateDatabaseName(Path.GetFileName(name));
    }

    private string CalculateDatabaseName(string name)
    {
      string result = string.Empty;
      var longDate = name.Split('_');
      result = $"{longDate[1]}_{longDate[2]}";
      return result;
    }

    private DateTime CalculateDate(string name)
    {
      // Gestion_X_2_backup_2020_10_02_20_51_40_320.full
      var longDate = name.Split('_');
      DateTime result = new DateTime(int.Parse(longDate[4]), int.Parse(longDate[5]), int.Parse(longDate[6]), int.Parse(longDate[7]), int.Parse(longDate[8]), int.Parse(longDate[9]));
      return result;
    }

    public int CompareTo(FileName other)
    {
      return DateOfFile.CompareTo(other.DateOfFile);
    }

    public override int GetHashCode()
    {
      throw new NotImplementedException();
    }

    public static bool operator ==(FileName left, FileName right)
    {
      return left.DateOfFile == right.DateOfFile;
    }

    public static bool operator !=(FileName left, FileName right)
    {
      return !(left.DateOfFile == right.DateOfFile);
    }

    public static bool operator <(FileName left, FileName right)
    {
      return ReferenceEquals(left.DateOfFile, null) ? !ReferenceEquals(right.DateOfFile, null) : left.CompareTo(right) < 0;
    }

    public static bool operator <=(FileName left, FileName right)
    {
      return ReferenceEquals(left, null) || left.CompareTo(right) <= 0;
    }

    public static bool operator >(FileName left, FileName right)
    {
      return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
    }

    public static bool operator >=(FileName left, FileName right)
    {
      return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(this, obj))
      {
        return true;
      }

      if (ReferenceEquals(obj, null))
      {
        return false;
      }

      throw new NotImplementedException();
    }

    public static bool IsFileLocked(FileInfo file)
    {
      try
      {
        using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
        {
          stream.Close();
        }
      }
      catch (IOException)
      {
        //the file is unavailable because it is:
        //still being written to
        //or being processed by another thread
        //or does not exist (has already been processed)
        return true;
      }
      catch (Exception)
      {
        return true;
      }

      //file is not locked
      return false;
    }

    public static bool IsPictureLandscape(string pictureFilePathWithName)
    {
      try
      {
        using (Bitmap image = new Bitmap(pictureFilePathWithName))
        {
          return image.Width > image.Height;
        }
      }
      catch (Exception)
      {
        return false;
      }
    }
  }
}
