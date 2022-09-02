namespace FonctionsUtiles.Fred.Csharp.Constants
{
  /// <summary>
  /// Constant class that defines lengths of common fields.
  /// </summary>
  public static class CommonFieldLength
  {
    /// <summary>
    /// The length of a label field.
    /// </summary>
    public const int Label = 255;

    /// <summary>
    /// The length of a comments field.
    /// </summary>
    public const int Comments = 8000;

    /// <summary>
    /// The length of a node path in structure (450 means depth 40 levels).
    /// </summary>
    public const int Path = 450;

    /// <summary>
    /// The length of a hash field.
    /// </summary>
    public const int Hash = 255;
  }
}
