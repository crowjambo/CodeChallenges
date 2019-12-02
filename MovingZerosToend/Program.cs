using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingZerosToend
{
    class Program
    {

        /* Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
        
        
        Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}

         */

        public static int[] MoveZeroes(int[] arr)
        {

            //loop through input array
            //if 0 add to list 1
            //if not 1 add to list 2
            //output by combining list 2 in front and list 1 at the back, thats it ( to array )

            List<int> temp = new List<int>();
            List<int> temp2 = new List<int>();
            List<int> output = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0){
                    temp.Add(arr[i]);
                }
                else{
                    temp2.Add(arr[i]);
                }
            }
            foreach(int x in temp2){
                output.Add(x);
            }
            foreach(int x in temp){
                output.Add(x);
            }

            return output.ToArray();
        }
        
        static void Main(string[] args)
        {
            int[] input = new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1};
            foreach(var x in MoveZeroes(input)){
                System.Console.Write($"{x} ");
            }
        }
    }
}
