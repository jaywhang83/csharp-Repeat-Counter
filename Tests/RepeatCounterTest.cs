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

  }
}
