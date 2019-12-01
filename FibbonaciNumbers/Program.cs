using System;

namespace FibbonaciNumbers
{
    /* 
    
        F0 = 0; F1 = 1;
        Fn = fn-1 + fn-2

        0,1,1,2,3,,5,8,13

        input = n

        fib(9) = 34

    */

    class Program
    {
        public static int FibbonaciNumbers(int n){
            if(n <= 1) return n;
            return FibbonaciNumbers(n-1) + FibbonaciNumbers(n-2);
        }

        static void Main(string[] args)
        {
            int input = 9;
            System.Console.WriteLine(FibbonaciNumbers(input).ToString());
        }
    }
}
