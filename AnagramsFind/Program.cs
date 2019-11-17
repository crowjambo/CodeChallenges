using System;
using System.Collections.Generic;

namespace AnagramsFind
{
    class Program
    {
        /* 

        Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words. You should return an array of all the anagrams or an empty array if there are none. For example:
        
        anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']

        anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']) => ['carer', 'racer']

        anagrams('laser', ['lazing', 'lazy',  'lacer']) => []
        
        */

        public static List<string> Anagrams(string word, List<string> words){
            
        }

        static void Main(string[] args)
        {
            string inputWord = "abba";
            foreach(var x in Anagrams(inputWord, new List<string>(){"aabb","abcd","bbaa","dada"})){
                System.Console.WriteLine(x);
            }
            //expected output: aabb bbaa
        }
    }
}
