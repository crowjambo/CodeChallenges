using System;

namespace Mumbling
{
    class Program
    {
        /*
        Function that does:

        accum("abcd") -> "A-Bb-Ccc-Dddd"
        accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
        accum("cwAt") -> "C-Ww-Aaa-Tttt"

        */


        public static String Accum(string s){
            //create output string
            string output = "";
            //for loop based on the length of string
            for(int i = 0; i<s.Length; i++){
                //another loop, which depending on current iterator will loop more times and append
                for(int x = 0; x < i+1 ; x++){
                    //exception for the very first character
                    if(i == 0){
                        output += Char.ToUpper(s[i]);
                    }
                    else {
                        //if character is different from previous one, append - first, and append capital letter of current char
                        //extra or (x==0)check incase same character is twice in the input string
                        if(Char.ToUpper(s[i]) != Char.ToUpper(output[output.Length-1]) || x == 0){
                            output += "-" + Char.ToUpper(s[i]);
                        } 
                        else {
                            output += Char.ToLower(s[i]);
                        }
                    }
                }      
            }
            return output;
        }

        static void Main(string[] args)
        {
            string input = "NyffsGeyylB";
            Console.WriteLine(Accum(input));
        }
    }
}
