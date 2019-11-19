using System;
using System.Collections.Generic;
using System.Linq;

namespace IQtest
{
    class Program
    {
        /*
        
        Bob is preparing to pass IQ test. The most frequent task in this test is to find out which one of the given numbers differs from the others. Bob observed that one number usually differs from the others in evenness. Help Bob — to check his answers, he needs a program that among the given numbers finds one that is different in evenness, and return a position of this number.

        ! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)

        ##Examples :

        IQ.Test("2 4 7 8 10") => 3 // Third number is odd, while the rest of the numbers are even

        IQ.Test("1 2 1 1") => 2 // Second number is even, while the rest of the numbers are odd

        */

        public static int Test(string numbers)
        { 
            //split into array using delimiter " "
            string[] convertedInput = numbers.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            //convert into integers
            int[] intInput = new int[convertedInput.Length];
            for(int i = 0 ; i < convertedInput.Length ; i++){
                intInput[i] = Int32.Parse(convertedInput[i]);
            }
            //loop through all integers and do if check whether they are even/odd and add to collection
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();
            for(int i = 0; i < intInput.Length ; i++){
                if( intInput[i] % 2 == 0){
                    evenList.Add(i+1);
                }
                else{
                    oddList.Add(i+1);
                }
            }

            //return the index from the collection that has only 1 member Count
            if(oddList.Count > evenList.Count) return evenList.First();
            else return oddList.First();
        }

        static void Main(string[] args)
        {
            //string input = "2 4 7 8 10";
            string input = "1 2 1 1";
            Console.WriteLine(Test(input));
        }
    }
}
