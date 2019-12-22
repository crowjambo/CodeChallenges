using System;
using StackTest;

namespace MinStack2
{
    class Program
    {
        /**
            * Your MinStack object will be instantiated and called as such:
            * MinStack obj = new MinStack();
            * obj.Push(x);
            * obj.Pop();
            * int param_3 = obj.Top();
            * int param_4 = obj.GetMin();
        */

        static void Main(string[] args)
        {
            MinStack test = new MinStack();
            test.Push(5);
            test.Push(6);
            test.Push(8);
            test.Push(9);
            System.Console.WriteLine(test.Top());
            System.Console.WriteLine(test.GetMin());
            test.Pop();
            System.Console.WriteLine(test.Top());
        }
    }
}
