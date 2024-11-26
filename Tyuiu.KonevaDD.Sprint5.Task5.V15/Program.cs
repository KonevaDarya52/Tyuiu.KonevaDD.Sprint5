using System;
using System.IO;
using Tyuiu.KonevaDD.Sprint5.Task5.V15.Lib;

namespace Tyuiu.KonevaDD.Sprint5.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Конева Д. Д. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Поиск минимального значения                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Конева Дарья Денисовна | АСОиУб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл с вещественными значениями.                                    *");
            Console.WriteLine("* Найти минимальное вещественное число, которое делится на 5.             *");
            Console.WriteLine("* Результат округлить до трёх знаков после запятой.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите путь к файлу:                                                   *");
            string path = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                double result = ds.LoadFromDataFile(path);
                Console.WriteLine($"Минимальное значение, делящееся на 5: {result}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден. Убедитесь, что указали правильный путь.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.WriteLine("***************************************************************************");
        }
    }
}
