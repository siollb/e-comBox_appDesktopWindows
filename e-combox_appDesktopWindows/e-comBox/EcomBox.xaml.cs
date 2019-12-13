using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using e_combox_appDesktopWindows.Scripts;
using MaterialDesignThemes.Wpf;

namespace e_combox_appDesktopWindows.e_comBox
{
    /// <summary>
    /// Logique d'interaction pour EcomBox.xaml
    /// </summary>
    public partial class EcomBox : UserControl
    {
        string scriptsDirectory = string.Format(@"..\..\Scripts\");
        string imagesDirectory = string.Format(@"..\..\Images\");
        bool ecomboxIsStarted = false;

        public EcomBox()
        {
            InitializeComponent();
            checkStatus();
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            this.pbLoading.Visibility = Visibility.Visible;
            if(this.ecomboxIsStarted)
            {
                this.stopEcomBox();
            } else
            {
                this.startEcomBox();
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.checkStatus();
        }

        private async void startEcomBox()
        {
            PowerShellExecution pse = new PowerShellExecution();
            string status = await pse.ExecuteShellScript(scriptsDirectory + "startApplication.ps1");
            this.checkStatus();
        }

        private async void stopEcomBox()
        {
            PowerShellExecution pse = new PowerShellExecution();
            string result = await pse.ExecuteShellScript(scriptsDirectory + "stopApplication.ps1");
            this.checkStatus();
        }

        private async void checkStatus()
        {
            PowerShellExecution pse = new PowerShellExecution();
            string status = await pse.ExecuteShellScript(scriptsDirectory + "checkEcomboxStatus.ps1");
            Console.WriteLine("test" + status);
            if (status.Contains("Stopped"))
            {
      
                this.imgStart.Source = new BitmapImage(new Uri(imagesDirectory + "power-off.png", UriKind.Relative));
                this.txtStart.Text = "Démarrer e-comBox";
                this.ecomboxIsStarted = false;
            }
            else
            {
                this.imgStart.Source = new BitmapImage(new Uri(imagesDirectory + "power.png", UriKind.Relative));
                this.txtStart.Text = "Stopper e-comBox";
                this.ecomboxIsStarted = true;
            }
            this.pbLoading.Visibility = Visibility.Hidden;
        }

        private async void Button_Renew_Click(object sender, RoutedEventArgs e)
        {
            PowerShellExecution pse = new PowerShellExecution();
            string result = await pse.ExecuteShellScript(scriptsDirectory + "initialisationApplication.ps1");
            this.checkStatus();
        }

        private async void DialogHost_DialogOpened(object sender, DialogOpenedEventArgs eventArgs)
        {
            PowerShellExecution pse = new PowerShellExecution();
            string result = await pse.ExecuteShellScript(scriptsDirectory + "test.ps1");
            string message = "";

            if(result.Length > 0)
            {
                message = "Vous disposez d'un proxy, veuillez configurer l'adresse ci-dessous dans les paramètres de Docker";
            } else
            {
                message = "Vous ne disposez pas de proxy, veuillez modifier ce paramètre dans Docker, s'il était activé auparavant";
            } 
            var person = new Proxy
            {
                Address = result,
                Message = message
            };

            this.dialogProgress.IsOpen = false;
            
            await this.dialogInfo.ShowDialog(person);
        }

    }
}
