using ReproductorMusical.Models;
namespace ReproductorMusical.Estructuras
{
    public class ColaReproduccion
    {
        private NodoCola? inicio { get; set; }
        private NodoCola? final { get; set; }

        public ColaReproduccion()
        {
            this.inicio = null;
            this.final = null;
        }

        public void encolar(Cancion cancion)
        {
            NodoCola nuevoNodo = new NodoCola(cancion);
            if (this.inicio == null)
            {
                this.inicio = nuevoNodo;
                this.final = nuevoNodo;
            }
            else
            {
                if(this.final == null){return;}
                this.final.setSiguiente(nuevoNodo);
                this.final = nuevoNodo;
            }
        }

        public Cancion? desencolar()
        {
            if (this.inicio == null)
            {
                return null;
            }
            else
            {
                Cancion cancionDesencolada = this.inicio.getCancion();
                this.inicio = this.inicio.getSiguiente();
                if (this.inicio == null)
                {
                    this.final = null;
                }
                return cancionDesencolada;
            }
        }

        public bool EstaVacia()
        {
            return this.inicio == null;
        }

        public NodoCola? getInicio()
        {
            return this.inicio;
        }
    }
}