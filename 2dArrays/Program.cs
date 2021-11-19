using System;
using Calculator;

namespace _2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[4, 2] { { 3, 2 }, { 3, 4 }, { 5, -2 }, { 7, 8 } };
            int x, y;
            (x,y) = ArraysCalculator.FindIndexOfMaxElement(array1);
            Console.WriteLine(x);
            Console.WriteLine(y);


        }
    }
}
