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
using System.Windows.Threading;

namespace SysGuard
{
    /// <summary>
    /// Lógica de interacción para SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : UserControl
    {
        private List<string> funnyMessages = new List<string>
        {
            "Sintonizando el canal RAM...",
            "Calculando la velocidad de la luz en cables...",
            "Buscando unicornios de silicio...",
            "Reorganizando los transistores...",
            "Cocinando bytes a fuego lento...",
            "Entrenando a los hamsters en las ruedas...",
            "Construyendo puentes de datos...",
            "Desenredando cables de red...",
            "Alineando los bits en fila...",
            "Persiguiendo píxeles fugitivos...",
        };


        private Random random = new Random();
        private DispatcherTimer timer = new DispatcherTimer();

        public SplashScreen()
        {
            InitializeComponent();
            timer.Tick += ChangeLoadingText;
            SetRandomInterval();
            timer.Start();
        }

        private void ChangeLoadingText(object sender, EventArgs e)
        {
            int index = random.Next(funnyMessages.Count);
            loadingText.Text = funnyMessages[index];
            SetRandomInterval();
        }

        private void SetRandomInterval()
        {
            double randomInterval = random.NextDouble() * (0.3 - 0.05) + 0.05;
            timer.Interval = TimeSpan.FromSeconds(randomInterval);
        }
    }
}
