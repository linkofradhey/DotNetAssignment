using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    internal class switchCase
    {
        static void Main()
        {

            Console.WriteLine($"Department num = ");
            var Dnum = Convert.ToInt32(Console.ReadLine());

            switch (Dnum)
            {
                case 1:
                    Console.WriteLine("Redirecting to billing department");
                    break;
                case 2:
                    Console.WriteLine("Redirecting to Technical Support");
                    break;
                case 3:
                    Console.WriteLine("Redirecting to sales department");
                    break;
                default:
                    Console.WriteLine("Redirecting to invalid department number");
                    break;
            }
        }
    }
}
