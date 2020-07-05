using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoRPGDemo.Pages.FightSytem
{
    class MintaPlayer
    {
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int MaxMana { get; set; }
        public int Mana { get; set; }
        public int Power { get; set; }

        //public Inventory inventory = new Inventory();

        public MintaPlayer(int maxHealth, int maxMana)
        {
            MaxHealth = Health = maxHealth;
            MaxMana = Mana = maxMana;
            Power = 10;
        }
    }
}
