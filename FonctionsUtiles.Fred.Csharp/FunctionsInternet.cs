using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;

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
      catch (WebException)
      {
        // WebException.Status holds useful information
        //Console.WriteLine(we.Message + "\n" + we.Status.ToString());
      }
      catch (NotSupportedException)
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


    public static bool IsNetworkLikelyAvailable()
    {
      return NetworkInterface
        .GetAllNetworkInterfaces()
        .Any(x => x.OperationalStatus == OperationalStatus.Up);
    }

    public static bool IsInternetConnected()
    {
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.google.fr");
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

    //public static async Task<string> Get(string url)
    //{
    //  string responseStr = null;
    //  //HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

    //  //using (var response = await request.GetResponseAsync() as HttpWebResponse)
    //  //{
    //  //  var reader = new StreamReader(response.GetResponseStream());
    //  //  responseStr = reader.ReadToEnd();
    //  //}

    //  return responseStr;
    //}

    public static string SubstringHtml(string stringValue, int length)
    {
      // TODO add unit tests for this method
      var regexAllTags = new Regex(@"<[^>]*>");
      var regexIsTag = new Regex(@"<|>");
      var regexOpen = new Regex(@"<[^/][^>]*>");
      var regexClose = new Regex(@"</[^>]*>");
      var regexAttribute = new Regex(@"<[^ ]*");

      int necessaryCount = 0;

      if (regexAllTags.Replace(stringValue, "").Length <= length)
      {
        return stringValue;
      }

      string[] split = regexAllTags.Split(stringValue);
      string counter = "";
      foreach (string item in split)
      {
        if (counter.Length < length && counter.Length + item.Length >= length)
        {
          necessaryCount = stringValue.IndexOf(item, counter.Length) + item.Substring(0, length - counter.Length).Length;
          break;
        }
        counter += item;
      }

      var x = regexIsTag.Match(stringValue, necessaryCount);
      if (x.Value == ">")
      {
        necessaryCount = x.Index + 1;
      }

      string subs = stringValue.Substring(0, necessaryCount);
      var openTags = regexOpen.Matches(subs);
      var closeTags = regexClose.Matches(subs);

      List<string> OpenTags = new List<string>();
      foreach (var item in openTags)
      {
        string trans = regexAttribute.Match(item.ToString()).Value;

        if (trans.Last() == '>')
        {
          trans = "</" + trans.Substring(1, trans.Length - 1);
        }
        else
        {
          trans = "</" + trans.Substring(1, trans.Length - 1) + ">";
        }

        OpenTags.Add(trans);
      }

      foreach (Match close in closeTags)
      {
        OpenTags.Remove(close.Value);
      }

      for (int i = OpenTags.Count - 1; i >= 0; i--)
      {
        subs += OpenTags[i];
      }

      return subs;
    }
  }
}