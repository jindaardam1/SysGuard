using System;
using System.Windows;
using System.Windows.Input;

namespace SysGuard
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MostrarSplashScreen();
        }

        private void MostrarSplashScreen()
        {
            var pi = new SplashScreen();
            MainContent.Content = pi;

            var timer = new System.Windows.Threading.DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1.2)
            };
            timer.Tick += (sender, e) =>
            {
                timer.Stop();
                MostrarMenuPrincipal();
            };
            timer.Start();
        }

        private void MostrarMenuPrincipal()
        {
            var menuPrincipalView = new MenuPrincipal();
            MainContent.Content = menuPrincipalView;
        }

        private void CerrarConEscape(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Application.Current.Shutdown();
            }
        }

        private void Minimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Restaurar_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void Cerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
