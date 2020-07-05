using EvoRPG.Classes;
using EvoRPGDemo.Pages.Dialogs.Castel.Map1;
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
    /// Interaction logic for Map1_0.xaml
    /// </summary>
    public partial class Map1_0 : Page
    {
        
        public Map1_0()
        {
            
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Fight1_1());
            //this.NavigationService.Navigate(new Map1_1());
        }

        private void swordBtn_Click(object sender, RoutedEventArgs e)
        {
            swordBtn.Visibility = Visibility.Hidden;
            //Player.Attack += 25;
            MessageBox.Show(" Felvetted a legendás kardot");
        }
    
    }
}
