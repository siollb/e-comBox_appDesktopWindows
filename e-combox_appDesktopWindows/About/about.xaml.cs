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

namespace e_combox_appDesktopWindows.A_bout
{
    /// <summary>
    /// Logique d'interaction pour docker.xaml
    /// </summary>
    public partial class about : UserControl
    {
        public about()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
                Process.Start("https://creativecommons.org/licenses/by-nc-sa/2.0/fr/");
        }
    }
}
