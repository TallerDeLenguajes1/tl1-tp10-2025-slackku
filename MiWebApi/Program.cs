using System.Text.Json;
using EspacioPersonajeRM;
using EspacioPersonajeRMService;

internal class Program
{
    private static async Task Main(string[] args)
    {
        List<PersonajeRM> listaPersonajes = await PersonajeRMService.ObtenerPersonajesRMAsync();
        listaPersonajes.ForEach(p =>
        {
            Console.WriteLine("##############################");
            Console.WriteLine($"Nombre: {p.nombre}");
            string estado = (p.estado.Equals("Dead")) ? "Muerto" : "Vivo";
            Console.WriteLine($"Estado: {estado}");
            Console.WriteLine($"Especie: {p.especie}");
            Console.WriteLine($"Tipo: {p.tipo}");
            string genero = (p.genero.Equals("Male")) ? "Masculino" : "Femenino";
            Console.WriteLine($"Genero: {genero}");
            Console.WriteLine($"Origen: {p.origen.nombre}");
            Console.WriteLine($"Ubicacion Actual: {p.locacion.nombre}");
            Console.WriteLine($"Creado: {p.creado}");
        });

        string jsonString;
        try
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            jsonString = JsonSerializer.Serialize(listaPersonajes, options);
            Console.WriteLine("Json generado correctamente");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error generando el JSON: {ex.Message}");
            return;
        }

        string direccionJson = "personajesRM.json";
        try
        {
            File.WriteAllText(direccionJson, jsonString);
            Console.WriteLine($"Archivo generado exitosamente en: {Path.GetFullPath(direccionJson)}");
        }
        catch (Exception) { throw; }
    }


}
