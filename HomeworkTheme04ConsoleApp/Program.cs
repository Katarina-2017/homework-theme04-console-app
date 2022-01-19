// Импорт сторонних пространств имён
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Пространство имён HomeworkTheme04ConsoleApp
/// </summary>
namespace HomeworkTheme04ConsoleApp
{
    /// <summary>
    /// Главная составляющая единица приложения - класс
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в приложение
        /// </summary>
        /// <param name="args">Параметры запуска</param>
        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание 1. Случайная матрица");                  //вывод текста в консоль
            Console.Write("Введите количество строк в будущей матрице: ");
            int row = int.Parse(Console.ReadLine());            //считываем количество строк и преобразуем в целый тип данных

            Console.Write("Введите количество столбцов в будущей матрице: ");   //вывод текста в консоль
            int col = int.Parse(Console.ReadLine());            //считываем количсетво столбцов и преобразуем в целый тип данных

            int[,] matrix = new int[row, col];                  //задание двумерного массива, в котором row строки и col столбца

            int sum = 0;                                        //обнуление суммы

            Random random = new Random();                       //создаем генератор псевдослучайных чисел

            for (int i = 0; i < row; i++)                       //перебираем элементы массива по строчно
            {
                for (int j = 0; j < col; j++)                   //перебираем элементы массива по столбцам
                {
                    matrix[i, j] = random.Next(0, 10);          //каждому элементу массива присваиваем значение из диапазона от 0 до 10
                    Console.Write($" {matrix[i, j]}\t");        //выводим данный элемент на экран
                    sum += matrix[i, j];                        //находим сумму всех элементов массива
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Cуммa всех элементов этой матрицы: {sum} ");    //выводим найденную сумму на экран

            Console.WriteLine("Задание 2. Наименьший элемент в последовательности");    //вывод текста в консоль
            Console.Write("Введите длину последовательности: ");
            int lengthArray = int.Parse(Console.ReadLine());                            //считываем длину массива и преобразуем в целый тип данных

            int[] userArray = new int[lengthArray];                                     //задание двумерного массива заданной длины

            Console.WriteLine($"Введите {lengthArray} элементов массива");
            for (int i = 0; i < lengthArray; i++)                                       //организуем ввод с клавиатуры элементов массива, заданной длины
            {
                userArray[i] = int.Parse(Console.ReadLine());
            }

            int minValueUserArray = int.MaxValue;           //задаем начальное значение минимального числа
            for (int i = 0; i < lengthArray; i++)           //организуем перебор элементов массива
            {
                if (userArray[i] < minValueUserArray)       //находим минимальный элемент массива
                {
                    minValueUserArray = userArray[i];
                }
            }

            Console.WriteLine($"Наименьший элемент в данном массиве {minValueUserArray}"); //выводим минимальный элемент массива на экран

            Console.WriteLine("Задание 3. Игра \"Угадай число\"");      //вывод надписи в консоль
            Console.Write("Введите верхнюю границу диапазона: ");
            int userNumber = int.Parse(Console.ReadLine());             //считываем верхнюю границу диапазона и преобразуем в целый тип данных

            Random randomUser = new Random();                           //создаем генератор случайных чисел
            int randomNumber = randomUser.Next(0, userNumber);          //создаем загадонное программой число из диапазона от 0 до введенного пользователем

            while (true)            //организуем бесконечный цикл
            {
                Console.WriteLine("Введите загаданное программой число:");      //вывод надписи в консоль
                string userString = Console.ReadLine();                         //считываем введенную строку

                if (String.IsNullOrEmpty(userString))                           //если строка пустая, то показываем загаданное программой число и выходим из цикла
                {
                    Console.WriteLine($"Число, загадонное программой было {randomNumber}");
                    break;
                }
                else if (int.TryParse(userString, out var numberResult))    //если строка непустая и введенный символ можно преобразовать в число
                {
                    if (numberResult < randomNumber)                           //сравниваем это число, с загаданным программой и если оно меньше
                    {
                        Console.WriteLine("Введенное число меньше загадонного программой");     //выводим соотвествующее уведомление, продолжаем ввод

                    }
                    else if (numberResult > randomNumber)                      //сравниваем это число, с загаданным программой и если оно больше
                    {
                        Console.WriteLine("Введенное число больше загадонного программой");     //выводим соотвествующее уведомление, продолжаем ввод

                    }
                    //если введенное число равно загаданному, то выводим соотвествующее уведомление и выходим из цикла
                    else
                    {
                        Console.WriteLine("Поздравляем!!! Вы угадали число, загадонное программой!!!");
                        break;
                    }
                }
                //если строка непустая и введенный символ нельзя преобразовать в число
                else
                {
                    Console.WriteLine("Упс, некорректный ввод, продолжаем...");         //выводим соотвествующее уведомление, продолжаем ввод
                }
            }

            Console.ReadKey();                                                         //задержка экрана
        }
    }
}
