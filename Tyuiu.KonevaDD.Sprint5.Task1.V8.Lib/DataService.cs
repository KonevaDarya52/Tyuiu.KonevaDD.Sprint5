using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KonevaDD.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            for (int i = startValue; i <= stopValue; i++)
            {
                double y;

                if (2 * i - 2 != 0)
                {
                    y = 4 - 2 * i + (2 + Math.Cos(i)) / (2 * i - 2);
                    y = Math.Round(y, 2);
                }
                else
                {
                    y = 0;
                }

                string strY = y.ToString("F2").Replace(",", ".");

                if (i != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }

            return path;
        }
    }
}