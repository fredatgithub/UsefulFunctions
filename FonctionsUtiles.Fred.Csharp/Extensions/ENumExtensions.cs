using System;

namespace FonctionsUtiles.Fred.Csharp.Extensions
{
  public static class ENumExtensions
  {
    public static T ToEnum<T>(this string value)
    {
      return (T)Enum.Parse(typeof(T), value, true);
    }
  }
}
