using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    internal class Goto
    {
        static void Main()
        {
            int i = 0;
        SpaceHolder:
            if (i == 3) { Console.WriteLine("Access denied");

            }
            else { 

            var CorrectPassword = "CSharp@123";
            Console.WriteLine($"Password = ");
            var password = Console.ReadLine();

            if (password == CorrectPassword)
            {
                Console.WriteLine("correct");
            }
            else {
                i++;
               
                Console.WriteLine("wrong");
                goto SpaceHolder;
            }
            }

        }

    }
}
