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
      // string[] wordArray = sentence.Split(' ');
      int counter = 0;
      if (word == sentence)
      {
        counter++;
      }
      return counter.ToString();
    }
  }
}
