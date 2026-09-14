using System;
using System.Windows.Forms;
using ReproductorMusical.Forms;

namespace ReproductorMusical;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new VentanaPrincipal());
    }
}
