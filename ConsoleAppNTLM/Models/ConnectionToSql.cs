using System.Data.SqlClient;

namespace ConsoleAppNTLM.Models
{
  public class ConnectionToSql
  {
    public static SqlConnection GetConnection()
    {
      string connectionString = @"data source=DESKTOP-MSI; Initial Catalog = NTLM; Trusted_Connection = True;";
      return new SqlConnection(connectionString);
    }
  }
}
