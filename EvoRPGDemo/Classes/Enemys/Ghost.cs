using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoRPG.Classes.Enemys
{
    class Ghost
    {
        public int Health { get; set; }
        public bool Selected { get; set; }
        public int Attack { get; set; }

        //public BitmapImage dead { get; set; }

        public Ghost(int maxHealth)
        {

            Health = maxHealth;
            Selected = false;
            Attack = 120;
            //dead = new IOHelper().GetBitmapImageByName(@"Resource\FightSystemIMG", "dead");
        }
    }
}
