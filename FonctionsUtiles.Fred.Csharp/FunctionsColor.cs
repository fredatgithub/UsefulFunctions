using System;
using System.Drawing;

namespace FonctionsUtiles.Fred.Csharp
{
  public static class FunctionsColor
  {
    public static Color RandomColor()
    {
      var _random = new Random(DateTime.Now.Millisecond);
      return Color.FromArgb(_random.Next(255), _random.Next(255), _random.Next(255));
    }
  }
}
