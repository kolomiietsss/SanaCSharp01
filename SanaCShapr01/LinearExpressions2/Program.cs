﻿using System;

namespace LinearExpressions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input m: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Input n: ");
            double n = double.Parse(Console.ReadLine());

            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
            Console.WriteLine($"z1 = {z1}");
            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine($"z2 = {z2}");


            Console.Write("Input a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input x: ");
            double x = double.Parse(Console.ReadLine());

            double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
            Console.WriteLine($"y = {y}");
        }
    }
}
