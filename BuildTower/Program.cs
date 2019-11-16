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
             //vars
            List<string> list_string = new List<string>();
            int starCounter = 1;

            //main loop / columns
            for(int i = 0 ; i < nFloors ; i++){
                //reset
                string output = "";

                //special case for 1 floor
                if(nFloors == 1){
                    output += "*";
                    return new String[] {output};
                }

                //horizontal adding / rows
                for(int j = 0; j < nFloors*2-1 ; j++){
                    if(j == nFloors-i-1){
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
                starCounter += 2;
                list_string.Add(output);
            }

    
            return list_string.ToArray();
        }




        static void Main(string[] args)
        {
            foreach(var x in TowerBuilder(12)){
                Console.WriteLine("[" + x + "]");
            }    
        }
    }
}
