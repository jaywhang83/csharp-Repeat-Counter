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
      string[] wordArray = sentence.Split(' ');
      int counter = 0;
      for(int i = 0; i < wordArray.Length; i++)
      {
        if (wordArray[i] == word)
        {
          Console.Write(wordArray[i]);
          counter++;
        }
      }
      return counter.ToString();
    }
  }
}
