using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class AnagramChecker
  {
    private string _word;
    private List <string> _wordList;

    public AnagramChecker(string word, List <string> wordList)
    {
      _word = word;
      _wordList = wordList;
    }

    public string getWord()
    {
      return _word;
    }

    public List<string> getWordList()
    {
      return new List<string>(_wordList);
    }

    public List <string> AnagramCheck()
    {
      return new List <string>();
    }
  }
}
