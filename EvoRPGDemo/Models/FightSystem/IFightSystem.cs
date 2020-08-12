using EvoRPGDemo.Classes.Enemys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoRPGDemo.Models.IFightSystem
{
    interface IFightSystem<Player>
    {
        /*Azt akarom itt megoldani, hogy
         * mikor a használó osztály valamilyen függvényt hivan meg
         * akkor az innen történjen, hogy miket is kell haználnia.
         */

        void Attack1(Player player, Enemy enemy1, Enemy enemy2);

    }
}
