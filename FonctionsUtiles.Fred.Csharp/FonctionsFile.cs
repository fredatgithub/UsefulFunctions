namespace FonctionsUtiles.Fred.Csharp
{
  using System;
  using System.IO;

  public class FonctionsFile
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

    public static void Lit(string chemin)
    {
      Action<string> affiche = Console.WriteLine;
      string[] donnees = File.ReadAllLines(chemin);
      foreach (string t in donnees)
      {
        affiche(t);
      }

      affiche(string.Empty);
    }

    public static bool Deletefile(string chemin)
    {
      if (!File.Exists(chemin))
      {
        return false;
      }

      File.Delete(chemin);
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

    public static void Ecris(string chemin, string[] donnee)
    {
      if (File.Exists(chemin))
      {
        File.AppendAllLines(chemin, donnee);
      }
      else
      {
        File.WriteAllLines(chemin, donnee);
      }
    }

    public static void Ecris(string chemin, string donnee)
    {
      if (File.Exists(chemin))
      {
        File.AppendAllText(chemin, donnee);
      }
      else
      {
        File.WriteAllText(chemin, donnee);
      }
    }

    public static void Ecris(string chemin, byte[] donnee)
    {
      File.WriteAllBytes(chemin, donnee);
    }

    public static void CreateFile(string chemin, string donnee = " ")
    {
      File.Create(chemin, donnee.Length);
    }

    public static void FileRename(string file1, string file2)
    {
      File.Move(file1, file2);
    }
  }
}