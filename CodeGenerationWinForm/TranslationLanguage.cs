namespace CodeGenerationWinForm
{
  public enum TranslationLanguage
  {
    NoTranslation = 0,
    ToFrench = 1,
    ToEnglish = 2,
    ToBothFrenchAndEnglish = 4,
    All = ToFrench | ToEnglish
    //ToBothFrenchAndEnglish = ToFrench & ToEnglish
  }
}