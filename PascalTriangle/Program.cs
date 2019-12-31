using System;
using System.Collections.Generic;
using System.Collections;

namespace PascalTriangle
{
    class Program
    {

        public static IList<IList<int>> Generate(int numRows) {
            IList<IList<int>> outputList = new List<IList<int>>();

            //rows
            for (int i = 0; i < numRows; i++)
            {
                //each row is its own list
                IList<int> tempList = new List<int>();
                
                //previous row
                if(i-1 >= 0){
                    IList<int> prevRow = outputList[i-1];
                    
                    //columns
                    for(int j = 0; j < i+1; j++){

                        if(j-1 >= 0 && j <= prevRow.Count-1){
                            tempList.Add(prevRow[j]+prevRow[j-1]);
                        }
                        else{
                            tempList.Add(1);
                        }
                    }
                }
                //for first row only
                else{
                    tempList.Add(1);
                }


                //append output
                outputList.Add(tempList);
            }
            
            return outputList;
        }

        static void Main(string[] args)
        {
            /* 
            
Input: 5
Output:
[
     [1],
    [1,1],
   [1,2,1],
  [1,3,3,1],
 [1,4,6,4,1]
]
            
            */
            int input = 5;
            foreach(var x in Generate(input)){
                foreach(var z in x){
                    System.Console.Write(z);
                }
                System.Console.WriteLine("");
            }
        }
    }
}
