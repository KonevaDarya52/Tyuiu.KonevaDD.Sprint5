using Tyuiu.KonevaDD.Sprint5.Task2.V18.Lib;
namespace Tyuiu.KonevaDD.Sprint5.Task2.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3] { { 3, 8, 4},
                                          { -5, -4, -3 },
                                          { -9, 0, 2 } };
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Конева Д. Д. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Конева  Дарья  Денисовна | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Заменить положительные элементы массива на 1, отрицательные на 0.       *");
            Console.WriteLine("* Результат сохранить в файл и вывести на консоль.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}