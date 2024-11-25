using Tyuiu.KonevaDD.Sprint5.Task1.V8.Lib;
using System.IO;
namespace Tyuiu.KonevaDD.Sprint5.Task1.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Конева Д.Д. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *"); 
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *"); 
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила Конева Дарья Денисовна  | АСОиУб-24-1                         *"); 
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            Console.WriteLine("* Дана функция, F(x) = 4 - 2x + (2 + cos(x)/2x - 2)                       *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1.*"); 
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть        *");
            Console.WriteLine("* значение 0. результат сохранить в текстовый файл OutPutFileTaskl.txt и  *");
            Console.WriteLine("* вывести на консоль в таблицу. Значения округлить до двух знаков после   *");
            Console.WriteLine("* запятой.                                                                *"); 
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *"); 
            Console.WriteLine("***************************************************************************");
            int start = -5, end = 5; 
            Console.WriteLine("Начало диапозона:" + start);
            Console.WriteLine("Конец диапозона:" + end);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *"); 
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            string res = ds.SaveToFileTextData(start, end); 
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!"); 
            Console.WriteLine("Данные из файла:");
            Console.WriteLine(File.ReadAllText(res)); 
            Console.ReadKey();
        }
    }
}