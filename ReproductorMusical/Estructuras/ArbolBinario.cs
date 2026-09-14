using ReproductorMusical.Models;
namespace ReproductorMusical.Estructuras
{
    public class ArbolBinario
    {
        private NodoArbol? raiz { get; set; }

        public ArbolBinario()
        {
            this.raiz = null;
        }

        public void insertar(int llave, Cancion cancion)
        {
            NodoArbol nuevoNodo = new NodoArbol(llave, cancion);
            if (this.raiz == null)
            {
                this.raiz = nuevoNodo;
            }
            else
            {
                NodoArbol aux = this.raiz;
                while (aux != null)
                {
                    nuevoNodo.setPadre(aux);
                }
            }
        }


        
    }
}