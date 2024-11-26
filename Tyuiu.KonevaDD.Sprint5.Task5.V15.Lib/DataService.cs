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

        Console.WriteLine("[ИНФО] Содержимое файла:");
        foreach (var line in lines)
            Console.WriteLine(line);

        var numbers = lines.SelectMany(line =>
        {
            return line.Split(new[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                       .Select(str => double.TryParse(str, out var number) ? number : double.NaN)
                       .Where(num => !double.IsNaN(num));
        }).ToList();

        Console.WriteLine("[ИНФО] Распознанные числа:");
        foreach (var num in numbers)
            Console.WriteLine(num);

        var divisibleByFive = numbers.Where(num => num > 0 && num % 5 == 0).ToList();

        if (!divisibleByFive.Any())
        {
            Console.WriteLine("[ОШИБКА] Нет положительных чисел, которые делятся на 5.");
            throw new InvalidOperationException("В файле нет положительных чисел, которые делятся на 5.");
        }

        Console.WriteLine("[ИНФО] Положительные числа, делящиеся на 5:");
        foreach (var num in divisibleByFive)
            Console.WriteLine(num);

        var minNumber = divisibleByFive.Min();

        Console.WriteLine($"[ИНФО] Минимальное положительное число, делящееся на 5: {minNumber}");

        return Math.Round(minNumber, 3);
    }
}
}