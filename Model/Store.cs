using Newtonsoft.Json;

namespace TestFramework.Model;

public class Store
{

    [JsonProperty("id")]
    public int Id { get; set; }
        
    [JsonProperty("petId")]
    public int PetId { get; set; }
        
    [JsonProperty("quantity")]
    public int Quantity { get; set; }
        
    [JsonProperty("shipDate")]
    public string ShipDate { get; set; }
        
    [JsonProperty("status")]
    public string Status { get; set; }
        
    [JsonProperty("complete")]
    public bool Complete { get; set; }
}
