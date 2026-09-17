using System.Diagnostics;
using System.Text;
using ReproductorMusical.Estructuras;

namespace ReproductorMusical.Graphviz
{
    public class GraphvizService
    {
        private readonly string directorioSalida;

        public GraphvizService()
        {
            directorioSalida = ResolverDirectorioGraphviz();
            Directory.CreateDirectory(directorioSalida);
        }

        private static string ResolverDirectorioGraphviz()
        {
            string? directorioActual = AppContext.BaseDirectory;
            while (!string.IsNullOrEmpty(directorioActual))
            {
                string candidato = Path.Combine(directorioActual, "Graphviz");
                if (Directory.Exists(candidato))
                {
                    return candidato;
                }

                directorioActual = Directory.GetParent(directorioActual)?.FullName;
            }

            return Path.Combine(AppContext.BaseDirectory, "Graphviz");
        }

        public string GenerarCola(ColaReproduccion cola)
        {
            StringBuilder dot = new StringBuilder();
            dot.AppendLine("digraph Cola {");
            dot.AppendLine("rankdir=LR; node [shape=box, style=filled, fillcolor=lightblue];");
            NodoCola? actual = cola.getInicio();
            int indice = 0;
            while (actual != null)
            {
                string nodo = $"c{indice}";
                dot.AppendLine($"{nodo} [label=\"{Escapar(actual.getCancion().getTitulo())}\"];");
                if (indice > 0) dot.AppendLine($"c{indice - 1} -> {nodo};");
                actual = actual.getSiguiente();
                indice++;
            }
            if (indice == 0) dot.AppendLine("vacio [label=\"Cola vacia\", shape=note];");
            dot.AppendLine("}");
            return Renderizar(dot.ToString(), "cola");
        }

        public string GenerarArbol(ArbolBinario arbol)
        {
            StringBuilder dot = new StringBuilder();
            dot.AppendLine("digraph Arbol {");
            dot.AppendLine("node [shape=box, style=filled, fillcolor=lightgreen];");
            NodoArbol? raiz = arbol.getRaiz();
            if (raiz == null) dot.AppendLine("vacio [label=\"Arbol vacio\", shape=note];");
            else AgregarNodoArbol(dot, raiz, "n0");
            dot.AppendLine("}");
            return Renderizar(dot.ToString(), "arbol");
        }

        private static void AgregarNodoArbol(StringBuilder dot, NodoArbol nodo, string id)
        {
            dot.AppendLine($"{id} [label=\"{Escapar(nodo.getLlave())}\"];");
            AgregarDescendiente(dot, nodo.getIzquierdo(), id, "i");
            AgregarDescendiente(dot, nodo.getDerecho(), id, "d");
        }

        private static void AgregarDescendiente(StringBuilder dot, NodoArbol? hijo, string padre, string sufijo)
        {
            if (hijo == null) return;
            string id = padre + sufijo;
            dot.AppendLine($"{id} [label=\"{Escapar(hijo.getLlave())}\"];");
            dot.AppendLine($"{padre} -> {id} [label=\"{(sufijo == "i" ? "izq" : "der")}\"];");
            AgregarDescendiente(dot, hijo.getIzquierdo(), id, "i");
            AgregarDescendiente(dot, hijo.getDerecho(), id, "d");
        }

        private string Renderizar(string contenido, string nombre)
        {
            string dotPath = Path.Combine(directorioSalida, $"{nombre}.dot");
            string pngPath = Path.Combine(directorioSalida, $"{nombre}.png");
            File.WriteAllText(dotPath, contenido, new UTF8Encoding(false));
            ProcessStartInfo inicio = new ProcessStartInfo
            {
                FileName = ResolverEjecutableDot(),
                Arguments = $"-Tpng \"{dotPath}\" -o \"{pngPath}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardError = true
            };
            using Process proceso = Process.Start(inicio) ?? throw new InvalidOperationException("No se pudo iniciar Graphviz.");
            string error = proceso.StandardError.ReadToEnd();
            proceso.WaitForExit();
            if (proceso.ExitCode != 0) throw new InvalidOperationException($"Graphviz no pudo generar el diagrama: {error}");
            return pngPath;
        }

        private static string ResolverEjecutableDot()
        {
            string rutaInstalacion = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Graphviz", "bin", "dot.exe");
            return File.Exists(rutaInstalacion) ? rutaInstalacion : "dot";
        }

        private static string Escapar(string texto)
        {
            return texto.Replace("\\", "\\\\").Replace("\"", "\\\"");
        }
    }
}