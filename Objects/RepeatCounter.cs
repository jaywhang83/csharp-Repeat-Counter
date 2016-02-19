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
          // Console.WriteLine(wordArray[i]);
          // Console.WriteLine("replaced: " + Regex.Replace(wordArray[i], @"[\W\d-]", ""));
          if (String.Equals(Regex.Replace(wordArray[i], @"[\W\d-]", ""), word.ToLower()) == true)
          {
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
