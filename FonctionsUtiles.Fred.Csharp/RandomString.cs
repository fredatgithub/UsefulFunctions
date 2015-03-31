namespace FonctionsUtiles.Fred.Csharp
{
  class RandomString
  {
    public int NumberOfCharacter { get; set; }
    public string RndString { get; set; }

    private char[] UpperCaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    private char[] LowerCaseCharacters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    private char[] NumericCharacters = "0123456789".ToCharArray();
    private char[] SpecialCharacters = ",.;:?!/@#$%^&()=+*-_{}[]|~".ToCharArray();
    private char[] ForbiddenCharacters = new char[26 + 26 + 10 + 26]; // max size

    public RandomString(int numberOfCharacter)
    {
      // TODO to be implemented
    }

    public static string Generate()
    {
      string result = string.Empty;

      return result;
    }
  }
}