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
using System.ServiceProcess;

namespace e_combox_appDesktopWindows.e_comBox
{
    /// <summary>
    /// Logique d'interaction pour EcomBox.xaml
    /// </summary>
    public partial class EcomBox : UserControl
    {
        //   string FichBat = string.Format(@"..\..\Scripts\");
        string FichBat = string.Format(@"C:/Program Files/e-comBox/scripts/");
        public EcomBox()
        {
            InitializeComponent();
        }


        private void Button_Configure_Click(object sender, RoutedEventArgs e)
        {
            Process proc = null;
            proc = new Process();
            proc.StartInfo.WorkingDirectory = FichBat;
            proc.StartInfo.FileName = "lanceScriptPS_configEnvironnement.bat";
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();
            testdocker();
            proc.Close();

        }


        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {

            Process proc = null;
            proc = new Process();
            proc.StartInfo.WorkingDirectory = FichBat;
            proc.StartInfo.FileName = "lanceScriptPS_lanceURL.bat";
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();
            testdocker();
            proc.Close();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            testdocker();
        }

        private void testdocker()
        {
            ServiceController sc = new ServiceController("com.docker.service");

            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    test.Content = "Running";
                    break;
                case ServiceControllerStatus.Stopped:
                    test.Content = "Stopped";
                    break;
                case ServiceControllerStatus.Paused:
                    test.Content = "Paused";
                    break;
                case ServiceControllerStatus.StopPending:
                    test.Content = "Stopping";
                    break;
                case ServiceControllerStatus.StartPending:
                    test.Content = "Starting";
                    break;
                default:
                    test.Content = "Status Changing";
                    break;
            }

            sc.Stop();
        }

        private void Button_Renew_Click(object sender, RoutedEventArgs e)
        {
            Process proc = null;
            proc = new Process();
            proc.StartInfo.WorkingDirectory = FichBat;
            proc.StartInfo.FileName = "lanceScriptPS_restartApplication.bat";
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();
            testdocker();
            proc.Close();
        }



    }

}