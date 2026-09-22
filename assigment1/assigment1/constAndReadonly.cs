using System;
using System.Collections.Generic;
using System.Text;

namespace assigment1
{
    class Program
    {
        public const double taxRate = 18.0;
        public readonly int manufacturyear;
        public Program(int year)
        {
            manufacturyear = year;
        }

        public void Display()
        {
            Console.WriteLine(taxRate);
            Console.WriteLine(manufacturyear);
        }
    }

    internal class constAndReadonly
    {
        static void Main()
        {
            Program lap = new Program(25);
            lap.Display();
            
        }
    }

}
