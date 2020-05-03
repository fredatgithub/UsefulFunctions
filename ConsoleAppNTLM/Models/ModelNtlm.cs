using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleAppNTLM.Models
{
  public class ModelNtlm
  {
    public int idNtlm { get; set; }
    public string Code { get; set; }

    public string NtlmHash { get; set; }

    public void InsertMassiveData(IEnumerable<ModelNtlm> hashList)
    {
      var table = new DataTable();
      table.Columns.Add("IdNtlm", typeof(int));
      table.Columns.Add("Code", typeof(string));
      table.Columns.Add("NtlmHash", typeof(string));

      foreach (var item in hashList)
      {
        table.Rows.Add(new object[]
          {
              item.idNtlm,
              item.Code,
              item.NtlmHash
        });
      }

      // insert
      using (var connection = ConnectionToSql.GetConnection())
      {
        connection.Open();
        using (SqlTransaction transaction = connection.BeginTransaction())
        {
          using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaction))
          {
            try
            {
              bulkCopy.DestinationTableName = "NtlmHashTable";
              bulkCopy.WriteToServer(table);
              transaction.Commit();
            }
            catch (Exception)
            {
              transaction.Rollback();
              connection.Close();
            }
          }
        }
      }
    }
  }
}
