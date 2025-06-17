using System.Text.Json.Serialization;

namespace EspacioUsuario
{

    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Direccion
    {
        [JsonPropertyName("street")]
        public string street { get; set; }

        [JsonPropertyName("suite")]
        public string suite { get; set; }

        [JsonPropertyName("city")]
        public string city { get; set; }

        [JsonPropertyName("zipcode")]
        public string zipcode { get; set; }

        [JsonPropertyName("geo")]
        public Geo geo { get; set; }
    }

    public class Empresa
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("catchPhrase")]
        public string catchPhrase { get; set; }

        [JsonPropertyName("bs")]
        public string bs { get; set; }
    }

    public class Geo
    {
        [JsonPropertyName("lat")]
        public string lat { get; set; }

        [JsonPropertyName("lng")]
        public string lng { get; set; }
    }

    public class Usuario
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string nombre { get; set; }

        [JsonPropertyName("username")]
        public string nickname { get; set; }

        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonPropertyName("address")]
        public Direccion direccion { get; set; }

        [JsonPropertyName("phone")]
        public string telefono { get; set; }

        [JsonPropertyName("website")]
        public string sitioWeb { get; set; }

        [JsonPropertyName("company")]
        public Empresa empresa { get; set; }
    }



}