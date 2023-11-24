using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SysGuard
{
    /// <summary>
    /// Lógica de interacción para Ajustes.xaml
    /// </summary>
    public partial class Ajustes : UserControl
    {
        public Ajustes()
        {
            InitializeComponent();
        }

        private void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Ajustes", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Oscuro_Click(object sender, RoutedEventArgs e)
        {
            MostrarMensaje("Tema Oscuro seleccionado.");
        }

        private void Claro_Click(object sender, RoutedEventArgs e)
        {
            MostrarMensaje("Tema Claro seleccionado.");
        }

        private void Sistema_Click(object sender, RoutedEventArgs e)
        {
            MostrarMensaje("Tema del Sistema seleccionado.");
        }

        private void Si_Click(object sender, RoutedEventArgs e)
        {
            MostrarMensaje("Las pruebas pararán siempre en temperaturas críticas.");
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            MostrarMensaje("Las pruebas NO pararán nunca en temperaturas críticas.");
        }

        private void SoloGPU_Click(object sender, RoutedEventArgs e)
        {
            MostrarMensaje("Las pruebas pararán en temperaturas críticas solo en GPUs.");
        }

        private void Fahrenheit_Click(object sender, RoutedEventArgs e)
        {
            MostrarMensaje("Las temperaturas se mostrarán en grados Fahrenheit.");
        }

        private void Celsius_Click(object sender, RoutedEventArgs e)
        {
            MostrarMensaje("Las temperaturas se mostrarán en grados Celsius.");
        }

        private void UnSeg_Click(object sender, RoutedEventArgs e)
        {
            MostrarMensaje("La tasa de actualización de datos se ha establecido en 1 segundo.");
        }

        private void DosSeg_Click(object sender, RoutedEventArgs e)
        {
            MostrarMensaje("La tasa de actualización de datos se ha establecido en 2 segundos.");
        }

        private void CincoSeg_Click(object sender, RoutedEventArgs e)
        {
            MostrarMensaje("La tasa de actualización de datos se ha establecido en 5 segundos.");
        }

    }
}
