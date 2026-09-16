
namespace ReproductorMusical.Models
{
    public class Cancion
    {
        private string titulo;
        private string artista;
        private string genero;
        private int duracion;

        public Cancion(string titulo, string artista, string album, string genero, int duracion)
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