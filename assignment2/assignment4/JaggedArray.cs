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
                new int[] { 80, 85, 90 },      // Math - 3 tests
                new int[] { 75, 78 },          // Science - 2 tests
                new int[] { 88, 84, 79, 91 }   // English - 4 tests
            };

            for (int i = 0; i < subjects.Length; i++)
            {
                int total = 0;

                Console.WriteLine($"Subject: {subjects[i]}");

                Console.Write("Scores: ");

                for (int j = 0; j < scores[i].Length; j++)
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