using System;
using System.Collections.Generic;
using Xunit;

namespace RepeatCounterNS
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CounterRepeats_singleLetter()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("1", test.CounterRepeats("a", "a"));
    }
    [Fact]
    public void CounterRepeats_singleCharacterIn_sentence()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("3", test.CounterRepeats("a", "a  b a c a"));
    }
    [Fact]
    public void CounterRepeats_singleWord()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("1", test.CounterRepeats("hello", "hello"));
    }
    [Fact]
    public void CounterRepeats_singleWordinSentence()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("1", test.CounterRepeats("cat", "I am not a cat person"));
    }
  }
}
