using System;
using System.Windows.Forms;
using ReproductorMusical.Estructuras;
using ReproductorMusical.Services;
using ReproductorMusical.Models;


namespace ReproductorMusical.Forms
{
    public partial class VentanaPrincipal : Form
    {
        private ColaReproduccion? cola;
        private ArbolBinario? arbol;
        private CancionService? cancionService;
        public VentanaPrincipal()
        {
            InitializeComponent();
            cola = new ColaReproduccion();
            arbol = new ArbolBinario();
            cancionService = new CancionService();
            cargarCanciones();
        }
        private void cargarCanciones()
        {
            if (cancionService == null){return;}
            Cancion[] canciones = cancionService.cargarCanciones();
            foreach (Cancion cancion in canciones)
            {
                if(cola ==null || arbol == null){return;}
                cola.encolar(cancion);
                arbol.insertar(cancion);
            }
        }
    }
}