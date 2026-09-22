using System;
using System.Collections.Generic;
using System.Text;

namespace LoopingStatement
{
    internal class whileLoop
    {
        static void Main()
        {
            Console.WriteLine("Stock price  = ");
            var StockPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" target price  = ");
            var Targetprice = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (StockPrice<= Targetprice)
            {
                Console.WriteLine($"day{i}\t Stock price = {StockPrice}");
                StockPrice += 5;
                i++;
            }
        }
    }
}
