using Tyuiu.KonevaDD.Sprint5.Task7.V16.Lib;
namespace Tyuiu.KonevaDD.Sprint5.Task7.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Файл находится по пути ...\\OutPutDataFileTask7V16.txt");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            ds.LoadDataAndSave(@"C:\DataSprint5\InPutDataFileTask7V16.txt");
            string text = File.ReadAllText(Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V16.txt" }));
            Console.WriteLine(text);



        }


    }



}