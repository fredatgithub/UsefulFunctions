using System;
using System.Net;
using System.Text;

namespace FonctionsUtiles.Fred.Csharp
{
  public class FunctionsInternet
  {
    public static string Manifest()
    {
      const string newLine = "\n";
      StringBuilder result = new StringBuilder();
      result.Append(newLine + "Name= FonctionsUtiles.Fred.Csharp" + newLine);
      result.Append("Version= 1.0.0.0" + newLine);
      result.Append("Method= bool GetWebClientBinaries(string url = \"http://www.google.com/\", string fileName = \"untitled-file.pdf\")" + newLine);
      
      result.Append("Method= " + newLine);
      result.Append("Method= " + newLine);
      return result.ToString();
    }

    public static bool GetWebClientBinaries(string url = "http://www.google.com/",
      string fileName = "untitled-file.pdf")
    {
      WebClient client = new WebClient();
      bool result = false;
      // set the user agent to IE6
      client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.0.3705;)");
      try
      {
        client.DownloadFile(url, fileName);
        result = true;
      }
      catch (WebException)
      {
        result = false;
      }
      catch (NotSupportedException)
      {
        result = false;
      }

      return result;
    }
  }
}