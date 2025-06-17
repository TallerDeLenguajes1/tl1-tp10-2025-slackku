using System.Text.Json;
using EspacioUsuario;

namespace EspacioUsuarioService
{

    public static class UsuarioService
    {

        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<Usuario>> ObtenerUsuariosAsync()
        {
            var url = "https://jsonplaceholder.typicode.com/users/";
            using HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(responseBody);
            return usuarios;
        }

    }
}