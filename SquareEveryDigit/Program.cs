using System;

namespace SquareEveryDigit
{
    /*

    For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

    */

    class Program
    {
        public static int SquareDigits(int n){
            //convert to string
            string convertedInput = n.ToString();
            //Vars
            int[] convertedArray = new int[convertedInput.Length];
            string output = String.Empty;
 
            for(int i = 0 ; i < convertedInput.Length ; i++){
                //take each single char and convert it into int
                convertedArray[i] = (int)Char.GetNumericValue(convertedInput[i]);

                //square that int + append to output string
                output += Math.Pow(convertedArray[i],2).ToString(); 
                
            }
            //convert output string into int + return
            return Int32.Parse(output);
        }

        static void Main(string[] args)
        {
            int input = 9119;
            Console.WriteLine(SquareDigits(input));
        }
    }
}
