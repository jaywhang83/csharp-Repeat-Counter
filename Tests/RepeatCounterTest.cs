using System;
using System.Collections.Generic;
using Xunit;

namespace RepeatCounterNS
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_singleLetter()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("a appears 1 time/times in this sentence.", test.CountRepeats("a", "a"));
    }
    [Fact]
    public void CountRepeats_singleCharacterIn_sentence()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("a appears 3 time/times in this sentence.", test.CountRepeats("a", "a b a c a"));
    }
    [Fact]
    public void CountRepeats_singleWord()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("hello appears 1 time/times in this sentence.", test.CountRepeats("hello", "hello"));
    }
    [Fact]
    public void CountRepeats_singleWordinSentence()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("cat appears 1 time/times in this sentence.", test.CountRepeats("cat", "I am not a cat person"));
    }
    [Fact]
    public void CountRepeats_singleWordinSentenceMultipleTimes()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("cat appears 2 time/times in this sentence.", test.CountRepeats("cat", "I am not a cat person. I am telling you, I am not a cat person"));
    }
    [Fact]
    public void CountRepeats_Capitalization()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("Cat appears 3 time/times in this sentence.", test.CountRepeats("Cat", "I am not a CAT, cAt, caT person"));
    }
    [Fact]
    public void CountRepeats_EmptyInput()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("Inputs cannot be empty. Please enter a word and/or sentence.", test.CountRepeats("cat", ""));
    }
    [Fact]
    public void CountRepeats_MatchNotFound()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("Match not found.", test.CountRepeats("cat", "hello how are you?"));
    }
    [Fact]
    public void CountRepeats_WordWithSpecialCharacter()
    {
      RepeatCounter test = new RepeatCounter();
      Assert.Equal("apple appears 3 time/times in this sentence.", test.CountRepeats("apple", "#apple  apple  is good for you, apple4"));
    }
  }
}
