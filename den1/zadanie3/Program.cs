﻿namespace zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            double part1 = Math.Tan(Math.Sqrt(Math.Log(Math.Exp(x + 1))));
            double part2 = (3 + Math.Sin(x * x)) / (Math.Sin(x * x) - Math.Cos(x * x));
            double y = part1 - part2;

            Console.WriteLine($"y = {y}");
        }
    }
}
