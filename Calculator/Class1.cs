using System;

namespace Calculator
{
    public  class ArraysCalculator
    {
        public static int FindMinimum(int[,] arr)
        {
            int min = arr[0,0];
            for(int i =0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1);j++)
                {
                    if(arr[i,j]<min)
                    {
                        min = arr[i,j];
                    }
                }
            }
            return min;
        }

        public static int FindMaximum(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }

        public static (int, int) FindIndexOfMinElement(int[,] arr)
        {
            int min = arr[0, 0];
            int minI = 0;
            int minJ = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minI = i;
                        minJ = j;
                    }
                }
            }
            return (minI,minJ);
        }

        public static (int, int) FindIndexOfMaxElement(int[,] arr)
        {
            int max = arr[0, 0];
            int maxI = 0;
            int maxJ = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }
            return (maxI, maxJ);
        }

        public static int[,] TransposeMatrix(int[,] matrix)
        {
            int[,] result = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for(int i = 0; i<matrix.GetLength(0); i++)
            {
                for(int j=0; j<matrix.GetLength(1); j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            return result;
        }
    }
}
