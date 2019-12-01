using System;

namespace FactorialNumbers
{
    /* n! = n * (n-1) * (n-2) 
    
        5! = 5 * 4 *3 *2 *1 = 120
    */
    class Program
    {
        public static int FactorialNumbers(int n){
            if(n == 1) return n;
            //recursive funcs need to be always decrementing, or not even be called, else its infinite loop!
            return n * FactorialNumbers(n-1);
        }

        static void Main(string[] args)
        {
            int input = 5;
            Console.WriteLine(FactorialNumbers(input).ToString());
        }
    }
}
