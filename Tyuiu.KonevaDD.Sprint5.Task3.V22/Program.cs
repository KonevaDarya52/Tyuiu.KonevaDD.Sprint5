using Tyuiu.KonevaDD.Sprint5.Task3.V22.Lib;
using System.IO;
namespace Tyuiu.KonevaDD.Sprint5.Task3.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Конева  Д. Д. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #5                                                               #");
            Console.WriteLine("# Тема: Потоковый метод записи данных в бинарный файл                     #");
            Console.WriteLine("# Задание #3                                                              #");
            Console.WriteLine("# Вариант #22                                                             #");
            Console.WriteLine("# Выполнла Конева Дарья Денисовна | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Дано выражение вычислить его значение при x = 3, результат сохранить в  #");
            Console.WriteLine("# бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до    #");
            Console.WriteLine("# трёх знаков после запятой.                                              #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int x = 3;
            Console.WriteLine("Переменная x = " + x);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            string res = ds.SaveToFileTextData(x);
            using (BinaryReader reader = new BinaryReader(File.Open(@"C:\Users\konev\AppData\Local\Temp\OutPutFileTask3.bin", FileMode.Open)))
            {
                double str = reader.ReadDouble();
                Console.WriteLine(str);
            }
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}