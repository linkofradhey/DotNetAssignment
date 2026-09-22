using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    internal class IfStatement
    {
        static void Main()
        {
            Console.WriteLine($"income = ");
            var Income = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"Credit score = ");
            var creditScore = Convert.ToInt32(Console.ReadLine());


            if (Income is >= 30000 && creditScore >= 700)
            {
                Console.WriteLine("loan approved ");

            }
            else
            {
                Console.WriteLine("not approved");
            }
        }

    }
}
