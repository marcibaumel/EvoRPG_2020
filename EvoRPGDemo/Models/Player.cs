using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoRPG.Models
{
    public class Player
    {
        public string Name { get; set; }

        public string Class { get; set; }

        public string Gender { get; set; }

        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
        public int Attack { get; set; }
        public int Manna { get; set; }

        public Player(string name, string playerClass, string gender, int health, int attack, int manna)
        {
            this.Name = name;
            Class = playerClass;
            this.Gender = gender;
            switch (Class)
            {
                case "Human":
                    this.Attack = attack + 5;
                    this.Manna = manna + 10;
                    this.Health = health + 20;
                    break;
                case "Warrior":
                    this.Attack = attack + 15;
                    this.Manna = manna + 0;
                    this.Health = health + 50;
                    break;
                case "Mage":
                    this.Attack = attack + 5;
                    this.Manna = manna + 35;
                    this.Health = health + 5;
                    break;
                case "Rouge":
                    this.Attack = attack + 10;
                    this.Manna = manna + 10;
                    this.Health = health + 10;
                    break;
            }
            MaxHealth = this.Health;
            MaxMana = this.MaxMana;
        }

        /*
        public override string ToString()
        {
            return "Name: " + Name + ", Class: " + Class + ", Gender: " + Gender + ", HP: " + Health + ", DMG: " + Attack + ", Manna: " + Manna;
        }
        */
        /*
        public Player()
        {
            Class = "Human";
            switch (Class)
            {

                case "Human":
                    this.Attack = 50 + 5;
                    this.Manna = 30 + 10;
                    this.Health = 1000 + 20;
                    break;
                case "Warrior":
                    this.Attack = 50 + 15;
                    this.Manna = 30 + 0;
                    this.Health = 1000 + 20;
                    break;
                case "Mage":
                    this.Attack = 50 + 5;
                    this.Manna = 30 + 35;
                    this.Health = 1000 + 20;
                    break;
                case "Rouge":
                    this.Attack = 50 + 10;
                    this.Manna = 40 + 10;
                    this.Health = 1000 + 20;
                    break;
            }
            this.MaxHealth = Health;
            this.MaxMana = Manna;
            this.Gender = Gender;
            this.Name = Name;
        }
        */
    }
}
