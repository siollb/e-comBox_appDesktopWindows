using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace Projet_E_Combox
{
    /// <summary>
    /// Logique d'interaction pour Page1.xaml
    /// </summary>
    public partial class Page1 : UserControl
    {
        string FichBat = string.Format(@"C:/Program Files/e-comBox/scripts/");

        public Page1()
        {
         InitializeComponent();
        }
        private void Button_Alu_Click(object sender, RoutedEventArgs e)
        {
            Process proc = null;
            proc = new Process();
            proc.StartInfo.WorkingDirectory = FichBat;
            proc.StartInfo.FileName = "lanceScriptPS_lanceURL.bat";
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();

            proc.Close();
        }
        private void Bouton_Eteindre_Click(object sender, RoutedEventArgs e)
        {
            Process proc = null;
            proc = new Process();
            proc.StartInfo.WorkingDirectory = FichBat;
            proc.StartInfo.FileName = "lanceScriptPS_stopDocker.bat";
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();

            proc.Close();
        }
        private void Bouton_Reini_Click(object sender, RoutedEventArgs e)
        {
            Process proc = null;
            proc = new Process();
            proc.StartInfo.WorkingDirectory = FichBat;
            proc.StartInfo.FileName = "lanceScriptPS_restartApplication.bat";
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();

            proc.Close();
        }
        private void Bouton_Verif_Click(object sender, RoutedEventArgs e)
        {
            Process proc = null;
            proc = new Process();
            proc.StartInfo.WorkingDirectory = FichBat;
            proc.StartInfo.FileName = "lanceScriptPS_configEnvironnement.bat";
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();

            proc.Close();
        }
        private void Bt_Menu1_Checked(object sender, RoutedEventArgs e)
        {
            // R
        }
        private void Bt_Menu2_Checked(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            InitializeComponent();
            Page2 page2 = new Page2();
            this.Content = page2;
        }
        private void Bt_Menu3_Checked(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            InitializeComponent();
            Page3 page3 = new Page3();
            this.Content = page3;
        }

        private void Bt_Menu4_Checked(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            InitializeComponent();
            Page4 page4 = new Page4();
            this.Content = page4;
        }

        private void Bt_Menu5_Checked(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            InitializeComponent();
            Page5 page5 = new Page5();
            this.Content = page5;
        }
    }
}

