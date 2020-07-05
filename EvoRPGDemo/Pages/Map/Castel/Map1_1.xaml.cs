using EvoRPGDemo.Pages.FightSytem;
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

namespace EvoRPG.Pages.Map.Castel
{
    /// <summary>
    /// Interaction logic for Map1_1.xaml
    /// </summary>
    public partial class Map1_1 : Page
    {
        public Map1_1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Fight1_2());
        }

        private void NoRoom1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Szoba Bezárva");
        }

        private void NoRoom2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Szobához Kulcs Kell");
        }
    }
}
