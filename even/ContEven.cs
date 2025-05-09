using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_maram
{
    public class CountEvens
    {
        public static void CountEvens(int[] numbers, ref int count)
        {

           count = 0;

            Console.WriteLine("The even numbers :");

            for (int i = 0; i < 20; i++)
            {

                if (numbers[i] % 2 == 0)
                {

                    count++;

                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine($"count of even numbers: {count}");
        }
    }

}