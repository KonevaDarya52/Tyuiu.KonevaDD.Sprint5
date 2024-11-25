using Tyuiu.KonevaDD.Sprint5.Task0.V23.Lib;
namespace Tyuiu.KonevaDD.Sprint5.Task0.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); 
            Console.Title = "Спринт №5 | Выполнила: Конева Д. Д. | АСОиУБ-24-1";
            Console.WriteLine("***************************************************************************"); 
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *"); 
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #23                                                             *"); 
            Console.WriteLine("* Выполнила: Конева Дарья Денисовна | АСОиУБ-24-1                         *");
            Console.WriteLine("***************************************************************************"); 
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *"); 
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *"); 
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *"); 
            Console.WriteLine("***************************************************************************");
            int x = 3;
            Console.WriteLine("x = " + x);
            Console.WriteLine("***************************************************************************"); 
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!"); Console.ReadKey();
        }
    }
}