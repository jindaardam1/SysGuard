using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Lógica de interacción para Stress.xaml
    /// </summary>
    public partial class Stress : UserControl
    {
        public Stress()
        {
            InitializeComponent();
        }

        private void Cpu_Click(object sender, MouseButtonEventArgs e)
        {
            // Código a ejecutar cuando se hace clic en la imagen de la CPU
            MessageBox.Show("El test de estrés de CPU ha empezado", "Evento", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Gpu_Click(object sender, MouseButtonEventArgs e)
        {
            // Código a ejecutar cuando se hace clic en la imagen de la GPU
            MessageBox.Show("El test de estrés de GPU ha empezado", "Evento", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
