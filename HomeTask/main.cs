﻿using System;

///////////////////////////
//  Тестування програми  //
///////////////////////////

namespace Artem
{
    class Program
    {
        static void Main()
        {
            int[,] mtx = {
                { 3, 6, 7 },
                { 1, 4, 6 },
                { 7, 2, 10 }
            };

            Matrix matrix = new Matrix(mtx);

            Console.WriteLine("Матриця:");
            matrix.PrintMatrix();

            Console.WriteLine("\nСума всiх елементiв: " + matrix.Sum);

            Console.WriteLine("Середньоквадратичнi значення рядкiв:");
            for (int i = 0; i < mtx.GetLength(0); i++)
            {
                Console.WriteLine($"\nРядок {i + 1}: {matrix.GetRowRMS(i):F2}");
            }
      
            Console.WriteLine("\nТестування доступу до елементiв матрицi:"); //тестування доступу до матриці через індексатор 
            Console.WriteLine($"Елемент у (1,2): {matrix[1, 2]}");
        }
    }
}
