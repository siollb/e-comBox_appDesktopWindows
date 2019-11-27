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
using System.Net;
using System.Net.Mail;

namespace e_combox_appDesktopWindows.H_elp
{
    /// <summary>
    /// Logique d'interaction pour docker.xaml
    /// </summary>
    public partial class Aide : UserControl
    {
        public Aide()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MailMessage msg = new MailMessage("rutily2ajeux@gmail.com",textBoxEmail.Text,textBoxObjet.Text,textBoxMessage.Text);
        }
    }
}
