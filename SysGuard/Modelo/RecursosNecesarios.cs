using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace SysGuard.Modelo
{
    public class RecursosNecesarios
    {
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern int AddFontResource(string lpszFilename);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public void InstalarFuente(string nombreArchivo)
        {
            // Obtener la ruta completa del archivo de la fuente
            string rutaFuente = AppDomain.CurrentDomain.BaseDirectory + nombreArchivo;

            // Instalar la fuente en el sistema
            int ret = AddFontResource(rutaFuente);

            if (ret != 0)
            {
                MessageBox.Show("La fuente se ha instalado correctamente.", "Instalación de fuente");
            }
            else
            {
                MessageBox.Show("No se ha podido instalar la fuente. El programa funcionará de forma normal pero con la fuente por defecto.", "Instalación de fuente");
            }
        }
    }
}
