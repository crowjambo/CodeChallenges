using System;

namespace NumberOfIslands
{
    class Program
    {
        /*
        
        Input:
        11110
        11010
        11000
        00000

        Output: 1

        Input:
        11000
        11000
        00100
        00011

        Output: 3

        */

        //breadth first search to find how deep 1's go, replace the checked ones with '0'
        public static int NumIslands(char[][] grid) {
            int count = 0;
            for (int i = 0; i < grid.Length; i++){
                for (int j = 0; j < grid[i].Length; j++)
                {
                    char currentSpot = grid[i][j];
                    if(currentSpot == '1'){
                        count += 1;
                        callBFS(grid, i,j);
                    }
                }        
            }    
            return count;
        }

        //recursive breadth first search
        public static void callBFS(char[][] grid, int i, int j){
            //boundary check
            if(i<0 || i>=grid.Length || j<0 || j>=grid[i].Length || grid[i][j] == '0'){
                return;
            }
            grid[i][j] = '0';
            callBFS(grid, i+1,j); //up
            callBFS(grid, i-1,j); //down
            callBFS(grid, i,j-1); //left
            callBFS(grid, i,j+1); //right
        }

        static void Main(string[] args)
        {
            char[][] input = new char[][]{
                new char[]{'1','1','0','0','0'},
                new char[]{'1','1','0','0','0'},
                new char[]{'0','0','1','0','0'},
                new char[]{'0','0','0','1','1'}
            };

            System.Console.WriteLine(NumIslands(input));

            
        }
    }
}
