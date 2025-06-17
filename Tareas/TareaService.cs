using EspacioTarea;
using System.Text.Json;

namespace EspacioTareaService
{

    public static class TareaService
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<Tarea>> ObtenerTareaAsync()
        {
            var url = "https://jsonplaceholder.typicode.com/todos/";
            using HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            List<Tarea> tareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody);
            return tareas;
        }

    }



}