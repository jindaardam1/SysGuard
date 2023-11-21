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
using System.Management;
using OpenHardwareMonitor.Hardware;
using System.Diagnostics;
using System.Windows.Media.Animation;

namespace SysGuard
{
    /// <summary>
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : UserControl
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private async void GridProcesador_OnLoaded(object sender, RoutedEventArgs e)
        {
            // Obtiene la temperatura del procesador de manera asíncrona
            float temperatura = await Task.Run(() => GetTemperaturaProcesador());

            TemperaturaProcesador.Text = temperatura.ToString() + " ºC";

            // Obtiene el nombre del procesador de manera asíncrona
            string nombreProcesador = await Task.Run(() => GetNombreProcesador());

            NombreProcesador.Text = nombreProcesador;

            ToolTipService.SetToolTip(NombreProcesador, nombreProcesador);
        }


        private async void GridRAM_OnLoaded(object sender, RoutedEventArgs e)
        {
            // Obtiene la cantidad total de RAM de manera asíncrona
            ulong totalRAM = await Task.Run(() => GetTotalRAM());

            // Obtiene el porcentaje de uso de la RAM de manera asíncrona
            double ramUsagePercentage = await Task.Run(() => GetRAMUsagePercentage());

            CantidadRAM.Text = "RAM total: " + FormatBytes(totalRAM);

            PorcentajeRAM.Text = "USO DE RAM: " + ramUsagePercentage.ToString("0.00") + "%";
        }


        private async void GridGrafica_OnLoaded(object sender, RoutedEventArgs e)
        {
            // Obtiene el nombre de la tarjeta gráfica de manera asíncrona
            string nombreGrafica = await Task.Run(() => GetNombreGrafica());

            // Obtiene la temperatura de la tarjeta gráfica de manera asíncrona
            float temperaturaGrafica = await Task.Run(() => GetTemperaturaGrafica());

            NombreGrafica.Text = nombreGrafica;
            ToolTipService.SetToolTip(NombreGrafica, nombreGrafica);

            TemperaturaGrafica.Text = temperaturaGrafica.ToString() + " ºC";
        }


        private void Monitoreo_Click(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Benchmark_Click(object sender, MouseButtonEventArgs e)
        {
            // Lógica para el clic en el elemento de benchmark (puedes abrir una ventana, iniciar una acción, etc.)
        }

        private void Stress_Click(object sender, MouseButtonEventArgs e)
        {
            // Lógica para el clic en el elemento de stress (puedes abrir una ventana, iniciar una acción, etc.)
        }

        private void Ajustes_Click(object sender, MouseButtonEventArgs e)
        {
            // Lógica para el clic en el elemento de ajustes (puedes abrir una ventana, iniciar una acción, etc.)
        }


        public string GetNombreGrafica()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject obj in collection)
                {
                    if (obj["Caption"] != null)
                    {
                        return obj["Caption"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener información de la tarjeta gráfica: " + ex.Message);
            }

            return "Nombre de tarjeta gráfica no encontrado";
        }

        public static string GetNombreProcesador()
        {
            string nombreProcesador = string.Empty;
            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor"))
                {
                    ManagementObjectCollection collection = searcher.Get();
                    foreach (ManagementObject obj in collection)
                    {
                        nombreProcesador = obj["Name"].ToString();
                        break; // Solo necesitas el primer procesador
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores si ocurren
                Console.WriteLine("Error al obtener el nombre del procesador: " + ex.Message);
            }
            return nombreProcesador;
        }

        public static float GetTemperaturaProcesador()
        {
            return 47.66f;
        }

        static float GetTemperaturaGrafica()
        {
            return 88.14f;
        }

        private static ulong GetTotalRAM()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    ulong totalRAM = Convert.ToUInt64(queryObj["TotalPhysicalMemory"]);
                    return totalRAM;
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("Error al recuperar información de RAM: " + e.Message);
            }

            return 0;
        }

        private static string FormatBytes(ulong bytes)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB", "PB" };
            int counter = 0;
            double number = (double)bytes;

            while (number >= 1024)
            {
                number /= 1024;
                counter++;
            }

            return $"{number:n1} {suffixes[counter]}";
        }

        private static float GetRAMUsagePercentage()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    ulong totalRAM = Convert.ToUInt64(queryObj["TotalVisibleMemorySize"]);
                    ulong freeRAM = Convert.ToUInt64(queryObj["FreePhysicalMemory"]);

                    float usedRAM = totalRAM - freeRAM;
                    float ramUsagePercentage = usedRAM / totalRAM * 100.0f;

                    return ramUsagePercentage;
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("Error al recuperar el porcentaje de uso de RAM: " + e.Message);
            }

            return 0.0f;
        }
    }
}
