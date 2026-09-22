using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4
{
    internal class singleD
    {

        static void Main()
        {
            String[] products = ["Laptop", "Smartphone", "Tablet", "Monitor", "Keyboard"];
            Console.WriteLine("Enter product to search:  ");
            var input = Console.ReadLine();
            if (products.IndexOf(input) == -1) {

                Console.WriteLine("Product is not available");
            }else
            {
                Console.WriteLine("product is available");
            }


        }
    }
}
