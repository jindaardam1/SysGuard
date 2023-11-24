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

namespace SysGuard.Vista
{
    /// <summary>
    /// Lógica de interacción para Monitoreo.xaml
    /// </summary>
    public partial class Monitoreo : UserControl
    {
        public List<Sensor> Sensores { get; set; }
        public Monitoreo()
        {
            InitializeComponent();
            CargarDatosSimulados();
        }

        private void CargarDatosSimulados()
        {
            Sensores = ObtenerSensores();

            // Enlazar el DataGrid a la lista de sensores
            dataGrid.ItemsSource = Sensores;
        }

        public static List<Sensor> ObtenerSensores()
        {
            return new List<Sensor>
            {
                new Sensor { Nombre = "CPU Usage", Actual = 25, Min = 10, Media = 30, Max = 50 },
                new Sensor { Nombre = "RAM Usage", Actual = 65, Min = 40, Media = 70, Max = 90 },
                new Sensor { Nombre = "Disk Usage", Actual = 40, Min = 20, Media = 45, Max = 60 },
                new Sensor { Nombre = "GPU Usage", Actual = 20, Min = 5, Media = 25, Max = 40 },
                new Sensor { Nombre = "Temperature", Actual = 45, Min = 35, Media = 50, Max = 65 },
                new Sensor { Nombre = "Fan Speed", Actual = 1300, Min = 800, Media = 1400, Max = 1600 },
                new Sensor { Nombre = "Network Usage", Actual = 60, Min = 30, Media = 70, Max = 80 },
                new Sensor { Nombre = "Power Consumption", Actual = 110, Min = 80, Media = 120, Max = 130 },
                new Sensor { Nombre = "Voltage", Actual = 5.2, Min = 4.5, Media = 5.3, Max = 5.5 },
                new Sensor { Nombre = "Disk Temperature", Actual = 50, Min = 40, Media = 55, Max = 60 },
                new Sensor { Nombre = "GPU Temperature", Actual = 60, Min = 50, Media = 65, Max = 70 },
                new Sensor { Nombre = "CPU Temperature", Actual = 55, Min = 45, Media = 60, Max = 65 },
                new Sensor { Nombre = "Battery Level", Actual = 80, Min = 70, Media = 85, Max = 90 },
                new Sensor { Nombre = "CPU Fan Speed", Actual = 1500, Min = 1200, Media = 1600, Max = 1800 },
                new Sensor { Nombre = "GPU Fan Speed", Actual = 1400, Min = 1000, Media = 1500, Max = 1700 },
                new Sensor { Nombre = "System Load", Actual = 70, Min = 50, Media = 80, Max = 90 },
                new Sensor { Nombre = "Battery Temperature", Actual = 40, Min = 35, Media = 45, Max = 50 },
                new Sensor { Nombre = "Memory Latency", Actual = 20, Min = 15, Media = 25, Max = 30 },
                new Sensor { Nombre = "CPU Latency", Actual = 18, Min = 12, Media = 20, Max = 25 },
                new Sensor { Nombre = "Network Latency", Actual = 30, Min = 25, Media = 35, Max = 40 },
                new Sensor { Nombre = "Disk Latency", Actual = 25, Min = 20, Media = 30, Max = 35 },
                new Sensor { Nombre = "GPU Latency", Actual = 22, Min = 18, Media = 25, Max = 28 },
                new Sensor { Nombre = "Internet Speed", Actual = 100, Min = 80, Media = 110, Max = 120 },
                new Sensor { Nombre = "System Errors", Actual = 5, Min = 3, Media = 6, Max = 8 },
                new Sensor { Nombre = "Disk Errors", Actual = 2, Min = 1, Media = 3, Max = 4 },
                new Sensor { Nombre = "GPU Errors", Actual = 1, Min = 0, Media = 2, Max = 3 },
                new Sensor { Nombre = "CPU Errors", Actual = 3, Min = 2, Media = 4, Max = 5 },
                new Sensor { Nombre = "Memory Errors", Actual = 4, Min = 3, Media = 5, Max = 6 },
                new Sensor { Nombre = "Network Errors", Actual = 8, Min = 6, Media = 9, Max = 10 },
                new Sensor { Nombre = "Disk Space", Actual = 70, Min = 60, Media = 75, Max = 80 }
            };
        }
    }

    public class Sensor
    {
        public string Nombre { get; set; }
        public double Actual { get; set; }
        public double Min { get; set; }
        public double Media { get; set; }
        public double Max { get; set; }
    }
}
