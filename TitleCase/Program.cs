using System;
using System.Collections.Generic;

namespace TitleCase
{
    class Program
    {
        /* ###Arguments (Other languages)

        First argument (required): the original string to be converted.
        Second argument (optional): space-delimited list of minor words that must always be lowercase except for the first word in the string. The JavaScript/CoffeeScript tests will pass undefined when this argument is unused.

        ###Example

        Kata.TitleCase("a an the of", "a clash of KINGS")   => "A Clash of Kings"
        Kata.TitleCase("The In", "THE WIND IN THE WILLOWS") => "The Wind in the Willows"
        Kata.TitleCase("the quick brown fox")               => "The Quick Brown Fox"

        A string is considered to be in title case if each word in the string is either (a) capitalised (that is, only the first letter of the word is in upper case) or (b) considered to be an exception and put entirely into lower case unless it is the first word, which is always capitalised.

        Write a function that will convert a string into title case, given an optional list of exceptions (minor words). The list of minor words will be given as a string with each word separated by a space. Your function should ignore the case of the minor words string -- it should behave in the same way even if the case of the minor word string is changed.

         */

        public static string TitleCase(string title, string minorWords="")
        {
            if(minorWords == null) minorWords = new String("");
            if(title.Length < 1){
                return "";
            }
            //minor words, split based on delimter empty space to create list/array
            string[] minorStrings = minorWords.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            //remove top/first element (that element will be capitalized anyway)
            List<string> listMinor = new List<string>();
            //minorStrings[0] = String.Empty;
            for(int i = 0; i < minorStrings.Length ; i++){
                listMinor.Add(minorStrings[i].ToLower());
            }

            //split title string based on space delimiter and create list/array
            string[] titleWords = title.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            //set first letter to capital, and lowercase the rest of first word
            char[] firstTest = titleWords[0].ToCharArray();
            firstTest[0] = Char.ToUpper(firstTest[0]);
            titleWords[0] = new String(firstTest);

            //for all others loop and check if they are inside of minor words list/array, if yes - lowrecase them all. Else set first char to upper case rest lower
            for(int i = 0; i< titleWords.Length ; i++){
                if(listMinor.Contains(titleWords[i].ToLower())){
                    titleWords[i] = titleWords[i].ToLower();
                }
                else{
                    char[] temp = titleWords[i].ToCharArray();
                    temp[0] = Char.ToUpper(temp[0]);
                    for(int j = 1; j < temp.Length ; j++){
                        temp[j] = Char.ToLower(temp[j]);
                    }
                    titleWords[i] = new String(temp);
                    
                }
            }

            //create output string and append each modified character + return it
            string output = "";
            for(int i = 0; i < titleWords.Length; i++){
                if(i+1 == titleWords.Length){
                    output += titleWords[i];
                }
                else{
                    output += titleWords[i] + " ";
                }
                
            }
            
            char[] beforeOut = output.ToCharArray();
            beforeOut[0] = Char.ToUpper(beforeOut[0]);
            return new String(beforeOut);
        }

        static void Main(string[] args)
        {
            string titleInput = "a clash of KINGS";
            string wordsInput = "a an the of";
            //Console.WriteLine(TitleCase(titleInput, wordsInput));
            //Console.WriteLine(TitleCase("the quick brown fox"));
            Console.WriteLine(TitleCase("THE WIND IN THE WILLOWS", "The In"));
            System.Console.WriteLine(TitleCase(""));
            System.Console.WriteLine(TitleCase("aBC deF Ghi", null));
            //aBC deF Ghi",null,"Abc Def Ghi")
            //THE WIND IN THE WILLOWS", "The In"
        }
    }
}
