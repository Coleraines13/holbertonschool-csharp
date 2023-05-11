using System;
using System.Text;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDim = new int[6, 5];
            twoDim[2, 2] = 1;
            int n = 0;
            
            StringBuilder anyStringToBuild = new StringBuilder();
            foreach(int i in twoDim)
            {
                if (n == 5)
                {
                    Console.WriteLine(anyStringToBuild);
                    anyStringToBuild.Clear();
                    n = 0;
                }
                anyStringToBuild.Append(i);
                if (n != 4)
                    anyStringToBuild.Append(" ");
                n += 1;
            }
        }
    }
}