using System.Text.Json;
using System.Threading.Tasks;
using EspacioUsuario;
using EspacioUsuarioService;

internal class Program
{
    private static async Task Main(string[] args)
    {
        List<Usuario> listaUsuarios = await UsuarioService.ObtenerUsuariosAsync();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"########## Empleado {i + 1} ##########");
            Console.WriteLine($"Nombre: {listaUsuarios[i].nombre}");
            Console.WriteLine($"Email: {listaUsuarios[i].email}");
            Console.WriteLine($"Direccion: {listaUsuarios[i].direccion.street}");
        }

        string jsonString;
        try
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            jsonString = JsonSerializer.Serialize(listaUsuarios, options);
            Console.WriteLine("Json generado correctamente");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error generando el JSON: {ex.Message}");
            return;
        }

        string direccionJson = "usuarios.json";
        try
        {
            File.WriteAllText(direccionJson, jsonString);
            Console.WriteLine($"Archivo generado exitosamente en: {Path.GetFullPath(direccionJson)}");
        }
        catch (Exception) { throw; }
    }
}