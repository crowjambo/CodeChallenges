using System;

namespace BinaryAdd
{
    class Program
    {
        /*
        
        Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.

        The binary number returned should be a string.

        
        */

        public static string AddBinary(int a, int b){
            return Convert.ToString(a+b,2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AddBinary(1,2)); //should be 11
        }
    }
}
