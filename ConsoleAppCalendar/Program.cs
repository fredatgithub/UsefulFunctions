using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalendar
{
  class Program
  {
    static void Main(string[] args)
    {
      Action<string> display = Console.WriteLine;
      display("Display calendar");
      display("Type exit to quit");
      display("Type Show-Calendar -Month February");
      display("Type Show-Calendar -Month February -Highlighdate 2/14,2/22,2/7,2/20");
      display("");
      var entry = Console.ReadLine();
      display("");
      display(GetCalendar("test"));
      display("Press any key to exit:");
      Console.ReadKey();
    }

    private static string GetCalendar(string order)
    {
      string result = string.Empty;
      result = " Sun   Mon   Tue   Wed   Thu   Fri   Sat" + Environment.NewLine;
      result += "---   ---   ---   ---   ---   ---   ---" + Environment.NewLine;
      result += "  26   27    28    29    30    31     1" + Environment.NewLine;
      result += "   2    3     4     5     6     7     8" + Environment.NewLine;
      result += "   9   10    11    12    13    14    15" + Environment.NewLine;
      result += "  16   17    18    19    20    21    22" + Environment.NewLine;
      result += "  23   24    25    26    27    28    29" + Environment.NewLine;

      return result;
    }
  }
}
