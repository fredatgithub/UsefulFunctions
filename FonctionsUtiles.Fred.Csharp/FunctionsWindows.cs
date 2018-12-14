using System;
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
  }
}