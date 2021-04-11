using ConsoleAppNTLM.Models;
using FonctionsUtiles.Fred.Csharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace ConsoleAppNTLM
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      ulong count = 0;
      bool addToListe = true;
      bool saveToFile = false;
      bool saveToDatabase = true;
      ulong numberOfItem = 1000000;
      ulong fileCount = 1;
      Dictionary<string, string> dicoResult = new Dictionary<string, string>();
      // IdNtlm	Code	NtlmHash
      // 1      A     C5DD1C2BC8719C01B25B4EB2692C9FEE
      string alphabet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ&é'(-è_çà)=$£*%âêîôûù,;:!?./\\§µä+°€@<>";
      for (int i = 0; i < alphabet.Length; i++)
      {
        count++;
        string ntlm = FunctionsCrypto.Ntlm(alphabet[i].ToString());
        display($"{alphabet[i]} = {ntlm}");
        if (addToListe)
        {
          dicoResult.Add(alphabet[i].ToString(), ntlm);
        }
      }

      // 100 NTLM calculated so far with 1 character
      for (int i = 0; i < alphabet.Length; i++)
      {
        for (int j = 0; j < alphabet.Length; j++)
        {
          if (saveToDatabase && count % numberOfItem == 0)
          {
            RecordResultsToDatabase(dicoResult);
            dicoResult.Clear();
            count = 0;
          }

          if (saveToFile && count % numberOfItem == 0)
          {
            ulong fileNumber = fileCount * numberOfItem;
            RecordResultsToFile(dicoResult, fileNumber);
            fileCount++;
            dicoResult.Clear();
          }

          count++;
          string ntlm = FunctionsCrypto.Ntlm($"{alphabet[i]}{alphabet[j]}");
          display($"{alphabet[i]}{alphabet[j]} = {ntlm}");
          if (addToListe)
          {
            dicoResult.Add($"{alphabet[i]}{alphabet[j]}", ntlm);
          }
        }
      }

      //// 10 302 NTLM calculated so far with 2 characters
      for (int i = 0; i < alphabet.Length; i++)
      {
        for (int j = 0; j < alphabet.Length; j++)
        {
          for (int k = 0; k < alphabet.Length; k++)
          {
            if (saveToDatabase && count % numberOfItem == 0)
            {
              RecordResultsToDatabase(dicoResult);
              dicoResult.Clear();
              count = 0;
            }

            if (saveToFile && count % numberOfItem == 0)
            {
              ulong fileNumber = fileCount * numberOfItem;
              RecordResultsToFile(dicoResult, fileNumber);
              fileCount++;
              dicoResult.Clear();
            }

            count++;
            string ntlm = FunctionsCrypto.Ntlm(alphabet[i].ToString() + alphabet[j].ToString() + alphabet[k].ToString());
            display($"{alphabet[i]}{alphabet[j]}{alphabet[k]} = {ntlm}");
            if (addToListe)
            {
              dicoResult.Add($"{alphabet[i]}{alphabet[j]}{alphabet[k]}", ntlm);
            }
          }
        }
      }

      //// 1 040 603 NTLM calculated so far with 3 characters
      for (int i = 0; i < alphabet.Length; i++)
      {
        for (int j = 0; j < alphabet.Length; j++)
        {
          for (int k = 0; k < alphabet.Length; k++)
          {
            for (int l = 0; l < alphabet.Length; l++)
            {
              if (saveToDatabase && count % numberOfItem == 0)
              {
                RecordResultsToDatabase(dicoResult);
                dicoResult.Clear();
                count = 0;
              }

              if (saveToFile && count % numberOfItem == 0)
              {
                ulong fileNumber = fileCount * numberOfItem;
                RecordResultsToFile(dicoResult, fileNumber);
                fileCount++;
                dicoResult.Clear();
              }

              count++;
              string ntlm = FunctionsCrypto.Ntlm(alphabet[i].ToString() + alphabet[j].ToString() + alphabet[k].ToString() + alphabet[l].ToString());
              display($"{alphabet[i]}{alphabet[j]}{alphabet[k]}{alphabet[l]} = {ntlm}");
              if (addToListe)
              {
                dicoResult.Add($"{alphabet[i]}{alphabet[j]}{alphabet[k]}{alphabet[l]}", ntlm);
              }
            }
          }
        }
      }

      // 105 101 004 NTLM calculated so far with 4 characters //out of memory error at 3.6 GB console app if addToListe = true

      for (int i = 0; i < alphabet.Length; i++)
      {
        for (int j = 0; j < alphabet.Length; j++)
        {
          for (int k = 0; k < alphabet.Length; k++)
          {
            for (int l = 0; l < alphabet.Length; l++)
            {
              for (int m = 0; m < alphabet.Length; m++)
              {
                if (saveToDatabase && count % numberOfItem == 0)
                {
                  RecordResultsToDatabase(dicoResult);
                  dicoResult.Clear();
                  count = 0;
                }

                if (saveToFile && count % numberOfItem == 0)
                {
                  ulong fileNumber = fileCount * numberOfItem;
                  RecordResultsToFile(dicoResult, fileNumber);
                  fileCount++;
                  dicoResult.Clear();
                }

                count++;
                string ntlm = FunctionsCrypto.Ntlm(alphabet[i].ToString() + alphabet[j].ToString() + alphabet[k].ToString() + alphabet[l].ToString() + alphabet[m].ToString());
                display($"{alphabet[i]}{alphabet[j]}{alphabet[k]}{alphabet[l]}{alphabet[m]} = {ntlm}");
                if (addToListe)
                {
                  dicoResult.Add($"{alphabet[i]}{alphabet[j]}{alphabet[k]}{alphabet[l]}{alphabet[m]}", ntlm);
                }
              }
            }
          }
        }
      }

      // ? NTLM calculated so far with 5 characters

      display(string.Empty);
      display($"There are {count} NTLM hash calculated.");
      display(string.Empty);
      display("Press any key to exit:");
      Console.ReadKey();
    }

    private static void RecordResultsToFile(Dictionary<string, string> dico, ulong fileCount)
    {
      try
      {
        using (StreamWriter sw = new StreamWriter($"NTLM-{fileCount}.txt"))
        {
          foreach (var item in dico)
          {
            sw.WriteLine($"{item.Key}-{item.Value}");
          }
        }
      }
      catch (Exception exception)
      {
        Console.WriteLine($"error while tryingto write result to a file: {exception.Message}");
        throw;
      }
    }

    private static void RecordResultsToDatabase(Dictionary<string, string> dico)
    {
      // save dico to DB to be implemented
      //DataTable table = new DataTable();
      //table = GetTable();
      //foreach (var item in dico)
      //{
      //  table.Rows.Add(item.Key, item.Value);
      //}

      //Insert(table, "InsertNTLM", "@tbNtlmHashTable");

      List<ModelNtlm> objectNtlmList = new List<ModelNtlm>();
      foreach (var item in dico)
      {
        var oneHash = new ModelNtlm()
        {
          Code = item.Key,
          NtlmHash = item.Value
        };

        objectNtlmList.Add(oneHash);
      }

      ModelNtlm ntlmModel = new ModelNtlm();
      ntlmModel.InsertMassiveData(objectNtlmList);

    }

    public static void ReadFile(string fileName = "")
    {
      try
      {
        DataTable table = new DataTable();
        table = GetTable();
        //using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + fileName))
        //{
        //  string line;
        //  int i = 1;
        //  while ((line = sr.ReadLine()) != null)
        //  {
        //    table.Rows.Add(i, line);
        //    Console.WriteLine(line);
        //    i++;
        //  }
        //}
        //Insert datatable to sql Server
        Insert(table, "InsertCountries", "@dtCountry");
      }
      catch (Exception exception)
      {
        // Let the user know what went wrong.
        Console.WriteLine("The file could not be read:");
        Console.WriteLine(exception.Message);
      }

      Console.WriteLine("Press any key to exit:");
      Console.ReadKey();
    }

    /// <summary>This example method generates a DataTable.</summary>
    static DataTable GetTable()
    {
      DataTable table = new DataTable();
      //table.Columns.Add("idNtlm", typeof(int));
      table.Columns.Add("Code", typeof(string));
      table.Columns.Add("NtlmHash", typeof(string));
      return table;
    }

    [SuppressMessage("Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "<En attente>")]
    static void Insert(DataTable dtData, string storedProcedureName, string dataTableName)
    {
      SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MSI;Initial Catalog=NTLM;Integrated Security=True");
      SqlCommand cmd = new SqlCommand(storedProcedureName, con)
      {
        CommandType = CommandType.StoredProcedure
      };
      cmd.Parameters.AddWithValue(dataTableName, dtData);
      cmd.Connection = con;
      try
      {
        con.Open();
        cmd.ExecuteNonQuery();
        Console.WriteLine("Records inserted successfully!");
      }
      catch (Exception exception)
      {
        Console.WriteLine($"exception : {exception.Message}");
      }
      finally
      {
        con.Close();
        con.Dispose();
      }
    }
  }
}
