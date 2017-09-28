﻿using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortFunc = FonctionsUtiles.Fred.Csharp.FunctionsSort;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsSort
  {
    [TestMethod]
    public void TestMethod_Buble_Sort_list()
    {
      List<int> source = new List<int> {9, 8, 7 };
      List<int> expected = new List<int> { 7, 8, 9 };
      List<int> result = SortFunc.BubbleSort(source);
      for (int i = 0; i < result.Count; i++)
      {
        Assert.AreEqual(expected[i], result[i]);
      }
    }

    [TestMethod]
    public void TestMethod_Buble_Sort_empty_list()
    {
      List<int> source = new List<int> ();
      List<int> expected = new List<int> ();
      List<int> result = SortFunc.BubbleSort(source);
      for (int i = 0; i < result.Count; i++)
      {
        Assert.AreEqual(expected[i], result[i]);
      }
    }

    [TestMethod]
    public void TestMethod_Buble_Sort_one_element_list()
    {
      List<int> source = new List<int> { 9 };
      List<int> expected = new List<int> { 9 };
      List<int> result = SortFunc.BubbleSort(source);
      for (int i = 0; i < result.Count; i++)
      {
        Assert.AreEqual(expected[i], result[i]);
      }
    }

    [TestMethod]
    public void TestMethod_Buble_Sort_several_same_element_list()
    {
      List<int> source = new List<int> { 9, 9, 9 };
      List<int> expected = new List<int> { 9, 9, 9 };
      List<int> result = SortFunc.BubbleSort(source);
      for (int i = 0; i < result.Count; i++)
      {
        Assert.AreEqual(expected[i], result[i]);
      }
    }

    [TestMethod]
    public void TestMethod_Buble_Sort_already_sorted_list()
    {
      List<int> source = new List<int> ();
      List<int> expected = new List<int> ();
      for (int i = 0; i < 10000000; i++)
      {
        source.Add(i);
        expected.Add(i);
      }
      
      List<int> result = SortFunc.BubbleSort(source);
      for (int i = 0; i < result.Count; i++)
      {
        Assert.AreEqual(expected[i], result[i]);
      }
    }

    [TestMethod]
    public void TestMethod_Buble_Sort_random_element_list()
    {
      List<int> source = new List<int>();
      List<int> expected = new List<int>();
      RandomNumberGenerator rnd = RandomNumberGenerator.Create();
      for (int i = 0; i < 10000000; i++)
      {
        rnd = RandomNumberGenerator.Create();
        source.Add(int.Parse(rnd));
        expected.Add(i);
      }

      List<int> result = SortFunc.BubbleSort(source);
      for (int i = 0; i < result.Count; i++)
      {
        Assert.AreEqual(expected[i], result[i]);
      }
    }
  }
}