using System.Net;
using Newtonsoft.Json;
using TestFramework.Model;
using RestSharp;
using TestFramework;

namespace TestFramework1;

public class GetSpeciesRestSharpTest : TestBase
{
    private string Endpoint;
        
    [SetUp]
    public void BeforeTest()
    {
        Endpoint = "/species/";
    }
        
    [Test]
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    [TestCase(4)]
    public void GetSpeciesByRestSharpTesting(int page)
    {
        var client = new RestClient();
        RestRequest request = new RestRequest(Host + Endpoint, Method.Get);
        request.AddParameter("page", page);
        RestResponse response = client.Execute(request);
        ResponseSpecies result = JsonConvert.DeserializeObject<ResponseSpecies>(response.Content);
        
        /*Assert.Multiple(() =>
        {
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(result.Next);
            Assert.AreEqual(result.Count, 37);
            Assert.Null(result.Previous);
            Assert.IsNotEmpty(result.Results);
        });*/
        
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        CustomAssertAreEqual(result.Count, 37);
    }
}