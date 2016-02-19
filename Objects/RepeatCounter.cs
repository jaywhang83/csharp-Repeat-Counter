using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace RepeatCounterNS
{
  public class RepeatCounter
  {
    public string CountRepeats(string word, string sentence)
    {
      if (!String.IsNullOrEmpty(word) && !String.IsNullOrEmpty(sentence))
      {
        string[] wordArray = sentence.ToLower().Split(' ');

        int counter = 0;
        for(int i = 0; i < wordArray.Length; i++)
        {
          if (String.Equals(Regex.Replace(wordArray[i], @"[\W\d-]", ""), word.ToLower()) == true)
          {
            counter++;
          }
        }
        if (counter == 0)
        {
          return "Match not found.";
        }
        return word + " appears " + counter.ToString() + " time/times in this sentence.";
      }
      else
      {
        return "Inputs cannot be empty. Please enter a word and/or sentence.";
      }
    }
  }
}
