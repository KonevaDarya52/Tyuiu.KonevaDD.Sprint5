using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
namespace Tyuiu.KonevaDD.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            string content;
            using (StreamReader sr = new StreamReader(path))
            {
                content = sr.ReadToEnd().Trim();
            }

            double x;
            if (!double.TryParse(content, NumberStyles.Any, CultureInfo.InvariantCulture, out x))
            {
                content = content.Replace(',', '.');
            }

            double y = Math.Sin(Math.Pow(x, 3)) + (2 / x);

            return Math.Round(y, 3);
        }
    }
}
