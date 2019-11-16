using System;
using System.Collections.Generic;

namespace BuildTower
{
    /*
    
    3 floor output. String array
    [
  '  *  ', 
  ' *** ', 
  '*****'
    ]

    6 floors output
    [
  '     *     ', 
  '    ***    ', 
  '   *****   ', 
  '  *******  ', 
  ' ********* ', 
  '***********'
]
    
     */
    class Program
    {
          public static string[] TowerBuilder(int nFloors)
         {
            List<string> list_string = new List<string>();
            int starCounter = 1;
            for(int i = 0 ; i < nFloors ; i++){
                string output = "";
                for(int j = 0; j < nFloors*2-1 ; j++){
                    //odd number floors
                    if(nFloors %2 != 0){
                        //special case for 1 floor
                        if(nFloors == 1){
                            output += "*";
                        }
                        //normal
                        else if(j == nFloors-i-1){
                            for(int x=0; x<starCounter; x++){
                                output += "*";

                                if(x!=0){
                                    j++;    
                                }
                                
                            }
                        }
                        else{
                            output += " ";
                        }
                    }
                    //even numbered floors
                    else{
                        // if(j == nFloors/2-i ){
                        if(j == nFloors-1-i ){
                            for(int x=0; x<starCounter; x++){
                                output += "*";
                                if(x!=0){
                                    j++;
                                }
                                

                            }
                        }
                        else{
                            output += " ";
                        }
                    }
                    
                }
                starCounter += 2;
                list_string.Add(output);
            }

    
            return list_string.ToArray();
        }




        static void Main(string[] args)
        {
            foreach(var x in TowerBuilder(4)){
                Console.WriteLine("[" + x + "]");
            }    
        }
    }
}
