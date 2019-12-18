using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using e_combox_appDesktopWindows.Scripts;
using MaterialDesignThemes.Wpf;

namespace e_combox_appDesktopWindows.D_ocker
{
    /// <summary>
    /// Logique d'interaction pour docker.xaml
    /// </summary>
    public partial class docker : UserControl
    {

        string scriptsDirectory = string.Format(@"..\..\Scripts\");
        string imagesDirectory = string.Format(@"..\..\Images\");
        bool ecomboxIsStarted = false;
        double statusRamDouble = 0;
        public docker()
        {
            InitializeComponent();
            //CheckRam();
            ProgressBarMemoire.Value = statusRamDouble;
            ProgressBarMemoire.Value = 90;
            ChangeColor(ProgressBarMemoire);

            ProgressBarStockage.Value = 20;
            ChangeColor(ProgressBarStockage);

            ProgressBarProcesseur.Value = 50;
            ChangeColor(ProgressBarProcesseur);
        }
    
        //La couleur change selon la valeur de la ProgressBar
        public void ChangeColor(ProgressBar Progresbar)
        {
            if (Progresbar.Value <= 40)
            {
                System.Windows.Media.Brush brush = Progresbar.Foreground = new SolidColorBrush(Colors.Green);
            }
            else if (Progresbar.Value <= 70)
            {
                System.Windows.Media.Brush brush = Progresbar.Foreground = new SolidColorBrush(Colors.Orange);
            }
            else
            {
                System.Windows.Media.Brush brush = Progresbar.Foreground = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Start_Off_Click(object sender, RoutedEventArgs e)
        {
            //A tester
            ServiceController sc = new ServiceController("com.docker.service");

            if ( sc.Status == ServiceControllerStatus.Running || sc.Status == ServiceControllerStatus.StartPending)
            {
                Process proc = null;
                proc = new Process();
                proc.StartInfo.WorkingDirectory = scriptsDirectory;
                proc.StartInfo.FileName = "Launcher.bat";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();

                proc.Close();

                MessageBox.Show("Docker à été arrêter");
                this.checkStatus();
            }
            else
            {
                Process.Start("C:/Program Files/Docker/Docker/Docker Desktop.exe");
                this.checkStatus();
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ServiceController sc = new ServiceController("com.docker.service");

            //TODO déplacer dans une métode qui prend le statut en paramètre
            if ( sc.Status == ServiceControllerStatus.Running || sc.Status == ServiceControllerStatus.StartPending)
            {
                imgStartOff.Source = new BitmapImage(new Uri(imagesDirectory + "power.png", UriKind.Relative));
                txtStartOff.Text = "Stopper Docker";
            } else
            {
                imgStartOff.Source = new BitmapImage(new Uri(imagesDirectory + "power-off.png", UriKind.Relative));
                txtStartOff.Text = "Démarrer Docker";
            }
        }

        private async void checkStatus()
        {
            PowerShellExecution pse = new PowerShellExecution();
            string status = await pse.ExecuteShellScript(scriptsDirectory + "checkEcomboxStatus.ps1");
            Console.WriteLine("test" + status);
            if (status.Contains("Stopped"))
            {

                this.imgStartOff.Source = new BitmapImage(new Uri(imagesDirectory + "power-off.png", UriKind.Relative));
                this.txtStartOff.Text = "Démarrer docker";
                this.ecomboxIsStarted = false;
            }
            else
            {
                this.imgStartOff.Source = new BitmapImage(new Uri(imagesDirectory + "power.png", UriKind.Relative));
                this.txtStartOff.Text = "Stopper docker";
                this.ecomboxIsStarted = true;
            }
            this.pbLoading.Visibility = Visibility.Hidden;
        }
       /* private async void CheckRam()
        {
            PowerShellExecution pse = new PowerShellExecution();
            string statusram = await pse.ExecuteShellScript(scriptsDirectory + "CheckRam.ps1");
            Console.WriteLine("testram" + statusram.Substring(20));
            statusRamDouble = Convert.ToDouble(statusram.Substring(20));
        }*/
        /*static void Main()
        {
            var pc = new PerformanceCounter("Mono Memory", "Total Physical Memory");
            Console.WriteLine("Physical RAM (bytes): {0}", pc.RawValue);
        }*/

        private async void Button_Relancer_Click(object sender, RoutedEventArgs e)
        {
            PowerShellExecution pse = new PowerShellExecution();
            string status = await pse.ExecuteShellScript(scriptsDirectory + "restartDocker.ps1");
            this.checkStatus();
        }
    }
}
