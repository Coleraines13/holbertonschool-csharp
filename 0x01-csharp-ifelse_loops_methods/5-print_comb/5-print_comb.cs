Using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 'a'; i <= 'z'; i++)
            {
                string separator = ", ";

                if (i == 99) seperator = "\n";
                System.Console.Write($"(i:d2}{separator}");

            }
        }
    }
}