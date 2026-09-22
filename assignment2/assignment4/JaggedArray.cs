using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4
{
    internal class JaggedArray
    {
        static void Main()
        {
            string[] subjects = { "Math", "Science", "English" };

            int[][] scores =
            {
                new int[] { 80, 85, 90 },      
                new int[] { 75, 78 },          
                new int[] { 88, 84, 79, 91 }   
            };

            for (int i = 0; i < subjects.Length; i++)//x
            {
                int total = 0;

                Console.WriteLine($"Subject: {subjects[i]}");

                Console.Write("Scores: ");

                for (int j = 0; j < scores[i].Length; j++)//y
                {
                    Console.Write(scores[i][j] + " ");
                    total += scores[i][j];
                }

                double average = (double)total / scores[i].Length;

                Console.WriteLine();
                Console.WriteLine($"Average: {average:F2}");
                Console.WriteLine();
            }
        }
    }
}