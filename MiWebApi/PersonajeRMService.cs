using System.Text.Json;
using EspacioPersonajeRM;

namespace EspacioPersonajeRMService
{

    public static class PersonajeRMService
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task<List<PersonajeRM>> ObtenerPersonajesRMAsync()
        {
            var url = $"https://rickandmortyapi.com/api/character/?page={new Random().Next(0, 42)}";
            using HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            RespuestaAPI respuestaAPI = JsonSerializer.Deserialize<RespuestaAPI>(responseBody);
            List<PersonajeRM> listaPersonajes = respuestaAPI.results.ToList();
            Console.WriteLine(listaPersonajes.Count);
            return listaPersonajes;
        }
    }


}