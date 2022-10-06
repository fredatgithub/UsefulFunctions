using FonctionsUtiles.Fred.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsFiles
  {
    #region Files Methods
    //**************************GenerateUniqueFileName Methods****
    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_true_length_eight()
    {
      string sourceDir = Path.GetTempPath();
      const int expected = 8;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial);
      Assert.AreEqual(result.Length, expected);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_true_length_twelve()
    {
      string sourceDir = Path.GetTempPath();
      const int expected = 12;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial, 8, true, "doc");
      Assert.AreEqual(result.Length, expected);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_true_length_thirteen()
    {
      string sourceDir = Path.GetTempPath();
      const int expected = 13;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial, 8, true, "docx");
      Assert.AreEqual(result.Length, expected);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_false_file_does_not_exist_in_temp_dir()
    {
      string sourceDir = Path.GetTempPath();
      const bool expected = false;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial);
      Assert.AreEqual(File.Exists(Path.Combine(sourceDir, result)), expected);
    }

    [TestMethod]
    public void TestMethod_GenerateUniqueFileName_false_file_does_not_exist_in_document_dir()
    {
      string sourceDir = Environment.SpecialFolder.MyDocuments.ToString();
      const bool expected = false;
      string result = FunctionsString.GenerateUniqueFilename(sourceDir, RandomCharacters.UpperLowerDigitSpecial);
      Assert.AreEqual(File.Exists(Path.Combine(sourceDir, result)), expected);
    }

    #region IsLegalXmlChar
    [TestMethod]
    public void TestMethod_IsLegalXmlChar_true_0x9()
    {
      const char source = (char)0x9;
      const bool expected = true;
      bool result = FunctionsFiles.IsLegalXmlChar(source);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_IsLegalXmlChar_true_0xA()
    {
      const char source = (char)0xA;
      const bool expected = true;
      bool result = FunctionsFiles.IsLegalXmlChar(source);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_IsLegalXmlChar_true_0xD()
    {
      const char source = (char)0xD;
      const bool expected = true;
      bool result = FunctionsFiles.IsLegalXmlChar(source);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_IsLegalXmlChar_char_a()
    {
      const char source = 'a';
      const bool expected = true;
      bool result = FunctionsFiles.IsLegalXmlChar(source);
      Assert.AreEqual(expected, result);
    }
    #endregion IsLegalXmlChar

    [TestMethod]
    public void TestMethod_file_name()
    {
      //GESTION_J_4_backup_2020_10_06_20_00_07_127.diff
      string source = "GESTION_J_4_backup_2020_10_06_20_00_07_127.diff";
      string expected = "J_4";
      var result1 = new FileName(source);
      var result = result1.DatabaseName;
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_Compare_date_later_than()
    {
      //GESTION_J_4_backup_2020_10_06_20_00_07_127.diff
      var source1 = new FileName("GESTION_J_4_backup_2020_10_06_20_00_07_127.diff");
      var source2 = new FileName("GESTION_J_4_backup_2020_10_07_20_00_07_127.diff");
      int expected = -1;
      var result = source1.CompareTo(source2);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_Compare_date_similar()
    {
      //GESTION_J_4_backup_2020_10_06_20_00_07_127.diff
      var source1 = new FileName("GESTION_J_4_backup_2020_10_06_20_00_07_127.diff");
      var source2 = new FileName("GESTION_J_4_backup_2020_10_06_20_00_07_127.diff");
      int expected = 0;
      var result = source1.CompareTo(source2);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_Compare_date_earlier_than()
    {
      //GESTION_J_4_backup_2020_10_06_20_00_07_127.diff
      var source1 = new FileName("GESTION_J_4_backup_2020_10_06_20_00_07_127.diff");
      var source2 = new FileName("GESTION_J_4_backup_2020_10_05_20_00_07_127.diff");
      int expected = 1;
      var result = source1.CompareTo(source2);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_GetTemporaryDirectory()
    {
      var result = FunctionsFiles.CreateTemporaryDirectory();
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void TestMethod_GetRandomFileNames_1()
    {
      int source = 1;
      var result = FunctionsFiles.GetRandomFileNames(source);
      Assert.IsNotNull(result);
      Assert.IsTrue(result.Count == source);
    }

    [TestMethod]
    public void TestMethod_GetRandomFileNames_10()
    {
      int source = 10;
      var result = FunctionsFiles.GetRandomFileNames(source);
      Assert.IsNotNull(result);
      Assert.IsTrue(result.Count == source);
    }

    [TestMethod]
    public void TestMethod_GetRandomFileNames_100()
    {
      int source = 100;
      var result = FunctionsFiles.GetRandomFileNames(source);
      Assert.IsNotNull(result);
      Assert.IsTrue(result.Count == source);
    }

    [TestMethod]
    public void TestMethod_GetRandomFileNames_Test_Randomness()
    {
      int source = 100;
      var result = FunctionsFiles.GetRandomFileNames(source);
      var result2 = FunctionsFiles.GetRandomFileNames(source);
      Assert.IsNotNull(result);
      Assert.IsNotNull(result2);
      Assert.IsTrue(result.Count == source);
      Assert.IsTrue(result2.Count == source);
      CollectionAssert.AreNotEqual(result, result2);
    }

    #endregion Files Methods
  }
}