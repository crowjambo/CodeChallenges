using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanReadable
{
    class Program
    {
        /*
        Your task in order to complete this Kata is to write a function which formats a duration, given as a number of seconds, in a human-friendly way.

The function must accept a non-negative integer. If it is zero, it just returns "now". Otherwise, the duration is expressed as a combination of years, days, hours, minutes and seconds.

It is much easier to understand with an example:

formatDuration (62)    // returns "1 minute and 2 seconds"
formatDuration (3662)  // returns "1 hour, 1 minute and 2 seconds"

For the purpose of this Kata, a year is 365 days and a day is 24 hours.

Note that spaces are important.
Detailed rules

The resulting expression is made of components like 4 seconds, 1 year, etc. In general, a positive integer and one of the valid units of time, separated by a space. The unit of time is used in plural if the integer is greater than 1.

The components are separated by a comma and a space (", "). Except the last component, which is separated by " and ", just like it would be written in English.

A more significant units of time will occur before than a least significant one. Therefore, 1 second and 1 year is not correct, but 1 year and 1 second is.

Different components have different unit of times. So there is not repeated units like in 5 seconds and 1 second.

A component will not appear at all if its value happens to be zero. Hence, 1 minute and 0 seconds is not valid, but it should be just 1 minute.

A unit of time must be used "as much as possible". It means that the function should not return 61 seconds, but 1 minute and 1 second instead. Formally, the duration specified by of a component must not be greater than any valid more significant unit of time.

        
         */

        public static string formatDuration(int seconds){
            //special case for 0
            if(seconds == 0) return "now";

            int[] sizes = new int[]{3600*24*365, 3600*24, 3600, 60};
            string[] timeStrings = new string[]{"year", "day", "hour", "minute", "second"};
            string output = String.Empty;
            int counter;
            //general collection for time marks
            List<int> col = new List<int>();

            for (int i = 0; i < sizes.Length; i++)
            {
                //count occurances
                counter = 0;
                //decrement starting from biggest
                while(seconds >= sizes[i]){
                    seconds -= sizes[i];
                    counter++;
                }
                //add all occurances for each size
                col.Add(counter);
            }
            //add whats left, the seconds
            col.Add(seconds);

            //create string based on the data
            for (int i = 0; i < col.Count; i++)
            {
                //time mark exists
                if(col[i] != 0){
                    output += $"{col[i].ToString()} {timeStrings[i]}";
                    //plural
                    if(col[i] > 1) output += "s";


                    //check whether there is another timemark
                    if(col[i] != col.Last()){

                        try{
                            //decide to add , or and
                            //if next is not last
                            if(col[i+2] != 0){
                                output += ", ";
                            }
                            else{
                                //next element is last
                                output += " and ";
                                
                            }
                        }
                        catch(Exception){
                            if(col[i+1] != 0)
                            output += " and ";
                        }

                    }

                }
            }

            return output;
        }

        static void Main(string[] args)
        {
//             formatDuration (62)    // returns "1 minute and 2 seconds"
//             formatDuration (3662)  // returns "1 hour, 1 minute and 2 seconds"
            // Assert.AreEqual("7 years, 246 days, 15 hours, 32 minutes and 54 seconds",HumanTimeFormat.formatDuration(242062374));
    // Assert.AreEqual("4 years, 68 days, 3 hours and 4 minutes",HumanTimeFormat.formatDuration(132030240));


            int input = 120;
            System.Console.WriteLine(formatDuration(input));
        }
    }
}
