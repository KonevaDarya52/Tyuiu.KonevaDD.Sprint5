using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KonevaDD.Sprint5.Task7.V16.Lib
{
    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)    
        {

            string SavePath = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V16.txt" });
            FileInfo fileInfo = new FileInfo(SavePath);
            if (fileInfo.Exists) fileInfo.Delete();

            string[] words = File.ReadAllText(path).Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 2) words[i] = "XY";
            }
            string newFile = string.Join(" ", words);
            File.WriteAllText(SavePath, newFile);
            return SavePath;
        }
    }
}
