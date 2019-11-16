using System;

namespace PrimeCalc
{
    class Program
    {
        /*
        
        Define a function that takes an integer argument and returns logical value true or false depending on if the integer is a prime.
        
        */

        public static bool IsPrime(int n)
        {
            if(n <= 1) return false;
            int count = 0;
            for(int i = 1; i<10; i++){
                if(n % i == 0){
                    count++;
                } 
            }
            if(n > 9){
                count++;
            }
            if(count == 2) return true;
            return false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(73).ToString());
        } 
    }
}
