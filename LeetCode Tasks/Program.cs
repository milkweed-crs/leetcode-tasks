using System;
using System.Diagnostics;

namespace LeetCode_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            var result = NumberOfStepsToReduceANumberToZero.NumberOfSteps(123);
            sw.Stop();

            Console.WriteLine(result);
            Console.WriteLine(sw.Elapsed);
        }
    }
}