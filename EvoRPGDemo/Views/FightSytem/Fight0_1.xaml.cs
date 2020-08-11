using CsvHelper;
using EvoRPG.Classes;
using EvoRPG.Views.Map.Castel;
using EvoRPGDemo.Classes.Enemys;
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

namespace EvoRPGDemo.Views.FightSytem
{
    /// <summary>
    /// Interaction logic for Fight0_1.xaml
    /// </summary>
    public partial class Fight0_1 : Page
    {
        private int allDMG = 0;
        Player player;
        Enemy enemy;
        public Fight0_1()
        {
            InitializeComponent();

            /*
             * NEM tudja beolvasni a player osztály példányát
             * Vissza raktam a simma fight system-be lévő minta osztályt de ezzel sem jobb :(
            */
            //int health2 = 
            player = new Player(Name, "Warrior", "Male", 1050, 50, 50);
            //player = new Player();
            progressbar.Value = progressbar.Maximum = player.Health;
            txtHP.Text += progressbar.Value;

            enemy = new Enemy(100);
            prbEnemy2.Value = prbEnemy2.Maximum = enemy.Health;
            txtEnemy2.Text += prbEnemy2.Value;

            
        }
        private void btnItems_Click(object sender, RoutedEventArgs e)
        {
            //frameItem.Visibility = Visibility.Visible;
            //frameItem.NavigationService.Navigate(new ItemsPage());

            btnPotion1.Visibility = Visibility.Visible;
            btnPotion2.Visibility = Visibility.Visible;
            btnItems.IsEnabled = false;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (enemy.Selected)
            {
                int damage = /*sablon*/-player.Attack;
                enemy.Health += damage;
                prbEnemy2.Value = enemy.Health;
                txtEnemy2.Text = "HP: " + prbEnemy2.Value;
                if (enemy.Health <= 0)
                {
                    //imgEnemy.Source = enemy.dead;
                    brdEnemy2.Visibility = Visibility.Hidden;
                    this.NavigationService.Navigate(new Map1_1());
                }
                else
                {
                    player.Health -= enemy.Attack;
                    progressbar.Value = player.Health;
                    txtHP.Text = "HP: " + progressbar.Value;
                    allDMG -= enemy.Attack;

                    MessageBox.Show("Az ellenség " + enemy.Attack + "-et sebzett beléd Kalandor!\nÖsszesen ennyi sebzést nyeltél be: "
                        + allDMG, "DMG Jelző. Te ennyit ütöttél bele most: " + damage, MessageBoxButton.OK);
                }
            }
        }
        private void stpEnemy2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (enemy.Selected)
            {
                enemy.Selected = false;
                brdEnemy2.BorderThickness = new Thickness(0);
            }
            else
            {
                enemy.Selected = true;
                brdEnemy2.BorderThickness = new Thickness(5);
            }
        }

        private void btnPotion1_Click(object sender, RoutedEventArgs e)
        {
            int amount = 25;
            int value = player.Health + amount;
            if (value > player.MaxHealth)
                player.Health = player.MaxHealth;
            else
                player.Health = value;
            progressbar.Value = player.Health;
            txtHP.Text = "HP: " + progressbar.Value;

            btnItems.IsEnabled = true;
            btnPotion1.Visibility = Visibility.Hidden;
            btnPotion2.Visibility = Visibility.Hidden;
        }

        private void btnPotion2_Click(object sender, RoutedEventArgs e)
        {
            int amount = 50;
            int value = player.Health + amount;
            if (value > player.MaxHealth)
                player.Health = player.MaxHealth;
            else
                player.Health = value;
            progressbar.Value = player.Health;
            txtHP.Text = "HP: " + progressbar.Value;

            btnItems.IsEnabled = true;
            btnPotion1.Visibility = Visibility.Hidden;
            btnPotion2.Visibility = Visibility.Hidden;
        }
        /*
public class BaseCharacter
{
public string Name2 { get; set; }

public string Class2 { get; set; }

public string Gender2 { get; set; }
public int Health2 { get; set; }
public int Attack2 { get; set; }
public int Manna2 { get; set; }

//public setter_metod();
public void setterMetod()
{
using (var reader = new StreamReader("D:/WORK/FINAL/DEMO/IDE/EvoRPGDemo/bin/Debug/character.csv"))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
  csv.Configuration.HasHeaderRecord = false;
  var records = csv.GetRecords<BaseCharacter>();


}
}
}*/

    }
}
