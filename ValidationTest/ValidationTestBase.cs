using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using TestFramework1.Helpers;

namespace TestFramework1.ValidationTest;

public abstract class ValidationTestBase
{


    protected void CheckValidationResponseBySchemaFromFile(string content, string fileName)
    {
        JObject json = JObject.Parse(content);
        JSchema jSchema = JSchema.Parse(File.ReadAllText(FileHelper.GetFilePathByFileName(fileName)));
        bool resalt = json.IsValid(jSchema, out IList<string> messages);
        Assert.IsTrue(resalt, string.Join(",", messages.ToArray()));
    }
    
}