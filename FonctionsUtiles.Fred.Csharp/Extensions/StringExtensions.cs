using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FonctionsUtiles.Fred.Csharp.Extensions
{
  public static class StringExtensions
  {
    /// <summary>
    /// Truncates the specified text.
    /// </summary>
    /// <param name="text">The text to truncate.</param>
    /// <param name="keep">The number of characters to keep.</param>
    /// <param name="ellipsis">The ellipsis string to use when truncating. (Default ...)</param>
    /// <returns>
    /// A truncate string.
    /// </returns>
    public static string Truncate(this string text, int keep, string ellipsis = "...")
    {
      if (string.IsNullOrEmpty(text))
      {
        return string.Empty;
      }

      if (string.IsNullOrEmpty(ellipsis))
      {
        ellipsis = string.Empty;
      }

      if (text.Length <= keep)
      {
        return text;
      }

      if (text.Length <= keep + ellipsis.Length || keep < ellipsis.Length)
      {
        return text.Substring(0, keep);
      }

      return string.Concat(text.Substring(0, keep - ellipsis.Length), ellipsis);
    }

    /// <summary>
    /// Indicates whether the specified String object is null or an empty string
    /// </summary>
    /// <param name="item">A String reference</param>
    /// <returns>
    ///     <c>true</c> if is null or empty; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsNullOrEmpty(this string item)
    {
      return string.IsNullOrEmpty(item);
    }

    /// <summary>
    /// Indicates whether a specified string is null, empty, or consists only of white-space characters
    /// </summary>
    /// <param name="item">A String reference</param>
    /// <returns>
    ///      <c>true</c> if is null or empty; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsNullOrWhiteSpace(this string item)
    {
      if (item == null)
        return true;

      for (int i = 0; i < item.Length; i++)
        if (!char.IsWhiteSpace(item[i]))
          return false;

      return true;
    }

    /// <summary>
    /// Determines whether the specified string is not <see cref="IsNullOrEmpty"/>.
    /// </summary>
    /// <param name="value">The value to check.</param>
    /// <returns>
    ///   <c>true</c> if the specified <paramref name="value"/> is not <see cref="IsNullOrEmpty"/>; otherwise, <c>false</c>.
    /// </returns>
    public static bool HasValue(this string value)
    {
      return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    /// Converts the specified <paramref name="text"/> into spaced words.
    /// </summary>
    /// <param name="text">The text to convert.</param>
    /// <returns>The text with a space before every capital letter</returns>
    public static string ToTitle(this string text)
    {
      if (string.IsNullOrWhiteSpace(text) || text.Length < 2)
        return text;

      var words = Regex.Matches(text, "([A-Z][a-z]*)|([0-9]+)") as IEnumerable<Match>;
      return string.Join(" ", words.Select(w => w.Value));
    }

    public static bool ContainsIgnoreCase(this string value, string containsValue)
    {
      return value.IndexOf(containsValue, System.StringComparison.OrdinalIgnoreCase) >= 0;
    }
  }
}
