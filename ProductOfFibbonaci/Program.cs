using System;
using System.Diagnostics;

namespace ProductOfFibbonaci
{
    /*
    
    productFib(714) # should return {21, 34, 1}, 
    # since F(8) = 21, F(9) = 34 and 714 = 21 * 34

    Fm * Fm+1 > input (if == return 1(true), else 0 (false))
    m start from 1
    */

    class Program
    {
        public static ulong FibbonaciCalc(ulong n){
            if(n <= 1) return n;
            return FibbonaciCalc(n-1) + FibbonaciCalc(n-2);
        }

        //This is trash method, rather look to speed up fibonnaci calculation itself, all of this here is useless
        public static ulong SetIniitalSpeed(ulong prod){
            ulong returnValue = 1;
            // if(prod <= 100000) return 1;
            if(prod >= 100000000000000) returnValue += 33; //34
            if(prod >= 1000000000000000) returnValue += 4; //38
            if(prod >= 10000000000000000) returnValue += 2; //40
            // if(prod >= 10000000000000000000)
            return returnValue;
        }
       
        public static ulong AdjustSpeed(ulong result, ulong prod){
            //basic speed up, skip fibbonaci calcs (error margin increases hard the more you do it, would need to correct it)
            // if(prod >= 10000000000000000){
            //     return 10;
            // }
            // if(result * 2.6*3 < prod) return 4;
            // if(result * 2.6*2 < prod) return 3;
            if(result * 2.6 < prod) return 2;
            return 1;
        }

        public static ulong[] productFib(ulong prod){
            //vars
            ulong[] output = new ulong[3];
            ulong m1Fib = 0;
            ulong m2Fib = 0;
            ulong result = 0;
            //to speed up calc
            ulong iterationSpeed = 1;
            //initial values skip
            ulong m1 = SetIniitalSpeed(prod);
            ulong m2 = m1+1;
            //main calc
            while(result < prod){
                //condition check
                m1Fib = FibbonaciCalc(m1);
                m2Fib = FibbonaciCalc(m2);
                result = m1Fib*m2Fib;

                //debug info
                System.Console.WriteLine($"m1: {m1} m2: {m2}");

                //adjust speed based on distance for performance
                iterationSpeed = AdjustSpeed(result,prod);

                //next iteration
                m1 += iterationSpeed;
                m2 = m1+1;
            }
            //output
            output[0] = m1Fib;
            output[1] = m2Fib;
            //true
            if(result == prod){
                output[2] = 1; //true
            } 
            else{
                output[2] = 0; //false
            }
            return output;
        }

        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // ulong input = 10000000000000000000;
            // ulong input = 100000000000000000; //267914296 and 433494437  (27sec)
            ulong input = 100000000000000; // 9227465 14930352 0 (0.9sec)
            // ulong input = 1000000000000000; //39088169 63245986 0 (4sec)
            // ulong input = 10000000000000000; //102334155 165580141 0 (10sec)
            // ulong input = 714;
            // ulong input = 4895;
            ulong[] output = productFib(input);
            watch.Stop();
            Console.WriteLine($"{output[0]} {output[1]} {output[2]}"); // 21 34 1
            TimeSpan ts = watch.Elapsed;
            System.Console.WriteLine(ts);





            // ///
            // var watch2 = System.Diagnostics.Stopwatch.StartNew();
            // ulong input2 = 714;
            // ulong[] output2 = productFib(input2);
            // watch2.Stop();
            // Console.WriteLine($"{output2[0]} {output2[1]} {output2[2]}"); // 21 34 1
            // TimeSpan ts2 = watch2.Elapsed;
            // System.Console.WriteLine(ts2);
        }
    }
}
