using System;
/*

Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].

*/

namespace TwoSum
{
    class Program
    {
        //Solution
        public static int[] TwoSum(int[] nums, int target) {
            //create placeholder array
            int[] newArr = new int[2];

            //loop through array and try adding all numbers to one another to check if condition is met
            for(int i = 0; i < nums.Length ; i++){
                //another loop to go through all values EXCEPT the one you are currently on
                for(int y = 0; y < nums.Length; y++){
                    //make sure value isnt the same (only the index needs to differ)
                    if(i != y){
                        //check if condition is met
                        if(nums[i] + nums[y] == target){
                            //add as newArr members and break loop
                            newArr[0] = y;
                            newArr[1] = i;
                            
                            break;
                        }
                    }
                }
            }
            //return indexes
            return newArr;
    }
 

        static void Main(string[] args)
        {
            //Vars
            int target = 6;
            int[] nums = new int[] {3,3};
            int[] answerArr = Program.TwoSum(nums,target);

            //Out
            Console.WriteLine($"{answerArr[0]} {answerArr[1]}");
        }
    }
}
