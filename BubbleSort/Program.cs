using System;

namespace BubbleSort
{
    class Program
    {

    //pass collection by reference (pointer)
    public static void SortBubble(int[] input)  {

        //looping starting from the back
        for (var i = input.Length - 1; i >= 0; i--){
            //taking element from the back, but one step ahead
            for (var j = input.Length - 1 - 1; j >= 0; j--){

                //if equals, dont swap
                if (input[j] <= input[j + 1]) continue;
                //Swap, could be in another function call
                var temp = input[j + 1];
                input[j + 1] = input[j];
                input[j] = temp;
            }
        }
    }

        static void Main(string[] args)
        {
            int[] input = new int[]{6,5,3,1,8,7,2,4};

            SortBubble(input);

            foreach(int x in input){
                System.Console.WriteLine(x);
            }
        }
    }
}
