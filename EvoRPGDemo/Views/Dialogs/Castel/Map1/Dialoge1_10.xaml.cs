using EvoRPG.Pages.Map.Castel;
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

namespace EvoRPGDemo.Pages.Dialogs.Castel.Map1
{
    /// <summary>
    /// Interaction logic for Dialoge1_10.xaml
    /// </summary>
    public partial class Dialoge1_10 : Page
    {
        public Dialoge1_10()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Map1_0());
        }
    }
}
