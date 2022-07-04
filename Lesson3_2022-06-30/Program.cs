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

            //Console.WriteLine(GetCountOfNumbers(10));
            //Console.WriteLine(GetLagestDivisor(1));
            //Console.WriteLine(GetSumOfRange(21, 5));
            //Console.WriteLine(GetNthNumberFibSeries(2));
            //Console.WriteLine(GetNthNumberFibSeries(5));
            //Console.WriteLine(GDC(13, 125));
            //Console.WriteLine(GetNumberOfOdd(987));
            //Console.WriteLine(ReverseNumber(554));
            Console.WriteLine(CheckDigits(123, 156));
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


        //4. The user enters 1 number (A). Print the largest divisor (other than A itself) of the number A.
        static int GetLagestDivisor (int a)
        {
            int i;
            for (i = a - 1; i >= 1; --i)
            {
                if (a % i == 0) return i;
            }
            return 0;
        }


        //5. The user enters 2 numbers(A and B). Print the sum of all numbers from the range A to B that are divisible by 7 without a remainder. (Note that B may be less than A if you type).
        static int GetSumOfRange(int a, int b)
        {
            int sum = 0;

            if (b < a)
            {
                (a, b) = (b, a); 
            }

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }


        //6. The user enters 1 number (N). Print the Nth number of the fibonacci series. In the fibonacci series, each next number is the sum of the previous two.
        //The first and second are considered equal to 1.
        static int GetNthNumberFibSeries (int a)
        {
            int first = 0;
            int second = 1;

            for (int i = 0; i < a; i++)
            {
                int temp = first;
                first = second;
                second += temp; 
            }

            return first;
        }

        //7. The user enters 2 numbers. Find their greatest common divisor using Euclid's algorithm.
        static int GetGDC(int a, int b)
        {
            int min = Math.Min(a, b);

            if (a % min == 0 && b % min == 0)
            {
                return min;
            }

            for (int i = min / 2; i >= 2; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    return i;
                }
            }

            return 0;
        }

        //8. The user enters a positive integer that is the cube of the integer N. Find the number N using binary search algorithm.

        //9. The user enters number.Find the number of odd digits of this number.
        static int GetNumberOfOdd (int a)
        {
            int result = 0;
            
            do
            {
                int temp = (a % 10) % 2;
                
                if (temp != 0)
                {
                    result++;
                }

            } while ((a /= 10) != 0);

            return result;
        }


        //10. The user enters number. Find a number that is a mirror image of the sequence of digits of a given number, for example, given the number 123, output 321.
        static int ReverseNumber (int a)
        {
            int result = 0;
            
            while (a != 0)
            {
                int temp = a % 10;
                result = result * 10 + temp;
                a /= 10;
            }

            return result;
        }

        //11. The user enters a positive integer (N). Print numbers in the range from 1 to N, the sum of whose even digits is greater than the sum of the odd ones.

        //12. The user enters 2 numbers.Tell me if there are the same digits in the spelling of two numbers.
        //For example, for a pair of 123 and 3456789, the answer would be “YES”, and for a pair of 500 and 99, “NO”.
        static bool CheckDigits(int a, int b)
        {
            bool result = false;

            int temp = b;

            while (a != 0)
            {
                int tempA = a % 10;

                while (b != 0)
                {
                    int tempB = b % 10;

                    if (tempA == tempB)
                    {
                        return true;
                    }

                    b /= 10;
                }
                
                b = temp;
                a /= 10;
            }

            return result;
        }
    }
}
