using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace RepeatCounterNS
{
  public class RepeatCounter
  {
    public string CounterRepeats(string word, string sentence)
    {
      if (!String.IsNullOrEmpty(word) && !String.IsNullOrEmpty(sentence))
      {
        string[] wordArray = sentence.ToLower().Split(' ');

        int counter = 0;
        for(int i = 0; i < wordArray.Length; i++)
        {
          if (wordArray[i] == word.ToLower())
          {
            Console.Write(wordArray[i]);
            counter++;
          }
        }
        return counter.ToString();
      }
      else
      {
        return "Inputs cannot be empty. Please enter a word and/or sentence";
      }

    }
  }
}
