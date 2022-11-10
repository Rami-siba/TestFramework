using System.Net;
using System.Net.Http.Json;
using System.Text;
using Newtonsoft.Json;
using TestFramework.Model;

namespace TestFramework
{
    public class PostStoresTest : TestBase 
    {
        private string Api = "https://petstore.swagger.io/v2/store/order";

        [Test]
        public async Task PostStoresTesting()
        {
            HttpClient client = new HttpClient();
            string body = "{\"id\": 1, \"petId\": 1, \"quantity\": 1, \"shipDate\": \"2022-10-29T05:32:33.012Z\", " +
                          "\"status\": \"placed\", \"complete\": true}";
            var postContent = new StringContent(body, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(Api, postContent);

            string content = await result.Content.ReadAsStringAsync();
            Store? response = JsonConvert.DeserializeObject<Store>(content);
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode, "Код ответа от апи не соответсвует ожидаемому");
            CustomAssertAreEqual(1, response.Id);
        }

        [Test]
        public async Task PostStoresByObjectTesting()
        {
            HttpClient client = new HttpClient();

            var request = new Store()
            {
                Id = 1,
                PetId = 1,
                Quantity = 1,
                ShipDate = "2022-10-29T05:32:33.012Z",
                Status = "placed",
                Complete = true
            };

            var result = await client.PostAsJsonAsync(Api, request);
            Console.WriteLine(await result.Content.ReadAsStringAsync());
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode, "Код ответа от апи не соответсвует ожидаемому");
        } 
    }
}