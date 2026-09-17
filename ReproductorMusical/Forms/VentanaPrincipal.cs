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
        private NodoCola? aux;
        private NodoArbol? busqueda;
        public VentanaPrincipal()
        {
            InitializeComponent();
            cola = new ColaReproduccion();
            arbol = new ArbolBinario();
            cancionService = new CancionService();
            cargarCanciones();
            aux = cola.getInicio();
            play();
        }

        public void play(){
            if (aux == null)
            {
                MessageBox.Show("No se encontraron canciones para reproducir.");
                return;
            }
            tituloTxt.Text = aux.getCancion().getTitulo();
            artistaTxt.Text = aux.getCancion().getArtista();
            generoTxt.Text = aux.getCancion().getGenero();
            duracionTxt.Text = aux.getCancion().getDuracion().ToString();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void cargarCanciones()
        {
            if (cancionService == null || cola == null || arbol == null)
            {
                return;
            }

            Cancion[] canciones = cancionService.cargarCanciones();
            foreach (Cancion cancion in canciones)
            {
                cola.encolar(cancion);
                arbol.insertar(cancion);
            }
        }

        private void siguiente()
        {
            if (aux == null || aux.getSiguiente() == null)
            {
                return;
            }
            aux = aux.getSiguiente();
            play();
        }

        private void Label1_Click(object sender, System.EventArgs e)
        {

        }

        private void Label2_Click(object sender, System.EventArgs e)
        {

        }

        private void siguienteBtn_Click(object sender, System.EventArgs e){
            siguiente();
        }

        private void buscarBtn_Click(object sender, System.EventArgs e){
            if (arbol == null)
            {
                return;
            }

            string tituloBuscado = busquedaTextBox.Text.Trim();
            errorTxt.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(tituloBuscado))
            {
                errorTxt.Text = "Escribe el título de una canción";
                return;
            }

            busqueda = null;
            busqueda = arbol.buscar(tituloBuscado);
            if(busqueda == null)
            {
                errorTxt.Text = "La canción seleccionada no existe";
                return;
            }
            tituloTxt.Text = busqueda.getCancion().getTitulo();
            artistaTxt.Text = busqueda.getCancion().getArtista();
            generoTxt.Text = busqueda.getCancion().getGenero();
            duracionTxt.Text = busqueda.getCancion().getDuracion().ToString();

        }
    }
}