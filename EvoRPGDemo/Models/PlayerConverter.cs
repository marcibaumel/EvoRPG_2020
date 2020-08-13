using CsvHelper;
using EvoRPG.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoRPGDemo.Models
{
    /*A menüben szereplő .csv fájl tartalmát fogom itt kinyelni és átdani egy 
     * Base Player Osztályba majd később 
     */
    class PlayerConverter
    {
        private void Main()
        {
            using (var reader = new StreamReader("character.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Character>();
            }
        }

        public class Character
        {
            public string Name { get; set; }

            public string Class { get; set; }

            public string Gender { get; set; }

            public int Health { get; set; }
            public int MaxHealth { get; set; }
            public int MaxMana { get; set; }
            public int Attack { get; set; }
            public int Manna { get; set; }

        }


    }
}
