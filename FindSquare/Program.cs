using System;

namespace FindSquare
{
    class Program
    {
        /*

        isSquare(-1) returns  false
        isSquare(0) returns   true
        isSquare(3) returns   false
        isSquare(4) returns   true
        isSquare(25) returns  true  
        isSquare(26) returns  false

        */

        public static bool isSquare(int n){
            int i = 0;
            while(i*i <= n){
                if(i * i == n){
                    return true;
                }
                i++;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int input = 4;
            Console.WriteLine(isSquare(input).ToString());
        }
    }
}
