using System;

namespace _4_print_hexa
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