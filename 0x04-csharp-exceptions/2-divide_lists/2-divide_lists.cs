using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listlength)
    {
        List<int> list3 = new List<int>();
        int divisionResult = 0;
        for(int i = 0; i < listlength; i++)
        {
            try
            {
            divisionResult = list1[i] / list2[i];
            list3.Add(divisionResult);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                list3.Add(0);
            }
            catch (Exception)
        {
            Console.WriteLine("Out of range");        
        }

        }
        return list3;
    }
}