using ReproductorMusical.Models;
namespace ReproductorMusaical.Estructuras
{
    public class NodoArbol
    {
        private NodoArbol? padre { get; set; }
        private NodoArbol? izquierdo { get; set; }
        private NodoArbol? derecho { get; set; }
        private int llave { get; set; }
        private Cancion cancion { get; set; }


        public NodoArbol(int llave, Cancion cancion)
        {
            this.llave = llave;
            this.cancion = cancion;
            this.izquierdo = null;
            this.derecho = null;
            this.padre = null;
        }

        public NodoArbol? getIzquierdo()
        {
            return this.izquierdo;
        }
        public void setIzquierdo(NodoArbol? izquierdo)
        {
            this.izquierdo = izquierdo;
        }

        public NodoArbol? getDerecho()
        {
            return this.derecho;
        }
        public void setDerecho(NodoArbol? derecho)
        {
            this.derecho = derecho;
        }

        public NodoArbol? getPadre()
        {
            return this.padre;
        }
        public void setPadre(NodoArbol? padre)
        {
            this.padre = padre;
        }
        public int getLlave()
        {
            return this.llave;
        }
        public void setLlave(int llave)
        {
            this.llave = llave;
        }
        public Cancion getCancion()
        {
            return this.cancion;
        }
        public void setCancion(Cancion cancion)
        {
            this.cancion = cancion;
        }
    }
}