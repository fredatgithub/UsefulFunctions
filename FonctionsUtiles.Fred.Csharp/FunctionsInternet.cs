using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
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

    public static string GetWebClientString(string url = "http://www.google.com/")
    {
      // create a new instance of WebClient
      WebClient client = new WebClient();
      string result = string.Empty;
      // set the user agent to IE6
      client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.0.3705;)");
      try
      {
        // actually execute the GET request
        string ret = client.DownloadString(url);

        // ret now contains the contents of the webpage
        //Console.WriteLine("First 256 bytes of response: " + ret.Substring(0, 265));
        result = ret;
      }
      catch (WebException we)
      {
        // WebException.Status holds useful information
        //Console.WriteLine(we.Message + "\n" + we.Status.ToString());
      }
      catch (NotSupportedException ne)
      {
        // other errors
        //Console.WriteLine(ne.Message);
      }

      return result;
    }

    public static bool IsOnenNetworkCardAvailable()
    {
      NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
      bool networkIsAvailable = false;
      foreach (NetworkInterface nic in nics)
      {
        if ((nic.NetworkInterfaceType != NetworkInterfaceType.Loopback && nic.NetworkInterfaceType != NetworkInterfaceType.Tunnel) &&
            nic.OperationalStatus == OperationalStatus.Up)
        {
          networkIsAvailable = true;
        }
      }

      return networkIsAvailable;
    }


    public bool IsNetworkLikelyAvailable()
    {
      return NetworkInterface
        .GetAllNetworkInterfaces()
        .Any(x => x.OperationalStatus == OperationalStatus.Up);
    }

    private bool IsInternetConnected()
    {
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.google.fr");
      try
      {
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }
  }
}