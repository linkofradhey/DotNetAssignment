using System;
using System.Collections.Generic;
using System.Text;

namespace assigment1
{
    internal class mdja
    {
        static void Main()
        {
            int[][,] MuliDJA = new int[2][,];
            MuliDJA[0] = new int[,] { { 11, 22, 33 }, { 44, 55, 66 } };
            MuliDJA[1] = new int[,] { { 56, 67, 78 }, { 65, 87, 98 } };

            for (int i = 0;i < MuliDJA.Length; i++)
            {
                Console.WriteLine($"{i}");
                for (int row = 0; row < MuliDJA[i].GetLength(0); row++)
                {
                    for (int col = 0; col < MuliDJA[i].GetLength(1); col++)
                    {
                        Console.Write(MuliDJA[i][row, col] + "\t");
                    }
                    Console.WriteLine() ;
                }
                Console.WriteLine();
            }
        }

    }
}
