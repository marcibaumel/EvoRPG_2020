using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoRPGDemo.Classes.Enemys
{
    class Ork
    {
        public int Health { get; set; }
        public bool Selected { get; set; }
        public int Attack { get; set; }

        //public BitmapImage dead { get; set; }

        public Ork(int maxHealth)
        {
            
            Health = maxHealth;
            Selected = false;
            Attack = 120;
            //dead = new IOHelper().GetBitmapImageByName(@"Resource\FightSystemIMG", "dead");
        }
    }
}
