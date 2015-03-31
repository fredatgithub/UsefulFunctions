namespace FonctionsUtiles.Fred.Csharp
{
  class RandomString
  {
    public int NumberOfCharacter { get; set; }
    public string RndString { get; set; }

    private char[] UpperCaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    private char[] LowerCaseCharacters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    private char[] DigitCharacters = "0123456789".ToCharArray();
    private char[] SpecialCharacters = ",.;:?!/@#$%^&()=+*-_{}[]|~".ToCharArray();
    private char[] ForbiddenCharacters = new char[26 + 26 + 10 + 26]; // max size
    private char[] SearchedCharacters = new char[26 + 26 + 10 + 26]; // max size

    public RandomString(char[] forbiddenCharacters, int numberOfCharacter = 1,
      RandomCharacters rdnChar = RandomCharacters.LowerCase)
    {
      // TODO to be implemented
      int numberOfCharactersToPickFrom = (int)rdnChar;
      SearchedCharacters = new char[numberOfCharactersToPickFrom];
      switch (rdnChar)
      {
        case RandomCharacters.LowerCase:
          FillSearchedCharacters(LowerCaseCharacters);
          break;
        case RandomCharacters.UpperCase:
          FillSearchedCharacters(UpperCaseCharacters);
          break;
        case RandomCharacters.Digit:
          FillSearchedCharacters(DigitCharacters);
          break;
        case RandomCharacters.SpecialCharacter:
          FillSearchedCharacters(SpecialCharacters);
          break;
        case RandomCharacters.UpperLower:
          FillSearchedCharacters(UpperCaseCharacters);
          FillSearchedCharacters(LowerCaseCharacters);
          break;
        
        default:
          break;
      }
    }

    private void FillSearchedCharacters(char[] source)
    {

    }

    public static string Generate()
    {
      string result = string.Empty;

      return result;
    }
  }

  public enum RandomCharacters
  {
    LowerCase = 2,
    UpperCase = 4,
    Digit = 6,
    SpecialCharacter = 8,
    UpperLower = LowerCase & UpperCase,
    LowerDigit = LowerCase & Digit,
    UpperDigit = UpperCase & Digit,
    UpperLowerDigit = UpperLower & Digit,
    LowerSpecialChar = LowerCase & SpecialCharacter,
    UpperSpecialChar = UpperCase & SpecialCharacter,
    DigitSpecialChar = Digit & SpecialCharacter
  }
}