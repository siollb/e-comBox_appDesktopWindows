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

namespace Projet_E_Combox
{
    /// <summary>
    /// Logique d'interaction pour page5.xaml
    /// </summary>
    public partial class Page5 : UserControl
    {
        public Page5()
        {
            InitializeComponent();
        }
        private void Bt_Menu1_Checked(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            InitializeComponent();
            Page1 page1 = new Page1();
            this.Content = page1;

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

        private void Bt_Menu5_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void Bt_Menu4_Checked(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            InitializeComponent();
            Page4 page4 = new Page4();
            this.Content = page4;
        }
    }
}
