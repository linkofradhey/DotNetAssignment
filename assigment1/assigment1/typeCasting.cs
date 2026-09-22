using System;
using System.Collections.Generic;
using System.Text;

namespace assigment1
{
    internal class typeCasting
    {
        static void Main()
        {
            int amount = 1000;
            double convertedAmount = amount;
            convertedAmount += 0.75;
            int finalAmount = (int)Math.Round(convertedAmount);
            Console.WriteLine("orginal Amount:" + amount);
            Console.WriteLine("amount after cal" + convertedAmount);
            Console.WriteLine("final rounded amount:" + finalAmount);
        }

    }
}
