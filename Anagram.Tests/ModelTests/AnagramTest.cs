using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramCheckerTest
  {
    [TestMethod]
    public void Anagram_Constructor()
    {
      string word = "bread";
      List <string> wordList = new List <string>{ "beard" };
      AnagramChecker checker = new AnagramChecker(word, wordList);

      Assert.AreEqual("bread", checker.getWord());
      CollectionAssert.AreEqual(new List <string> {"beard"}, checker.getWordList());
    }
  }
}
