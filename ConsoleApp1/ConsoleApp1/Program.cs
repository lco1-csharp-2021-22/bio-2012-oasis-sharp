using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            primeFactors(10);    
        }

        static int primeFactors(int i)
        {
            List<int> listOfFactors = new List<int>();

            for (int x = 2; x <= i; x++)
                if (i % x == 0 && x != 1)
                {
                    listOfFactors.Add(x);
                    i = i / x;
                    
                }
            
            listOfFactors = listOfFactors.Distinct().ToList();
            int num = 1;

            for(i = 0; i < listOfFactors.Count; i++)
            {
                num *= listOfFactors[i];
            }

            return num;
        }

    }
}
