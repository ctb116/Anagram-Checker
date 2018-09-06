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
      return _wordList;
    }

    public List <string> AnagramCheck()
    {
      char [] wordArray = AnagramChecker.SplitWord(_word);
      Array.Sort(wordArray);
      string sortedWord = new string(wordArray);
      string sortedWordInWordList = "";
      List <string> AnagramMatch = new List <string>();
      for(int i = 0; i < _wordList.Count; i++)
      {
        char [] wordListArray = AnagramChecker.SplitWord(_wordList[i]);
        Array.Sort(wordListArray);
        sortedWordInWordList = new string(wordListArray);

        if (sortedWordInWordList.Equals(sortedWord) == true)
        {
          AnagramMatch.Add(_wordList[i]);
        }
      }
      return AnagramMatch;
    }

    public static char[] SplitWord(string word)
    {
      char[] wordArray = word.ToCharArray();
      return wordArray;
    }
  }
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word");
      string firstWord = Console.ReadLine();
      Console.WriteLine("Enter multiple words, seperated by spaces, to see if any of them are anagrams to your first word.");
      string words = Console.ReadLine();
      //"E" -> string
      //'E' -> char
      string[] wordArray = words.Split(' ');
      
      List <string> wordList = new List <string>();
      foreach(string item in wordArray)
      {
        wordList.Add(item);
      }

      AnagramChecker mycheck = new AnagramChecker(firstWord, wordList);

      List <string> result = mycheck.AnagramCheck();
      Console.WriteLine("These words are anagrams of your first word ");
      foreach (string word in result)
      {
        Console.WriteLine(word);
      }
    }
  }
}
