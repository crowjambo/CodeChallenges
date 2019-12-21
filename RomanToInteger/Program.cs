using System;
using System.Collections;

namespace RomanToInteger
{
    class Program
    {
        public static int RomanToInt(string s) {
            int output = 0;
            char nextChar = 'd';

            for (int i = 0; i < s.Length; i++)
            {
                //get what next is (affects value), and whether it even exists
                if(i+1 < s.Length){
                    nextChar = s[i+1];
                }

                //get value
                switch(s[i]){
                    case 'I':
                        if(nextChar == 'V' || nextChar == 'X'){
                            output--;
                        }
                        else{
                            output++;
                        }
                        break;
                    case 'V':
                            output += 5;       
                        break;
                    case 'X':
                        if(nextChar == 'L' || nextChar == 'C'){
                            output -= 10;
                        }
                        else{
                            output += 10;
                        }                 
                        break;
                    case 'L':
                            output += 50;          
                        break;
                    case 'C':
                        if(nextChar == 'D' || nextChar == 'M'){
                            output -= 100;
                        }
                        else{
                            output += 100;
                        }          
                        break;
                    case 'D':
                            output += 500;              
                        break;
                    case 'M':
                            output += 1000;  
                        break;
                }
            }
            return output;
        }

        static void Main(string[] args)
        {
            string input = "MCMXCIV";
            System.Console.WriteLine(RomanToInt(input));
        }
    }
}
