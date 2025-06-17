using System.IO.Compression;
using System.Text.Json;
using EspacioTarea;
using EspacioTareaService;

internal class Program
{
    private static async Task Main(string[] args)
    {
        List<Tarea> listaTareas = await TareaService.ObtenerTareaAsync();

        List<Tarea> tareasOrdenadas = listaTareas.OrderByDescending(t => t.completed.Equals(false)).ToList();

        string estado;
        tareasOrdenadas.ForEach(t =>
        {
            Console.WriteLine("···································");
            Console.WriteLine($"Tarea Id: {t.id}");
            Console.WriteLine($"Descripcion: {t.title}");
            if (t.completed)
            {
                estado = "Terminada";
            }
            else
            {
                estado = "Pendiente";
            }
            Console.WriteLine($"Estado: {estado}");

        });
        string jsonString;
        try
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            jsonString = JsonSerializer.Serialize(tareasOrdenadas, options);
            Console.WriteLine("Json generado correctamente");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error generando el JSON: {ex.Message}");
            return;
        }

        string direccionJson = "tareasOrdenadas.json";
        try
        {
            File.WriteAllText(direccionJson, jsonString);
            Console.WriteLine($"Archivo generado exitosamente en: {Path.GetFullPath(direccionJson)}");
        }
        catch (Exception) { throw; }
    }
}