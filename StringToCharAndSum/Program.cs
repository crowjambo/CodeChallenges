using System;

//input 127.0.0.1
/*

add all numbers together
multiply by first digit
output in console

example output : 11
(1+2+7+0+0+1) *1)
(its a port number, so needs to be int value at the end)
*/


namespace StringToCharAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string ip = "127.0.0.1";
            
            //char array of the string
            char[] arrIp = ip.ToCharArray();
            
            //get proper int out of a char
            int firstDigit = (int)Char.GetNumericValue(arrIp[0]);

            //loop through all characters, if not "." then add to sum 
            int result = 0;
            foreach(char x in arrIp){
                if(x != '.'){
                    result += (int)Char.GetNumericValue(x);
                }
            }

            //multiply by first digit and output final result
            Console.WriteLine($"Port = {result*firstDigit}");
        }
    }
}
