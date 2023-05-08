using System;
using System.IO;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = ReadNumberFromFile("input.txt");
            int b = ReadNumberFromFile("output.txt");

            int count = CountPairsOfCoprimeNumbers(a, b);

            Console.WriteLine($"The number of pairs of coprime numbers between {a} and {b} is {count}.");
        }

        static int ReadNumberFromFile(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line = reader.ReadLine();
                return int.Parse(line);
            }
        }

        static int CountPairsOfCoprimeNumbers(int a, int b)
        {
            int count = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    if (Gcd(i, j) == 1)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            return a;
        }
    }
}