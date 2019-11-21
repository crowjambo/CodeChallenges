using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedIsGood
{
    /* 
    
    Greed is a dice game played with five six-sided dice. Your mission, should you choose to accept it, is to score a throw according to these rules. You will always be given an array with five six-sided dice values.

 Three 1's => 1000 points
 Three 6's =>  600 points
 Three 5's =>  500 points
 Three 4's =>  400 points
 Three 3's =>  300 points
 Three 2's =>  200 points
 One   1   =>  100 points
 One   5   =>   50 point

A single die can only be counted once in each roll. For example, a "5" can only count as part of a triplet (contributing to the 500 points) or as a single 50 points, but not both in the same roll.

    Assert.AreEqual(400, Kata.Score(new int[] {4, 4, 4, 3, 3}), "Should be 400");
    Assert.AreEqual(0, Kata.Score(new int[] {2, 3, 4, 6, 2}), "Should be 0 :-(");

    
 Throw       Score
 ---------   ------------------
 5 1 3 4 1   50 + 2 * 100 = 250
 1 1 1 3 1   1000 + 100 = 1100
 2 4 4 5 4   400 + 50 = 450

    */
    class Program
    {
        public static int Score(int[] dice) {
            //vars
            int points = 0;
            List<int> temp;
            Dictionary<int,List<int>> diceCollection = new Dictionary<int, List<int>>();
            //init dictionary key values
            for (int i = 0; i < 6; i++)
            {
                diceCollection.Add(i+1,new List<int>());
            }
            //collect dices in list collections
            foreach(var x in dice){
                diceCollection.TryGetValue(x, out temp);
                temp.Add(x);
            }

            //points calc
            var lists = diceCollection.Values;
            int counter = 1;
            foreach(var list in lists){
                if(list.Count ==3){
                    if(counter == 1) points += 1000;
                    else points += counter*100;
                }
                else if(list.Count > 3){
                    if(counter == 1) points += 1100;
                    else if(counter == 5) points += 550; 
                    else points += counter*100;                
                }
                else if(list.Count < 3){
                    if(counter == 1) points += 100 * list.Count;
                    else if(counter == 5) points += 50 *list.Count;
                }
                counter++;
            }
            //out
            return points;
        }


        static void Main(string[] args)
        {
            int[] input = new int[]{5,2,5,2,2};
            Console.WriteLine(Score(input));
        }
    }
}
