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
            //Console.WriteLine("Задание 1. Случайная матрица");
            //Console.Write("Введите количество строк в будущей матрице: ");
            //int row = int.Parse(Console.ReadLine());

            //Console.Write("Введите количество столбцов в будущей матрице: ");
            //int col = int.Parse(Console.ReadLine());

            //int[,] matrix = new int[row, col];

            //int sum = 0;

            //Random random = new Random();

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        matrix[i, j] = random.Next(0, 10);
            //        Console.Write($" {matrix[i, j]}\t");
            //        sum += matrix[i, j];
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine($"Cуммa всех элементов этой матрицы: {sum} ");

            //Console.WriteLine("Задание 2. Наименьший элемент в последовательности");
            //Console.Write("Введите длину последовательности: ");
            //int lengthArray = int.Parse(Console.ReadLine());

            //int[] userArray = new int[lengthArray];

            //Console.WriteLine($"Введите {lengthArray} элементов массива");
            //for (int i = 0; i < lengthArray; i++)
            //{
            //    userArray[i] = int.Parse(Console.ReadLine());
            //}

            //int minValueUserArray = int.MaxValue;
            //for (int i = 0; i < lengthArray; i++)
            //{
            //    if (userArray[i]<minValueUserArray)
            //    {
            //        minValueUserArray = userArray[i];
            //    }
            //}

            //Console.WriteLine($"Наименьший элемент в данном массиве {minValueUserArray}");

            Console.WriteLine("Задание 3. Игра \"Угадай число\"");
            Console.Write("Введите верхнюю границу диапазона: ");
            int userNumber = int.Parse(Console.ReadLine());

            Random random = new Random();
            int randomNumber = random.Next(0, userNumber);

            while (true)
            {
                Console.WriteLine("Введите загаданное программой число:");
                string userString = Console.ReadLine();

                if (String.IsNullOrEmpty(userString))
                {
                    Console.WriteLine($"Число, загадонное программой было {randomNumber}");
                    break;
                }
                else if (int.TryParse(userString, out var numberResult))
                {
                    if (numberResult < randomNumber)
                    {
                        Console.WriteLine("Введенное число меньше загадонного программой");

                    }
                    else if (numberResult > randomNumber)
                    {
                        Console.WriteLine("Введенное число больше загадонного программой");

                    }
                    else
                    {
                        Console.WriteLine("Поздравляем!!! Вы угадали число, загадонное программой!!!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Упс, некорректный ввод, продолжаем...");
                }
            }

            Console.ReadKey();
        }
    }
}
