using System.Net;
using Microsoft.VisualStudio.TestPlatform.Utilities.Helpers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using FileHelper = TestFramework1.Helpers.FileHelper;

namespace TestFramework1.ValidationTest;

   public class validationTest : ValidationTestBase
   
{
    private const string Host = "https://swapi.dev/api";
    private const string Endpoint = "/species";
    
    [Test]
    public async Task GetSpeciesValidationTesting()
    {
        HttpClient client = new HttpClient();
        var response = await client.GetAsync(Host + Endpoint);
        string content = await response.Content.ReadAsStringAsync();
        CheckValidationResponseBySchemaFromFile(content, "GetSpeciesPositiveTest.json");
       
        
    }
}