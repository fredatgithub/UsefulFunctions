using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

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

    public static IList<string> ToCsvList(this string csv)
    {
      return csv.Split(',').Select(p => p.Trim()).ToList();
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

    /// <summary>
    /// Formats a string to an invariant culture.
    /// </summary>
    /// <param name="format">The format string.</param>
    /// <param name="values">The objects.</param>
    /// <returns>string formatted using CultureInfo.InvariantCulture.</returns>
    public static string Invariant(string format, params object[] values)
    {
      return string.Format(CultureInfo.InvariantCulture, format, values);
    }

    /// <summary>
    /// Formats a string to the current culture.
    /// </summary>
    /// <param name="format">The format string.</param>
    /// <param name="values">The objects.</param>
    /// <returns>string formatted using CultureInfo.CurrentCulture.</returns>
    public static string Current(string format, params object[] values)
    {
      return string.Format(CultureInfo.CurrentCulture, format, values);
    }

    /// <summary>
    /// Adds item to the list if not null.
    /// </summary>
    /// <typeparam name="T">List type.</typeparam>
    /// <param name="list">The list object.</param>
    /// <param name="item">The item entry.</param>
    public static void AddIfNotNull<T>(this List<T> list, T item)
    {
      #region parameters

      if (list == null)
      {
        throw new ArgumentNullException(nameof(list));
      }

      #endregion parameters

      if (item != null)
      {
        list.Add(item);
      }
    }

    /// <summary>
    /// Adds item to the list if not null.
    /// </summary>
    /// <typeparam name="T">List type.</typeparam>
    /// <param name="list">The list object.</param>
    /// <param name="items">The items entry.</param>
    public static void AddIfAny<T>(this List<T> list, List<T> items)
    {
      #region parameters

      if (list == null)
      {
        throw new ArgumentNullException(nameof(list));
      }

      #endregion parameters

      if (items == null)
      {
        return;
      }

      if (items.Any())
      {
        list.AddRange(items);
      }
    }

    /// <summary>
    /// Verify if list is null or empty.
    /// </summary>
    /// <typeparam name="T">List Type.</typeparam>
    /// <param name="list">The list object.</param>
    /// <returns>True if null or empty.</returns>
    public static bool IsNullOrEmpty<T>(this List<T> list)
    {
      if (list == null)
      {
        return true;
      }

      return !list.Any();
    }

    /// <summary>
    /// Translates enum value to text from StringValue attribute in declaration.
    /// </summary>
    /// <param name="enumeration">Enum object.</param>
    /// <returns>Translated value.</returns>
    public static string Text(this Enum enumeration)
    {
      if (enumeration == null)
      {
        throw new ArgumentNullException(nameof(enumeration));
      }

      MemberInfo[] memberInfo = enumeration.GetType().GetMember(enumeration.ToString());

      if (memberInfo != null && memberInfo.Length > 0)
      {
        object[] attributes = memberInfo[0].GetCustomAttributes(typeof(StringValueAttribute), false);

        if (attributes != null && attributes.Length > 0)
        {
          return ((StringValueAttribute)attributes[0]).StringValue;
        }
      }

      return enumeration.ToString();
    }

    /// <summary>
    /// Translates enum value to text from int value.
    /// </summary>
    /// <param name="enumeration">Enum object.</param>
    /// <returns>Translated value.</returns>
    public static int ToInt(this Enum enumeration)
    {
      return enumeration.GetValue<int>();
    }

    /// <summary>
    /// Translates enum value to decimal.
    /// </summary>
    /// <param name="enumeration">Enum object.</param>
    /// <returns>Translated value.</returns>
    public static decimal ToDecimal(this Enum enumeration)
    {
      return decimal.One * enumeration.ToInt();
    }

    /// <summary>
    /// Translates enum value to type in declaration.
    /// </summary>
    /// <typeparam name="T">Expected type for conversion.</typeparam>
    /// <param name="enumeration">Enum object.</param>
    /// <returns>Translated value.</returns>
    public static T GetValue<T>(this Enum enumeration)
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
      return (T)(object)enumeration;
    }

    /// <summary>
    /// Makes a distinct by a field.
    /// </summary>
    /// <typeparam name="T">Generic type of the collection.</typeparam>
    /// <param name="list">The list with source data.</param>
    /// <param name="propertySelector">The property selector.</param>
    /// <returns>Collection with distinct values.</returns>
    public static IEnumerable<T> DistinctBy<T>(this IEnumerable<T> list, Func<T, object> propertySelector)
    {
      return list.GroupBy(propertySelector).Select(x => x.First());
    }

    /// <summary>
    /// Wraps the ForEach method on an IEnumerable.
    /// </summary>
    /// <typeparam name="T">Type of the elements in the list.</typeparam>
    /// <param name="list">IEnumerable to iterate on.</param>
    /// <param name="action">The System.Action`1 delegate to perform on each element of the IEnumerable.</param>
    public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
    {
      #region check parameters
      if (list == null)
      {
        throw new ArgumentNullException(nameof(list));
      }

      if (action == null)
      {
        throw new ArgumentNullException(nameof(action));
      }
      #endregion

      foreach (T element in list)
      {
        action(element);
      }
    }

    /// <summary>
    /// Combines select and distinct operations on a collection.
    /// </summary>
    /// <typeparam name="TSource">Type of the elements in the list.</typeparam>
    /// <typeparam name="TResult">Type of the value returned by the selector.</typeparam>
    /// <param name="list">Set of values to transform.</param>
    /// <param name="selector">Transformation function to apply to each element.</param>
    /// <returns>A distinct list of elements resulted from the selection function.</returns>
    public static IEnumerable<TResult> SelectDistinct<TSource, TResult>(this IEnumerable<TSource> list, Func<TSource, TResult> selector)
    {
      #region check parameters
      if (list == null)
      {
        throw new ArgumentNullException(nameof(list));
      }
      #endregion

      return list.Select(selector).Distinct();
    }

    /// <summary>
    /// Performs the specified action on each element of the IEnumerable, using the next element.
    /// </summary>
    /// <typeparam name="T">Type of the elements in the list.</typeparam>
    /// <param name="list">IEnumerable to iterate on.</param>
    /// <param name="action">The System.Action`1 delegate to perform on each element (but the last one) of the IEnumerable.
    /// Takes into argument the element to iterate on, and the next one in the list.</param>
    public static void ForEachWithNext<T>(this IEnumerable<T> list, Action<T, T> action)
    {
      #region check parameters
      if (list == null)
      {
        throw new ArgumentNullException(nameof(list));
      }

      if (action == null)
      {
        throw new ArgumentNullException(nameof(action));
      }

      if (!list.Any())
      {
        return;
      }
      #endregion

      T[] array = list.ToArray();

      for (int i = 0; i < array.Length; i++)
      {
        if (i == array.Length - 1)
        {
          // Do nothing for last element since it has no next element.
          break;
        }

        // Execute action for current element and next element
        action(array[i], array[i + 1]);
      }
    }

    /// <summary>
    /// Performs the specified action on each element of the IEnumerable, using the next element.
    /// </summary>
    /// <typeparam name="T">Type of the elements in the list.</typeparam>
    /// <param name="list">IEnumerable to iterate on.</param>
    /// <param name="action">The System.Action`1 delegate to perform on each element (but the last one) of the IEnumerable.
    /// Takes into argument the element to iterate on, and the next one in the list.</param>
    /// <param name="actionForLast">The System.Action`1 delegate to perform on the last element of the IEnumerable.</param>
    public static void ForEachWithNext<T>(this IEnumerable<T> list, Action<T, T> action, Action<T> actionForLast)
    {
      #region check parameters
      if (list == null)
      {
        throw new ArgumentNullException(nameof(list));
      }

      if (action == null)
      {
        throw new ArgumentNullException(nameof(action));
      }

      if (actionForLast == null)
      {
        throw new ArgumentNullException(nameof(actionForLast));
      }

      if (!list.Any())
      {
        return;
      }
      #endregion

      T[] array = list.ToArray();

      for (int i = 0; i < array.Length; i++)
      {
        if (i == array.Length - 1)
        {
          // Action for last element
          actionForLast(array[i]);
        }

        // Execute action for current element and next element
        action(array[i], array[i + 1]);
      }
    }

    /// <summary>
    /// Joins two collections based on a key selector, and applies an action on each couple from the join operation.
    /// </summary>
    /// <typeparam name="TOuter">Type of the outer collection.</typeparam>
    /// <typeparam name="TInner">Type of the inner collection.</typeparam>
    /// <typeparam name="TKey">Type of the key selector.</typeparam>
    /// <param name="list1">The outer collection.</param>
    /// <param name="list2">The inner collection.</param>
    /// <param name="selector1">The selector for the outer collection.</param>
    /// <param name="selector2">The selector for the inner collection.</param>
    /// <param name="applyAction">The action to apply on each joined couple.</param>
    /// <returns>The collection of matching elements after apply.</returns>
    public static IEnumerable<TOuter> Apply<TOuter, TInner, TKey>(this IEnumerable<TOuter> list1, IEnumerable<TInner> list2, Func<TOuter, TKey> selector1, Func<TInner, TKey> selector2, Action<TOuter, TInner> applyAction)
    {
      return list1.Join(
          list2,
          selector1,
          selector2,
          (x, y) =>
          {
            applyAction(x, y);
            return x;
          })
          .ToList();
    }

    /// <summary>
    /// Joins two collections based on a key selector, and applies an action on each couple from the join operation.
    /// Then it adds elements that do not exist in the outer collection and removes elements that do not exist in the inner collection.
    /// </summary>
    /// <typeparam name="TOuter">Type of the outer collection.</typeparam>
    /// <typeparam name="TInner">Type of the inner collection.</typeparam>
    /// <typeparam name="TKey">Type of the key selector.</typeparam>
    /// <param name="list1">The outer collection.</param>
    /// <param name="list2">The inner collection.</param>
    /// <param name="selector1">The selector for the outer collection.</param>
    /// <param name="selector2">The selector for the inner collection.</param>
    /// <param name="updateAction">The action to apply on each joined couple.</param>
    /// <param name="addAction">The function to create and item to add from an item of the inner list.</param>
    public static void Merge<TOuter, TInner, TKey>(this ICollection<TOuter> list1, IEnumerable<TInner> list2, Func<TOuter, TKey> selector1, Func<TInner, TKey> selector2, Action<TOuter, TInner> updateAction, Func<TInner, TOuter> addAction)
    {
      // Update matching elements
      var matchingElements = list1
          .Apply(
              list2,
              selector1,
              selector2,
              updateAction)
          .ToList();

      // Remove elements not existing in the inner list
      var toRemove = list1.Except(matchingElements).ToList();
      list1.RemoveRange(toRemove);

      // Add elements not existing in the outer list
      var toAdd = list2.Where(x => !matchingElements.Any(y => selector2(x).Equals(selector1(y)))).ToList();
      list1.AddElements(toAdd.Select(addAction));
    }

    /// <summary>
    /// Returns the Cartesian product of two collections.
    /// </summary>
    /// <typeparam name="TLeft">The type of the first collection.</typeparam>
    /// <typeparam name="TRight">The type of the second collection.</typeparam>
    /// <param name="left">The first collection.</param>
    /// <param name="right">The second collection.</param>
    /// <returns>The Cartesian product of the two collections.</returns>
    public static IEnumerable<Tuple<TLeft, TRight>> Cross<TLeft, TRight>(this IEnumerable<TLeft> left, IEnumerable<TRight> right)
    {
      return left.SelectMany(l => right.Select(r => Tuple.Create(l, r)));
    }

    /// <summary>
    /// Splits a list by given batch size elements and returns a list of split batches.
    /// </summary>
    /// <typeparam name="T">Generic list type.</typeparam>
    /// <param name="enumerable">Input list as IEnumerable.</param>
    /// <param name="batchSize">Split list by this value.</param>
    /// <returns>IEnumerable of provided IEnumerable split by given batchSize.</returns>
    public static IEnumerable<IEnumerable<T>> BatchBy<T>(this IEnumerable<T> enumerable, int batchSize = 1000)
    {
      #region check parameters
      if (enumerable == null)
      {
        throw new ArgumentNullException(nameof(enumerable));
      }

      if (batchSize <= 0)
      {
        throw new ArgumentOutOfRangeException(nameof(batchSize), "batchSize must be greater than 0");
      }
      #endregion

      return BatchByIterator(enumerable, batchSize);
    }

    /// <summary>
    /// Splits a list by given batch size elements and returns a list of split batches.
    /// </summary>
    /// <typeparam name="T">Generic list type.</typeparam>
    /// <param name="enumerable">Input list as IEnumerable.</param>
    /// <param name="batchSize">Split list by this value.</param>
    /// <returns>IEnumerable of provided IEnumerable split by given batchSize.</returns>
    private static IEnumerable<IEnumerable<T>> BatchByIterator<T>(this IEnumerable<T> enumerable, int batchSize = 1000)
    {
      using (var enumerator = enumerable.GetEnumerator())
      {
        List<T> list = null;
        while (enumerator.MoveNext())
        {
          if (list == null)
          {
            list = new List<T> { enumerator.Current };
          }
          else if (list.Count < batchSize)
          {
            list.Add(enumerator.Current);
          }
          else
          {
            yield return list;
            list = new List<T> { enumerator.Current };
          }
        }

        if (list?.Count > 0)
        {
          yield return list;
        }
      }
    }

    /// <summary>
    /// Keep only the items that validate the specified predicate.
    /// </summary>
    /// <typeparam name="T">Type of object stored in the collection.</typeparam>
    /// <param name="source">The enumerable on which apply the filter.</param>
    /// <param name="predicate">The specified predicate.</param>
    public static void KeepOnly<T>(this ICollection<T> source, Func<T, bool> predicate)
    {
      if (source == null)
      {
        throw new ArgumentNullException(nameof(source));
      }

      if (predicate != null)
      {
        List<T> itemsToRemove = new List<T>();

        foreach (T item in source)
        {
          if (!predicate.Invoke(item))
          {
            itemsToRemove.Add(item);
          }
        }

        foreach (T item in itemsToRemove)
        {
          source.Remove(item);
        }
      }
    }

    /// <summary>
    /// Adds a range of elements from a collection.
    /// </summary>
    /// <typeparam name="T">Type of object stored in the collection.</typeparam>
    /// <param name="source">The collection to remove the elements from.</param>
    /// <param name="itemsToAdd">The elements to remove.</param>
    public static void AddElements<T>(this ICollection<T> source, IEnumerable<T> itemsToAdd)
    {
      if (source == null)
      {
        throw new ArgumentNullException(nameof(source));
      }

      if (itemsToAdd == null)
      {
        throw new ArgumentNullException(nameof(itemsToAdd));
      }

      itemsToAdd.ToList().ForEach(item => source.Add(item));
    }

    /// <summary>
    /// Removes a range of elements from a collection.
    /// </summary>
    /// <typeparam name="T">Type of object stored in the collection.</typeparam>
    /// <param name="source">The collection to remove the elements from.</param>
    /// <param name="itemsToRemove">The elements to remove.</param>
    public static void RemoveRange<T>(this ICollection<T> source, IEnumerable<T> itemsToRemove)
    {
      if (source == null)
      {
        throw new ArgumentNullException(nameof(source));
      }

      if (itemsToRemove == null)
      {
        throw new ArgumentNullException(nameof(itemsToRemove));
      }

      itemsToRemove.ToList().ForEach(item => source.Remove(item));
    }

    /// <summary>
    /// Add a dictionary into another dictionary. If the key already exists, the value isn't changed.
    /// </summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="source">The source dictionary that will contains both values.</param>
    /// <param name="collection">The collection to append to the source dictionary.</param>
    public static void AddRange<TKey, TValue>(this Dictionary<TKey, TValue> source, Dictionary<TKey, TValue> collection)
    {
      if (source == null)
      {
        throw new ArgumentNullException(nameof(source));
      }

      if (collection == null)
      {
        throw new ArgumentNullException(nameof(collection));
      }

      foreach (var item in collection)
      {
        if (!source.ContainsKey(item.Key))
        {
          source.Add(item.Key, item.Value);
        }
      }
    }

    /// <summary>
    /// Returns a value for the given key. If the key does not exist, returns the resutl of the defaultValue function.
    /// </summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="source">The source dictionary that.</param>
    /// <param name="key">The key.</param>
    /// <param name="defaultValue">A function that returns a value based on the key, if no value is found for the given key.</param>
    /// <returns>The value.</returns>
    public static TValue GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> source, TKey key, Func<TKey, TValue> defaultValue)
    {
      if (source == null)
      {
        throw new ArgumentNullException(nameof(source));
      }

      if (defaultValue == null)
      {
        throw new ArgumentNullException(nameof(defaultValue));
      }

      if (!source.TryGetValue(key, out TValue value))
      {
        value = defaultValue(key);
      }

      return value;
    }

    /// <summary>
    /// Verify if dictionary is null or empty.
    /// </summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="dictionary">The dictionary object.</param>
    /// <returns>True if null or empty.</returns>
    public static bool IsNullOrEmpty<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
    {
      if (dictionary == null)
      {
        return true;
      }

      return !dictionary.Any();
    }
  }

  internal class StringValueAttribute
  {
    public string StringValue { get; protected set; }

    public StringValueAttribute(string value)
    {
      StringValue = value;
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