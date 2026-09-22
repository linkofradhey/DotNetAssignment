using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4
{
    internal class multidimensional
    {
        static void Main()
        {

            string[] students = { "Alice", "Bob", "Charlie" };
            
            string[] subjects = { "Math", "English", "Science" };
            int[,] marks =
            {
                {85,95,75 },
                {65,75,96 },
                {75,65,77 }
            };


            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Student:{students[i]}");
                //Console.WriteLine($"Marks :{marks[i,]}");
                int sum = 0;
                Console.Write("Marks: ");
                for (int j = 0; j <subjects.Length; j++) {
                    Console.Write($"{marks[i, j]}");
                    sum += marks[i, j];
                    
                }

                double avg =(double) sum / students.Length;

                Console.WriteLine();
                
Console.WriteLine($"Total: {sum}");
                
Console.WriteLine($"Average: {avg:F2}");
                
Console.WriteLine();

            }
        }
    }
}
