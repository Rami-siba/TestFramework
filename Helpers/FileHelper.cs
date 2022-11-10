using System.Text.Json.Serialization;
using Newtonsoft.Json;
using TestFramework.Model;

namespace TestFramework1.Helpers;

public class FileHelper
{
    public static string GetFilePathByFileName(string fileName)
    {
        string directory = AppDomain.CurrentDomain.BaseDirectory;
        string sFile = System.IO.Path.Combine(directory, "../../../ValidationTest/contracts/" + fileName);
        string sFilePath = Path.GetFullPath(sFile);
        return sFilePath;
    }

    public static void ReadJsonFromFile(string path)
    {
        using (StreamReader r = new StreamReader(path))
        {
            string json = r.ReadToEnd();
            List<Species>? species = JsonConvert.DeserializeObject<List<Species>>(json);
        }
    }
}