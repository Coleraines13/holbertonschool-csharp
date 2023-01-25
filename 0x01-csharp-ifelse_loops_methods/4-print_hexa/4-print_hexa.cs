Using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 'a'; i <= 'z'; i++)
            {
                string hex = i.ToString("x");
                Console.WriteLine($"{i} = 0x{hex}");
            }
        }
    }
}