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

        public void insertar(Cancion cancion)
        {
            NodoArbol nuevoNodo = new NodoArbol(cancion);
            if (this.raiz == null)
            {
                this.raiz = nuevoNodo;
                return; 
            }
            NodoArbol aux = this.raiz;
            recursividadInsertar(aux, nuevoNodo);
        }

        public void recursividadInsertar(NodoArbol? aux, NodoArbol? nuevoNodo)
        {
            if (nuevoNodo == null || aux == null)
            {
                return;
            }
            int comparacion = string.Compare(nuevoNodo.getLlave(), aux.getLlave());
            if (comparacion == 0)
            {
                return;
            }
            else if (comparacion < 0)
            {
                if (aux.getIzquierdo() == null)
                {
                    aux.setIzquierdo(nuevoNodo);
                    nuevoNodo.setPadre(aux);
                    return;
                }
                else
                {
                    recursividadInsertar(aux.getIzquierdo(), nuevoNodo);
                }
            }
            else
            {
                if (aux.getDerecho() == null)
                {
                    aux.setDerecho(nuevoNodo);
                    nuevoNodo.setPadre(aux);
                    return;
                }
                else
                {
                    recursividadInsertar(aux.getDerecho(), nuevoNodo);
                }
            }
        }

        public NodoArbol? buscar(string llave)
        {
            NodoArbol? aux = this.raiz;
            if (aux == null)
            {
                return null;
            }
            else
            {
                return recursividadBuscar(aux, llave);
            }
        }
        public NodoArbol? getRaiz()
        {
            return this.raiz;
        }
        public NodoArbol? recursividadBuscar(NodoArbol? aux, String llave)
        {
            if (aux == null)
            {
                return null;
            }

            int comparacion = string.Compare(llave, aux.getLlave());
            if (comparacion == 0)
            {
                return aux;
            }
            else if (comparacion < 0)
            {
                if (aux.getIzquierdo() == null)
                {
                    return null;
                }
                else
                {
                    return recursividadBuscar(aux.getIzquierdo(), llave);
                }
            }
            else
            {
                if (aux.getDerecho() == null)
                {
                    return null;
                }
                else
                {
                    return recursividadBuscar(aux.getDerecho(), llave);
                }
            }
        }
        
    }
}