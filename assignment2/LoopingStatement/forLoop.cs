using System;
using System.Collections.Generic;
using System.Text;

namespace LoopingStatement
{
    internal class forLoop
    {
        static void Main()
        {
            Console.WriteLine("Inital Salary = ");
            var INitalSalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Increment Rates = ");
            var IncrementRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Salary Increment for the next 5 years: ");
            for (int i = 0; i < 5; i++)
            {

                INitalSalary += (INitalSalary * IncrementRate) /100;
                Console.WriteLine($"Year {i}:{INitalSalary}");
            }
        }
    }
}
