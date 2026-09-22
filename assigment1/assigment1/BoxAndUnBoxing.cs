using System;
using System.Collections.Generic;
using System.Text;

namespace assigment1
{
    internal class BoxAndUnBoxing
    {

        static void Main()
        {
            object price1 = 500;
            object price2 = 1000;

            int p1 = (int)price1;
            int p2 = (int)price2;

            int total = p1 + p2;

            Console.WriteLine(total);



        }
    }
}
