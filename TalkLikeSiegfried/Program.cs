using System;

namespace TalkLikeSiegfried
{
    class Program
    {
        /*
        
        Week 1

    ci -> si
    ce -> se
    c -> k (except ch leave alone)

Week 2

    ph -> f


week 3

    remove trailing e (except for all 2 and 3 letter words)
    replace double letters with single letters (e.g. tt -> t)

Week 4

    th -> z
    wr -> r
    wh -> v
    w -> v


Week 5

    ou -> u
    an -> un
    ing -> ink (but only when ending words)
    sm -> schm (but only when beginning words)


Notes

    You must retain the case of the original sentence
    Apply rules strictly in the order given above
    Rules are cummulative. So for week 3 first apply week 1 rules, then week 2 rules, then week 3 rules


         
        */


        public static string Siegfried(int week, string str){
    //           ci -> si
    // ce -> se
    // c -> k (except ch leave alone)

            string output = str;
            string[] chars = new string[3];
            string currentChar;

            //go through each character
            for(int i = 0; i < str.Length; i++){
                currentChar = str[i];

                //check if im on last char or not
                if(i+1 != str.Length){
                    
                    
                }
            }


            return output;
        }

        static void Main(string[] args)
        {
            string input ="This is KAOS!! We don't play with Code-Wars here!! " +
                "So there will be trouble for you this time Mr Maxwell Smart! " +
                "We have received all the photographic evidence we need so choose carefully what you say next! " +
                "I hope you will co-operate with KAOS and do exactly what we want Mr Smart otherwise I won't be happy with you! " +
                "In fact, if you misbehave that would make me very unhappy indeed... " +
                "And you certainly would not want to make me unnecesarily cross would you Mr Maxwell Smart?";

            System.Console.WriteLine(Siegfried(1,input));
        }
    }
}
