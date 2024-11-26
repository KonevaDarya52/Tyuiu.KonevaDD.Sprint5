using tyuiu.cources.programming.interfaces.Sprint5;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Tyuiu.KonevaDD.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            var numbers = new System.Collections.Generic.List<double>();

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(new[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var part in parts)
                        {
                            if (double.TryParse(part, NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                            {
                                if (Math.Abs(number % 5) < 1e-6 && number > 0)
                                {
                                    numbers.Add(number);
                                }
                            }
                        }
                    }
                }

                if (numbers.Count > 0)
                {
                    return Math.Round(numbers.Min(), 3); 
                }
                else
                {
                    throw new InvalidOperationException("В файле нет положительных чисел, которые делятся на 5.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Произошла ошибка: {ex.Message}");
            }
        }


    }




}