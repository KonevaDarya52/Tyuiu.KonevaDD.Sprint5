
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KonevaDD.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл по пути {path} не найден.");

            var lines = File.ReadAllLines(path);

            var numbers = lines.SelectMany(line =>
            {
                return line.Split(new[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(str => double.TryParse(str, out var number) ? number : double.NaN)
                           .Where(num => !double.IsNaN(num));
            });


            var divisibleByFive = numbers.Where(num => num % 5 == 0);

            var minNumber = divisibleByFive.Min();

            return Math.Round(minNumber, 3);
        }
    }
}