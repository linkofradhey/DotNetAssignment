using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    internal class TernaryOperator
    {

        static void Main() {
            Console.WriteLine($"Total bill = ");
            int TBil = Convert.ToInt32(Console.ReadLine());
            int dcBil =TBil- (TBil * 20)/100;
            string calAmt = TBil >= 5000
                ? "Discount bill: " + dcBil.ToString(): "No discount bill: " + TBil.ToString();
            Console.WriteLine( calAmt );
        }
    }
}
