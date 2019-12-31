using System;
using System.Collections.Generic;

namespace LongestWordInDictionary
{
    class Program
    {

// Input: 
// words = ["a", "banana", "app", "appl", "ap", "apply", "apple"]
// Output: "apple"
// Explanation: 
// Both "apply" and "apple" can be built from other words in the dictionary. However, "apple" is lexicographically smaller than "apply".

        public static string LongestWord(string[] words) {
            //sort first to make it more easy to understand 
            Array.Sort(words);
            //constant time to check if element is in the hashset(FAST)
            HashSet<string> builtWords = new HashSet<string>();

            string result = "";

            foreach(var x in words){
                //from first letter check to last letter if it contains 
                if(x.Length == 1 || builtWords.Contains(x.Substring(0,x.Length-1))){
                    if(x.Length > result.Length){
                        result = x  ;
                    }
                    builtWords.Add(x);
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            string[] input = new string[]{"a", "banana", "app", "appl", "ap", "apply", "apple"};
            System.Console.WriteLine(LongestWord(input));
        }
    }
}
