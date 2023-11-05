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

        private void GridProcesador_OnLoaded(object sender, RoutedEventArgs e)
        {
            NombreProcesador.Text = GetNombreProcesador();
            TemperaturaProcesador.Text = GetTemperaturaProcesador().ToString();
        }

        private void GridRAM_OnLoaded(object sender, RoutedEventArgs e)
        {
            CantidadRAM.Text = "RAM total: " + FormatBytes(GetTotalRAM());
            PorcentajeRAM.Text = "USO DE RAM: " + GetRAMUsagePercentage().ToString("0.00") + "%";
        }

        private void GridGrafica_OnLoaded(object sender, RoutedEventArgs e)
        {
            NombreGrafica.Text = GetNombreGrafica();
            TemperaturaGrafica.Text = GetTemperaturaGrafica().ToString();
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
            Computer computer = new Computer();
            computer.CPUEnabled = true; // Habilita la monitorización de la CPU
            computer.Open();

            float temperaturaCPU = 0.0f;

            foreach (var hardware in computer.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("Core"))
                        {
                            temperaturaCPU = sensor.Value ?? 0.0f;
                            break; // Solo necesitas la temperatura del primer núcleo
                        }
                    }
                }
            }

            computer.Close();
            return temperaturaCPU;
        }

        static float GetTemperaturaGrafica()
        {
            Computer computer = new Computer
            {
                CPUEnabled = true,
                GPUEnabled = true
            };
            var hardware = computer.Hardware.FirstOrDefault(h => h.HardwareType == HardwareType.GpuNvidia || h.HardwareType == HardwareType.GpuAti);

            if (hardware == null)
            {
                return 0; // No se encontró una tarjeta gráfica
            }

            hardware.Update();

            var sensor = hardware.Sensors.FirstOrDefault(s => s.SensorType == SensorType.Temperature);

            if (sensor == null)
            {
                return 0; // No se encontró un sensor de temperatura
            }

            return sensor.Value ?? 0; // Retorna la temperatura o -1 si no se pudo obtener
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
