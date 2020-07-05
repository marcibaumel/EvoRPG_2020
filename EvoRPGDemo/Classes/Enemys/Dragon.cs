using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoRPGDemo.Classes.Enemys
{
    class Dragon
    {
        public int Health { get; set; }
        public bool Selected { get; set; }
        public int Attack { get; set; }

        //public BitmapImage dead { get; set; }

        public Dragon(int maxHealth)
        {
            
            Health = maxHealth;
            Selected = false;
            Attack = 300 ;
            //dead = new IOHelper().GetBitmapImageByName(@"Resource\FightSystemIMG", "dead");
        }
    }
}
