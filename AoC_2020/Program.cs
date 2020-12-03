using AoC_2020.Problems.DayTwo;
using System;
using System.Diagnostics;

namespace AoC_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var dayTwoOutput = DayTwo.ValidPasswordCount(Properties.Resources.Exercise_02.Split(Environment.NewLine));
            stopwatch.Stop();
            Console.WriteLine($"Day Two Output: {dayTwoOutput} completed in {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
        }
    }
}
