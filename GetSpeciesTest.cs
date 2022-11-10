using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TestFramework.Model;

namespace TestFramework1;

public class Tests
{
    private HttpClient _client;
    private const string Host = "https://swapi.dev/api";
    private const string Endpoint = "/species";
    
    [OneTimeSetUp]
    
    public void BeforeClass()
    {
        
        _client = new HttpClient();
    }

    [Test]
    public async Task GetSpeciesTesting()
    {
        var result = await _client.GetAsync(Host + Endpoint);
        string content = await result.Content.ReadAsStringAsync();
        JObject json = JObject.Parse(content);
        Assert.AreEqual(HttpStatusCode.OK, result.StatusCode, "Код ответа от апи не соответсвует ожидаемому");
        Assert.AreEqual("37", json["count"].ToString());
        Assert.NotNull(json["next"]);
    }

    [Test]
    public async Task GetSpeciesByObjectTesting()
    {
        var result = await _client.GetAsync(Host + Endpoint);
        string content = await result.Content.ReadAsStringAsync();
        ResponseSpecies response = JsonConvert.DeserializeObject<ResponseSpecies>(content);
  
        Assert.AreEqual(HttpStatusCode.OK, result.StatusCode, "Код ответа от апи не соответсвует ожидаемому");
    }
}