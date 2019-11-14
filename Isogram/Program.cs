/*


An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

isIsogram "Dermatoglyphics" == true
isIsogram "moose" == false
isIsogram "aba" == false

*/

using System;
using System.Collections.Generic;

namespace Isogram
{
    class Program
    {

        public static bool IsIsogram(string str) 
        {
            //add each character of a input string into list
            List<char> charList = new List<char>();
            //check whether current character (in loop) is already in the list, if yes return false immediately else continue looping
            foreach(char x in str){
                if(charList.Contains(Char.ToLower(x))){
                    return false;
                }
                charList.Add(Char.ToLower(x));
            }
            return true;
    
        }

        static void Main(string[] args)
        {
            string input = "MOOSE";
            Console.WriteLine(IsIsogram(input).ToString());

        }

    }
}
