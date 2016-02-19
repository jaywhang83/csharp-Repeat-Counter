using System;
using System.Collections.Generic;
using Xunit;

namespace RepeatCounterNS
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CounterRepeats_singleletter()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("1", test.CounterRepeats("a", "a"));
    }
    [Fact]
    public void CounterRepeats_singleCharacterInaWord()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("3", test.CounterRepeats("a", "a  b a c a"));
    }
  }
}
