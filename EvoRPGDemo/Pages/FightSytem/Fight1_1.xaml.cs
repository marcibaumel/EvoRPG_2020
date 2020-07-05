﻿using EvoRPG.Classes;
using EvoRPG.Pages.Map.Castel;
using EvoRPGDemo.Classes.Enemys;
using EvoRPGDemo.Pages.Dialogs.Castel.Map1;
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

namespace EvoRPGDemo.Pages.FightSytem
{
    
    public partial class Fight1_1 : Page
    {
        
        private int allDMG = 0;
        
        Player player;
        Ork enemy;
        public Fight1_1()
        {
            InitializeComponent();

            /*
             * NEM tudja beolvasni a player osztály példányát
             * Vissza raktam a simma fight system-be lévő minta osztályt de ezzel sem jobb :(
            */
            
            player = new Player();
            
            progressbar.Value = progressbar.Maximum = player.Health;
            txtHP.Text += progressbar.Value;

            enemy = new Ork(400);
            prbEnemy2.Value = prbEnemy2.Maximum = enemy.Health;
            txtEnemy2.Text += prbEnemy2.Value;


        }
        private void btnItems_Click(object sender, RoutedEventArgs e)
        {
           

            btnPotion1.Visibility = Visibility.Visible;
            btnPotion2.Visibility = Visibility.Visible;
            btnItems.IsEnabled = false;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            if (enemy.Selected)
            {
                int damage = -player.Attack * rnd.Next(1, 3);
                enemy.Health += damage;
                prbEnemy2.Value = enemy.Health;
                txtEnemy2.Text = "HP: " + prbEnemy2.Value;

                if (progressbar.Value == 0)
                {
                    MessageBox.Show("Legyőztt az Ork");
                    this.NavigationService.Navigate(new Fight1_1());
                }

                if (enemy.Health <= 0)
                {
                    
                    brdEnemy2.Visibility = Visibility.Hidden;
                    MessageBox.Show("Legyőzted az Orkot");
                    this.NavigationService.Navigate(new Dialoge2_0());
                }
                else
                {
                    player.Health -= enemy.Attack;
                    progressbar.Value = player.Health;
                    txtHP.Text = "HP: " + progressbar.Value;
                    allDMG -= enemy.Attack;

                    MessageBox.Show("Az ellenség " + enemy.Attack + "-et sebzett beléd Kalandor!\nÖsszesen ennyi sebzést nyeltél be: "
                        + allDMG+"\nTe ennyit ütöttél bele most: " + damage,"HARC", MessageBoxButton.OK);
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

        private void btnPotion2_Click(object sender, RoutedEventArgs e)
        {
            int amount = 100;
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

       
    }
}
