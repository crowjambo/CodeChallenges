using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareIntoSquares
{
    class Program
    {
        /*

        decompose(11) must return [1,2,4,10]. Note that there are actually two ways to decompose 11², 11² = 121 = 1 + 4 + 16 + 100 = 1² + 2² + 4² + 10² but don't return [2,6,9], since 9 is smaller than 10.

        For decompose(50) don't return [1, 1, 4, 9, 49] but [1, 3, 5, 8, 49] since [1, 1, 4, 9, 49] doesn't form a strictly increasing sequence.

        */

        public static List<long> Decomposer(long n, long remain){
                // basic case
                if(remain == 0){
                    List<long> r = new List<long>();
                    r.Add(n);
                    return r;
                }
                
                // iterate all element less than n
                for(long i = n - 1 ; i > 0; i--){
                    if((remain - i * i) >= 0){
                        List<long> r = Decomposer(i, (remain - i * i));
                        
                        // only get the answer
                        if(r != null){
                            r.Add(n);
                            return r;
                        }
                    }
                }
                
                // no answer
                return null;
        }

        public static string decompose(long n) {
            string output = String.Empty;
            //collect answers
            List<long> nums = Decomposer(n, n*n);

            if(nums != null){
                foreach(var x in nums){
                    if(x != n)
                    output += x.ToString() + " ";
                }
                //remove last space and create new string VERY UNOPTIMIZED
                output = output.Remove(output.Length -1 );
                return output;
            }
            else{
                return null;
            }
        }

        static void Main(string[] args)
        {
            long input = 1;
            System.Console.WriteLine(decompose(input));
            //Assert.AreEqual("1 2 4 10", d.decompose(n));
        }
    }
}
