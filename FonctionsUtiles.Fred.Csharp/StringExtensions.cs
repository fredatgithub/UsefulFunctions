/*
The MIT License(MIT)
Copyright(c) 2015 Freddy Juhel
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using System.Linq;

namespace FonctionsUtiles.Fred.Csharp
{
  public static class StringExtensions
  {
    public static string ToCamelCase(this string elasticId)
    {
      if (elasticId == string.Empty)
      {
        return string.Empty;
      }

      var idParts = elasticId
                      .Split('_')
                      .Select(part => part.Substring(0, 1).ToUpper() + part.Substring(1));
      return string.Join(string.Empty, idParts);
    }


    public static string Uncapitalize(this string str)
    {
      if (str == string.Empty)
      {
        return string.Empty;
      }

      return str.Substring(0, 1).ToLower() + str.Substring(1);
    }

    public static string ToCodeSummary(this string description, int indentSpaces)
    {
      var prefix = new string(' ', indentSpaces) + "/// ";
      var lines = description.Split('\n');
      var indentedNextLines = lines.Skip(1).Select(s => Environment.NewLine + prefix + s);
      return lines[0] + string.Join(string.Empty, indentedNextLines);
    }

    public static ClrTypeCategory ClrTypeCategory(this string netType)
    {
      switch (netType)
      {
        case "int":
        case "double":
        case "bool":
          return Csharp.ClrTypeCategory.Primitive;
        case "string":
          return Csharp.ClrTypeCategory.String;
        case "IEnumerable<string>":
          return Csharp.ClrTypeCategory.StringList;
        default:
          return Csharp.ClrTypeCategory.Enum;
      }
    }
  }

  public enum ClrTypeCategory
  {
    None,
    Primitive,
    Enum,
    String,
    StringList
  }
}