using System;
using System.Collections.Generic;

namespace Lesson3_2022_06_30
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (int num in GetNumberDivisibleByA(30))
            //{
            //    Console.Write(num + " ");
            //}
            
            Console.WriteLine(GetCountOfNumbers(10));
        }

        //1. The user enters 2 numbers (A and B). Raise the number A to the power of B.
        static double Degree(double number, double degree)
        {
            double result = 1;

            if (number == 0)
            {
                return double.NaN;
            }

            if (degree > 0)
            {
                for (int i = 1; i <= degree; i++)
                {
                    result *= number;
                }
            }
            else if (degree < 0)
            {
                for (int i = -1; i >= degree; i--)
                {
                    result /= number;
                }
            }

            return result;
        }

        //2. The user enters 1 number (A). Print all numbers from 1 to 1000 that are divisible by A.
        static List<int> GetNumberDivisibleByA(int a)
        {
            var numbers = new List<int>();

            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    numbers.Add(i);
                }
            }

            return numbers;
        }

        //3. The user enters 1 number (A). Find the number of positive integers whose square is less than A.
        static int GetCountOfNumbers(int a)
        {
            int i = 0;
            while (Math.Pow(i, 2) < a)
            {
                i++;
            }
            return i;
        }



    }
}
