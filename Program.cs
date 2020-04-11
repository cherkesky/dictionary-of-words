using System;
using System.Collections.Generic;

namespace dictionaryOfWords
{
  class Program
  {
    static void Main(string[] args)
    {


      /*
          Create a dictionary with key value pairs to
          represent words (key) and its definition (value)
      */
      Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

      // Add several more words and their definitions
      wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
      wordsAndDefinitions.Add("Taco", "a Mexican dish consisting of a fried tortilla, typically folded, filled with various mixtures");
      wordsAndDefinitions.Add("Ball", "a solid or hollow spherical or egg-shaped object that is kicked, thrown, or hit in a game");

      /*
          Use square brackets to get the definition of two of the
          words and then output them to the console
      */

      /*
          Below, loop over the wordsAndDefinitions dictionary to get the following output:
              The definition of (WORD) is (DEFINITION)
              The definition of (WORD) is (DEFINITION)
              The definition of (WORD) is (DEFINITION)
      */
      foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
      {
      }








    }
  }
}
