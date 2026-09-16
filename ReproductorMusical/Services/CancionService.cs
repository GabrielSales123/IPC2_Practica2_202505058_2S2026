
using System.Text.Json;
using ReproductorMusical.Models;

namespace ReproductorMusical.Services
{
    public class CancionService
    {
        public Cancion[] cargarCanciones()
        {
            string ruta = ResolverRutaCanciones();

            if (!File.Exists(ruta))
            {
                throw new FileNotFoundException($"No se encontró el archivo de canciones en: {ruta}");
            }

            string json = File.ReadAllText(ruta);

            if (string.IsNullOrWhiteSpace(json))
            {
                throw new InvalidOperationException("El archivo de canciones está vacío.");
            }

            JsonSerializerOptions opciones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                IncludeFields = true
            };

            Cancion[]? canciones = JsonSerializer.Deserialize<Cancion[]>(json, opciones);

            if (canciones == null)
            {
                throw new InvalidOperationException("No se pudieron cargar las canciones desde el archivo JSON.");
            }

            return canciones;
        }

        private static string ResolverRutaCanciones()
        {
            string directorioActual = AppContext.BaseDirectory;

            while (!string.IsNullOrEmpty(directorioActual))
            {
                string rutaDirecta = Path.Combine(directorioActual, "Datos", "canciones.json");
                string rutaProyecto = Path.Combine(directorioActual, "ReproductorMusical", "Datos", "canciones.json");

                if (File.Exists(rutaDirecta))
                {
                    return rutaDirecta;
                }

                if (File.Exists(rutaProyecto))
                {
                    return rutaProyecto;
                }

                DirectoryInfo? padre = Directory.GetParent(directorioActual);
                if (padre == null)
                {
                    break;
                }

                directorioActual = padre.FullName;
            }

            return Path.Combine("Datos", "canciones.json");
        }
    }
}