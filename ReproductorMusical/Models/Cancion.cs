
namespace ReproductorMusical.Models
{
    public class Cancion
    {
        public string titulo { get; set; }
        public string artista { get; set; }
        public string genero { get; set; }
        public int duracion { get; set; }

        public Cancion()
        {
            this.titulo = string.Empty;
            this.artista = string.Empty;
            this.genero = string.Empty;
            this.duracion = 0;
        }

        public Cancion(string titulo, string artista, string genero, int duracion)
        {
            this.titulo = titulo;
            this.artista = artista;
            this.genero = genero;
            this.duracion = duracion;
        }

        public string getTitulo()
        {
            return titulo;
        }

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string getArtista()
        {
            return artista;
        }

        public void setArtista(string artista)
        {
            this.artista = artista;
        }

        public string getGenero()
        {
            return genero;
        }

        public void setGenero(string genero)
        {
            this.genero = genero;
        }

        public int getDuracion()
        {
            return duracion;
        }

        public void setDuracion(int duracion)
        {
            this.duracion = duracion;
        }
    }
}