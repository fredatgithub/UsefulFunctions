using System;

namespace CodeGeneration
{
  class Program
  {
    static void Main()
    {
      Action<string> Display = s => Console.WriteLine(s);
      Display("Generating code for Unit tests in a file");
      //var oneTranslation = TranslationLanguage.ToBothFrenchAndEnglish;
      //new EnumSwitch<TranslationLanguage>(oneTranslation)
      //  .Case(TranslationLanguage.ToFrench, () => Console.WriteLine("french"))
      //.Case(TranslationLanguage.ToEnglish, () => Console.WriteLine("english"))
      //.Default(() =>
      //                                                                       {
      //                                                                         Console.WriteLine("translation not handled: {0}", oneTranslation);
      //                                                                         return true;
      //                                                                       })
      //                                                                       .Execute();
    
      Console.ReadKey();
    }

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
}