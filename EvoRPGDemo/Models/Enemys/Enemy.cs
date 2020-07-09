using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace EvoRPGDemo.Classes.Enemys
{
    class Enemy
    {
        public int Health { get; set; }
        public bool Selected { get; set; }
        public int Attack { get; set; }

        public BitmapImage dead { get; set; }

        public Enemy(int maxHealth)
        {
            Health = maxHealth;
            Selected = false;
            Attack = 50;
            //dead = new IOHelper().GetBitmapImageByName(@"Resource\FightSystemIMG", "dead");
        }
    }
}
