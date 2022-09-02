namespace FonctionsUtiles.Fred.Csharp.Constants
{
  /// <summary>
  /// Constants class for string format values.
  /// </summary>
  public static class CustomStringFormat
  {
    /// <summary>
    /// String format to be used for displaying dates.
    /// </summary>
    public const string DateFormat = "dd MMM yyyy";

    /// <summary>
    /// String format to be used for displaying dates.
    /// </summary>
    public const string GridDateFormat = "{0:dd MMM yyyy}";

    /// <summary>
    /// String format to be used for display date in filter fields.
    /// </summary>
    public const string FilterDateFormat = "dd/MM/yyyy";

    /// <summary>
    /// String format to be used for displaying dates.
    /// </summary>
    public const string AccessLogDateFormat = "{0:dd MMM yyyy HH:mm}";

    /// <summary>
    /// String format to be used for displaying dates in the consistency check report.
    /// </summary>
    public const string ConsistencyCheckReportDateFormat = "dd MMM yyyy HH:mm";

    /// <summary>
    /// String format to be used for displaying dates in the history event log table.
    /// </summary>
    public const string HistoryEventLogDateFormat = "{0:dd MMM yyyy HH:mm}";

    /// <summary>
    /// String format to be used for displaying dates of the comments.
    /// </summary>
    public const string CommentDisplayDateFormat = "{0:dd MMM yyyy} at {0:HH:mm}";
  }
}
