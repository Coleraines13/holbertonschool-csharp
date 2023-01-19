using System;

class List
{
    public static void divide(int a, int b)
    {
        int result = 0;
        try
        {
            result = a / b;
        }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divivde by zero");
            }
            finally
            {
                Console.WriteLine($"{a} / {b} = {result}");
            }
    }
}