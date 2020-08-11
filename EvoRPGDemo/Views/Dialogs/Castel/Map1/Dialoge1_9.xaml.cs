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
    /// Interaction logic for Dialoge1_9.xaml
    /// </summary>
    public partial class Dialoge1_9 : Page
    {
        public Dialoge1_9()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Dialoge1_10());
        }
    }
}
