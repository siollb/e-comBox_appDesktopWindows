using System;
using System.ServiceProcess;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace e_combox_appDesktopWindows.D_ocker
{
    /// <summary>
    /// Logique d'interaction pour docker.xaml
    /// </summary>
    public partial class docker : UserControl
    {

        string scriptsDirectory = string.Format(@"..\..\Scripts\");
        string imagesDirectory = string.Format(@"..\..\Images\");

        public docker()
        {
            InitializeComponent();
        }

        private void Button_Start_Off_Click(object sender, RoutedEventArgs e)
        {
            //A tester
            ServiceController sc = new ServiceController("com.docker.service");

            if (sc != null || sc.Status == ServiceControllerStatus.Running || sc.Status == ServiceControllerStatus.StartPending)
            {
                sc.Stop();
            }
            else
            {
                sc.Start();
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ServiceController sc = new ServiceController("com.docker.service");

            //TODO déplacer dans une métode qui prend le statut en paramètre
            if (sc != null || sc.Status == ServiceControllerStatus.Running || sc.Status == ServiceControllerStatus.StartPending)
            {
                imgStartOff.Source = new BitmapImage(new Uri(imagesDirectory + "power.png", UriKind.Relative));
                txtStartOff.Text = "Stopper Docker";
            } else
            {
                imgStartOff.Source = new BitmapImage(new Uri(imagesDirectory + "power-off.png", UriKind.Relative));
                txtStartOff.Text = "Démarrer Docker";
            }
        }
    }
}
