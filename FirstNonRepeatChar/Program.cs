using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstNonRepeatChar
{
    class Program
    {
        /*
        
Write a function named first_non_repeating_letter that takes a string input, and returns the first character that is not repeated anywhere in the string.

For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.

As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the correct case for the initial letter. For example, the input 'sTreSS' should return 'T'.

If a string contains all repeating characters, it should return an empty string ("") or None -- see sample tests.

Assert.AreEqual("a", Kata.FirstNonRepeatingLetter("a"));
Assert.AreEqual("t", Kata.FirstNonRepeatingLetter("stress"));
Assert.AreEqual("e", Kata.FirstNonRepeatingLetter("moonmen"));

        */

        public static string FirstNonRepeatingLetter(string s){
            //vars
            Dictionary<string,List<string>> charCollection = new Dictionary<string,List<string>>();
            List<string> temp;
            foreach(char x in s){
                //keys are the same for lower and uppercase
                if(!charCollection.ContainsKey(Char.ToLower(x).ToString())){
                    charCollection.Add(Char.ToLower(x).ToString(),new List<string>());
                }
                charCollection.TryGetValue(Char.ToLower(x).ToString(), out temp);
                //add true upper or lower case value for clean returns
                temp.Add(x.ToString());
            }

            //loop through all keys, and check list value, if count is 1 return that char.ToString
            foreach(var key in charCollection.Keys){
                if(charCollection[key].Count == 1){
                    return charCollection[key].First();
                }
            }
            return "";
        }

        static void Main(string[] args)
        {
            string input = "sTress";
            Console.WriteLine(FirstNonRepeatingLetter(input));
        }
    }
}
