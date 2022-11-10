using Newtonsoft.Json;

namespace TestFramework.Model
{
    public class Species
    {
        [JsonProperty("name")] 
        public string Name { get; set; }

        [JsonProperty("classification")] 
        public string  Classification { get; set; }

        [JsonProperty("designation")] 
        public string  Designation { get; set; }

        [JsonProperty("average_height")] 
        public string Average_height { get; set; }

        [JsonProperty("skin_colors")] 
        public string Skin_colors { get; set; }

        [JsonProperty("hair_colors")] 
        public string  Hair_colors { get; set; }

        [JsonProperty("eye_colors")] 
        public string Eye_colors { get; set; }

        [JsonProperty("average_lifespan")] 
        public string Average_lifespan { get; set; }

        [JsonProperty("homeworld")] 
        public string Homeworld { get; set; }

        [JsonProperty("language")] 
        public string Language { get; set; }
        
        [JsonProperty("people")] 
        public string[] People { get; set; }

        [JsonProperty("films")] 
        public string[] Films { get; set; }

        [JsonProperty("created")] 
        public string Created { get; set; }

        [JsonProperty("edited")] 
        public string Edited { get; set; }

        [JsonProperty("url")] 
        public string Url { get; set; }
        
    }

    public class ResponseSpecies
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        
        [JsonProperty("next")]
        public string Next { get; set; }
        
        [JsonProperty("previous")]
        public string Previous { get; set; }
        
        [JsonProperty("results")]
        public Species?[] Results { get; set; }
    }
}