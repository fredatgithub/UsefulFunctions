using System;

namespace FonctionsUtiles.Fred.Csharp
{
  public class MemoryManagement
  {
    /// <summary>
    /// Free memory by forcing GC.
    /// </summary>
    public static void FreeMemory()
    {
      GC.Collect();
      GC.WaitForPendingFinalizers();
      GC.Collect();
    }
  }
}
