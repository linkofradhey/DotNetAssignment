using System;

namespace ConsoleApp1
{
    internal class program1
    {
        public int Empcode {  get; set; }

        public string empName {  get; set; }

        public program1() 
        {

        }
        static void Main()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            int a = 1000;
            if (a > 100)
            {
                Console.WriteLine(a);

                Metod1();
                Class1.Method2();

            }
        }

        private static void Metod1()
        {
            Console.WriteLine("i am from method1");
        }
    }
}
