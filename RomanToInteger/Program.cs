﻿using System;

namespace RomanToInteger
{
    class Program
    {
        /* 
        
        Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000


    I can be placed before V (5) and X (10) to make 4 and 9. 
    X can be placed before L (50) and C (100) to make 40 and 90. 
    C can be placed before D (500) and M (1000) to make 400 and 900.



Example 3:

Input: "IX"
Output: 9

Example 4:

Input: "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.

Example 5:

Input: "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.


        
        */

        public int RomanToInt(string s) {
            /* I             1
V             5
X             10
L             50
C             100
D             500
M             1000 */
            int output = 0;
            foreach(char x in s){
                
            }


            return output;

        }

        static void Main(string[] args)
        {
            string input = "IX";
            System.Console.WriteLine(RomanToInteger(input));
        }
    }
}
