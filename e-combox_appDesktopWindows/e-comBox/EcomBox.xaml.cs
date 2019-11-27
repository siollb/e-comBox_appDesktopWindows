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

namespace e_combox_appDesktopWindows.e_comBox
{
    /// <summary>
    /// Logique d'interaction pour EcomBox.xaml
    /// </summary>
    public partial class EcomBox : UserControl
    {
        string FichBat = string.Format(@"..\..\Scripts\");
        public EcomBox()
        {
            InitializeComponent();
        }

        private void Button_Configure_Click(object sender, RoutedEventArgs e)
        {
            Process proc = null;
            proc = new Process();
            proc.StartInfo.WorkingDirectory = FichBat;
            proc.StartInfo.FileName = "configure_application.bat";
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();

            proc.Close();
        }

    }
}
