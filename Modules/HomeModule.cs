using Nancy;
using System;
using System.Collections.Generic;

namespace RepeatCounterNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/result"] = _ =>
      {
        string wordToSearch = Request.Form["wordToSearh"];
        string sentence = Request.Form["sentence"];

        RepeatCounter repeatCounter = new RepeatCounter();
        return View["result.cshtml", repeatCounter.CountRepeats(wordToSearch, sentence)];
      };

    }
  }
}
