using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LoopingStatement
{
    internal class forEach
    {
        static void Main()
        {
            string[] products = { "Laptop", "Smartphone", "Headphones", "Tablet", "Smartwatch" };

            string[] outOfStock = { "Smartphone", "Tablet" }; // List of out-of-stock items 

        


            foreach (string product in products)
            {
                Console.WriteLine("Checking product availability: ");
                if (outOfStock.IndexOf(product)== -1)
                {
                    Console.WriteLine($"{product} not in stock");

                }
                else
                {
                    Console.WriteLine($"{product}  in stock");
                }
            }


        }
    }
}
