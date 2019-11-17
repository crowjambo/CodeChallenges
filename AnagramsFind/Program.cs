using System;
using System.Collections.Generic;
using System.Linq;

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
            //vars
            List<string> outputList = new List<string>();
            char[] inputWord = word.ToCharArray();
            char[] tempWord;
            List<string> wordList = new List<string>();
            foreach(var x in words){
                wordList.Add(x);
            }

            //prepping input word
            for(int i = 0; i < inputWord.Length ; i++){
                inputWord[i] = Char.ToLower(inputWord[i]);
            }
            Array.Sort(inputWord);
    
            //main loop
            foreach(string x in wordList){
                tempWord = x.ToCharArray();
                if(tempWord.Length == inputWord.Length){
                    for(int i = 0; i<tempWord.Length; i++){
                        tempWord[i] = Char.ToLower(tempWord[i]);
                    }
                    Array.Sort(tempWord);
                    if(Enumerable.SequenceEqual(inputWord,tempWord)){
                        outputList.Add(x);
                    }
                }
            }
            return outputList;
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
