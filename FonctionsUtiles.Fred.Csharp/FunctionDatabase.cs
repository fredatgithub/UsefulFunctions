namespace FonctionsUtiles.Fred.Csharp
{
  public static class FunctionDatabase
  {
    public static string AddTimeOutToConnectionString(string connectionString)
    {
      if (!connectionString.Contains("Timeout"))
      {
        connectionString += "Timeout=0;";
      }

      return connectionString;
    }

    public static string AddSemiColonIfNeeded(string connectionString)
    {
      if (!connectionString.EndsWith(";"))
      {
        connectionString += ";";
      }

      return connectionString;
    }
  }
}
