
using System.Text.Json.Serialization;
namespace EspacioPersonajeRM
{
    public class RespuestaAPI
    {
        [JsonPropertyName("results")]
        public List<PersonajeRM> results { get; set; }
    }
    public class Locacion
    {
        [JsonPropertyName("name")]
        public string nombre { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Origen
    {
        [JsonPropertyName("name")]
        public string nombre { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class PersonajeRM
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string nombre { get; set; }

        [JsonPropertyName("status")]
        public string estado { get; set; }

        [JsonPropertyName("species")]
        public string especie { get; set; }

        [JsonPropertyName("type")]
        public string tipo { get; set; }

        [JsonPropertyName("gender")]
        public string genero { get; set; }

        [JsonPropertyName("origin")]
        public Origen origen { get; set; }

        [JsonPropertyName("location")]
        public Locacion locacion { get; set; }

        [JsonPropertyName("image")]
        public string imagen { get; set; }

        [JsonPropertyName("episode")]
        public List<string> episodio { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("created")]
        public DateTime creado { get; set; }
    }
}