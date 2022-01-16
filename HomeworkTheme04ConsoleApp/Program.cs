using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTheme04ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Случайная матрица");
            Console.Write("Введите количество строк в будущей матрице: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов в будущей матрице: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];

            int sum = 0;

            Random random = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = random.Next(0,10);
                    Console.Write($" {matrix[i, j]}\t");
                    sum += matrix[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Cуммa всех элементов этой матрицы: {sum} ");
            Console.ReadKey();
        }
    }
}
