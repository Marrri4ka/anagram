using System;
using System.Collections.Generic;

namespace Anagram.Models
{
 public class Word
 {
   private string _mainWord;
   private string[] _wordList;

   public Word (string mainWord, string wordList) //cons
   {
     _mainWord = mainWord;
     _wordList = wordList.Split(", ");
   }

   public string GetMainWord()
   {
     return _mainWord;
   }

   public string[] GetWordList()
   {
     return _wordList;
   }

   public List<string> GetAnagram()
   {
     List<string> output = new List<string>{};
     char[] mainCharArr = _mainWord.ToCharArray();
     Array.Sort(mainCharArr);
     string sortedMainWord = String.Join ("", mainCharArr);
     for (int i = 0; i < _wordList.Length; i++)
     {
       char[] testCharArr = _wordList[i].ToCharArray();
       Array.Sort(testCharArr);
       string sortedTestWord = String.Join("",testCharArr);
       if(sortedMainWord == sortedTestWord)
       {
         output.Add(_wordList[i]);
       }
     }
     return output;
   }
 }
}
