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
            MailMessage msg = new MailMessage("support@e-combox.com", "support@e-combox.com", textBoxObjet.Text, (textBoxMessage.Text + " Envoyer par : " + textBoxEmail.Text));
            msg.IsBodyHtml = true;
            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            sc.UseDefaultCredentials = false;
            NetworkCredential cre = new NetworkCredential("e-combox@gmail.com", "mot de passe mail e-combox");//your mail password
            sc.Credentials = cre;
            sc.EnableSsl = true;
            sc.Send(msg);
            MessageBox.Show("Votre mail à bien été envoyé. Nous vous répondront le plus rapidement possible.");
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Process.Start("https://docs.google.com/document/d/1TFIZhMJ8LuhDuMtZ8uEehwqxDZe1cgCrR5f0mdYig_o/edit");
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Process.Start("https://docs.google.com/document/d/1c7jC1GkzslylnLL1sFfqMScAZeQNNsgzq2ldhsIQ7fs/edit#heading=h.nnpj701uzker");
        }
    }
}
