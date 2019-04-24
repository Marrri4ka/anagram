using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Anagram.Models;


namespace Anagram.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void WordConstructor_CreateInstanceOfWord_HasMainWord()
    {
      string mainWord = "bread";
      string words = "beard, dareb, dreab, one, two, three";
      Word testWord = new Word(mainWord, words);
      Assert.AreEqual(mainWord, testWord.GetMainWord());
    }

    [TestMethod]
    public void WordConstructor_CreateInstanceOfWord_HasWordList()
    {
      string mainWord = "bread";
      string words = "beard, dareb, dreab, one, two, three";
      string[] wordArray = new string[]{"beard", "dareb", "dreab", "one", "two", "three"};
      Word testWord = new Word(mainWord, words);
      CollectionAssert.AreEqual(wordArray, testWord.GetWordList());
    }

    [TestMethod]
    public void GetAnagram_CreateInstanceOfWordAndCallMethod_ReturnAnagrams()
    {
      string mainWord = "bread";
      string words = "beard, dareb, dreab, one, two, three";
      Word testWord = new Word(mainWord, words);
      List<string> expectedOutput = new List<string> {"beard", "dareb", "dreab"};
      List<string> output = testWord.GetAnagram();
      CollectionAssert.AreEqual(expectedOutput, output);
    }
  }
}
