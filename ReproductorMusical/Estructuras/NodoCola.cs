using ReproductorMusical.Models;
namespace ReproductorMusical.Estructuras
{
    public class NodoCola
    {
        private  NodoCola? Siguiente { get; set; }
        private  Cancion Cancion { get; set; }

        public NodoCola(Cancion cancion)
        {
            this.Cancion = cancion;
            this.Siguiente = null;
        }

        public NodoCola? getSiguiente()
        {
            return this.Siguiente;
        }
        public void setSiguiente(NodoCola? siguiente)
        {
            this.Siguiente = siguiente;
        }
        public Cancion getCancion()
        {
            return this.Cancion;
        }
    }
}