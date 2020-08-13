using CsvHelper;
using EvoRPG.Classes;
using EvoRPG.Pages.Map.Castel;
using EvoRPGDemo.Pages.MENU;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace EvoRPG.Views.MENU
{
    /// <summary>
    /// Interaction logic for Creat.xaml
    /// </summary>
    public partial class Creat : Page
    {
        public string[] classes { get; set; }

        public string[] genders { get; set; }

        string filepath = "character.csv";

        Player player;

        public Creat()
        {
            InitializeComponent();
            classes = new string[] { "Human", "Warrior", "Mage", "Rouge" };
            genders = new string[] { "Male", "Female" };
            DataContext = this;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            int health = 1000;
            int attack = 200;
            int manna = 30;
            string name = txtName.Text;
            string playerClass = (string)combClasses.SelectedItem;
            string gender = (string)combGenders.SelectedItem;
            player = new Player(name, playerClass, gender, health, attack, manna);
            SaveCharacter(player, filepath);
            btnView.Visibility = Visibility.Visible;

        }
        private void SaveCharacter(Player player, string filepath)
        {

            using (var writer = new StreamWriter(filepath))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecord<Player>(player);
                }
            }
            btnView.Visibility = Visibility.Visible;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Menu());
        }
        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            
            if (MessageBox.Show(player.ToString(), "Saved Character", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                this.NavigationService.Navigate(new Intro());
                
            }
            


        }
    }
}
