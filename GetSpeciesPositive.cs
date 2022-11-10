using Newtonsoft.Json;
using TestFramework.Model;

namespace TestFramework1;

public class GetSpeciesPositive
{
    private HttpClient _client;
    private const string Host = "https://swapi.dev/api";
    private const string Endpoint = "/species";
    private ResponseSpecies response;
        
    [OneTimeSetUp]
    public async Task BeforeClass()
    {
        
        _client = new HttpClient();
        var result = await _client.GetAsync(Host + Endpoint);
        string content = await result.Content.ReadAsStringAsync();
        response = JsonConvert.DeserializeObject<ResponseSpecies>(content);

    }
        
    [Test]
    public void CheckCountSpecies()
    {

        Assert.AreEqual(37, response.Count);
    }
        
    [Test]
    public void CheckCountPrevious()
    {
        Assert.AreEqual(null, response.Previous);
    }
}