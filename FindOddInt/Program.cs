using System;
using System.Collections.Generic;

namespace FindOddInt
{
    class Program
    {
        /* Given an array, find the int that appears an odd number of times.

        There will always be only one integer that appears an odd number of times.
        */
        
        public static int find_it(int[] seq){

            List<int> testList = new List<int>();
            List<int> testCounterList = new List<int>();

            Array.Sort(seq);
 
            int counter = 1;
            for(int i = 1; i < seq.Length ; i++){
                if(seq[i] == seq[i-1]){
                    counter++;
                }
                if(seq[i] != seq[i-1]){
                    testList.Add(seq[i-1]);
                    testCounterList.Add(counter);
                    counter = 1;
                }
                if(i+1 >= seq.Length){
                    testList.Add(seq[i-1]);
                    testCounterList.Add(counter);
                }
            }

            int currentValue = 0;
            int countBiggest = 0;
            //preview
            for(int j = 0; j < testList.Count ; j++){
                if(testCounterList[j] % 2 != 0 && testCounterList[j] > countBiggest){
                    countBiggest = testCounterList[j];
                    currentValue = testList[j];
                }
            }


            return currentValue;
        } 
        
        static void Main(string[] args)
        {
            Console.WriteLine(find_it(new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5,-1,-1,10,10,10,10,10,10,10,10,10,50,50,50,50,50,50,50,50,50,50,50,50,50 }));
        }
    }
}
