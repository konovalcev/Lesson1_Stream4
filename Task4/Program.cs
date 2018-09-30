using System;

// * Автоморфные числа. Натуральное число называется автоморфным, если оно равно последним цифрам своего квадрата.
// Например, 25 ^ 2 = 625.
// Напишите программу, которая вводит натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.

// Александр Коновальцев

namespace Lesson1_Stream4
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var N = p.AskUser();
            Console.WriteLine($"Number is automorphic: {p.IsAutomorphic(N)}");
        }

        int AskUser()
        {
            int result = 0;
            Console.WriteLine("Enter N");
            try
            {
                result = int.TryParse(Console.ReadLine(), out result) ? result : throw new Exception("Incorrect value, please, enter integer N");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        bool IsAutomorphic(int N)
        {
            var a = N * N;
            while (N > 0)
            {
                if (N % 10 != a % 10) return false;
                N /= 10;
                a /= 10;
            }
            return true;
        }
    }
}
