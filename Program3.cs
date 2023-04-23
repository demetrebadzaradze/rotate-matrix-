//rotate matrix 
using System;

namespace Csharpproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            int x;
            int y;
            
            Console.WriteLine("enter matrix height:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter matrix width:");
            y = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[x,y];
            int[,] rotateArray = new int[y,x];

            ArrayFill(array);
            ArrayPrint(array);

            rotateArray = RotateArray(array);

            Console.WriteLine();

            ArrayPrint(rotateArray);

            Console.WriteLine();
        }
        static void ArrayFill(int[,] arr)
        {
            Random random = new Random();

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = random.Next(0,9);
                }
            }
        }
        static void ArrayPrint(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + "  ");
                }
                Console.WriteLine();
            }
        }
        static T[,] RotateArray<T>(T[,] arr)
        {
            T[,] result = new T[arr.GetLength(1),arr.GetLength(0)];

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    result[j,i] = arr[i,j];
                }
            }
            return result;
        }
    }
}            