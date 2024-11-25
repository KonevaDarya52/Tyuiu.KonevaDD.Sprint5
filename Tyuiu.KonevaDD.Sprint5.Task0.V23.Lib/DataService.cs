using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KonevaDD.Sprint5.Task0.V23.Lib
{
    public class DataService : ISprint5Task0V23
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" }); double z = Math.Round((1 + Math.Pow(x, 3)) / Math.Pow(x, 2), 3);
            File.WriteAllText(path, Convert.ToString(z)); return path;
        }
    }
}